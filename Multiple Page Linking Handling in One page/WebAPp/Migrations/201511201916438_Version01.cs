namespace WebAPp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        ADepartment_DepartmentId = c.Int(),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Departments", t => t.ADepartment_DepartmentId)
                .Index(t => t.ADepartment_DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        CourseId = c.Int(nullable: false),
                        VDepartment_DepartmentId = c.Int(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Departments", t => t.VDepartment_DepartmentId)
                .Index(t => t.CourseId)
                .Index(t => t.VDepartment_DepartmentId);
            
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        AStudent_StudentId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.AStudent_StudentId)
                .Index(t => t.AStudent_StudentId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ProductId = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shops", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Logins", "AStudent_StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "VDepartment_DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Courses", "ADepartment_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Shops", new[] { "ProductId" });
            DropIndex("dbo.Logins", new[] { "AStudent_StudentId" });
            DropIndex("dbo.Students", new[] { "VDepartment_DepartmentId" });
            DropIndex("dbo.Students", new[] { "CourseId" });
            DropIndex("dbo.Courses", new[] { "ADepartment_DepartmentId" });
            DropTable("dbo.Shops");
            DropTable("dbo.Products");
            DropTable("dbo.Logins");
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
        }
    }
}
