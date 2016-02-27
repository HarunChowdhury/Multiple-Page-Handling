using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using WebAPp.Models;
using Login = System.Web.UI.WebControls.Login;

namespace WebAPp.Controllers
{
    public class LoginController : Controller
    {
        private UniversityContext db = new UniversityContext();


        //public ActionResult Create([Bind(Include = "StudentId,Name,Email,CourseId")] Student student)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Students.Add(student);

        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.CourseId = new SelectList(db.Courses, "CourseId", "Code", db.Courses);
        //    return View(student);
        //}

        // GET: Login
        public ActionResult Index(Login model, string command)
        {

          //ViewBag.Name= new SelectList(db.Students.ToList(),"Name","Name");
          //ViewBag.Email = new SelectList(db.Students.ToList(), "Email", "Email");

            //var name = ViewBag.Name;

            var userName = from name in db.Students
                            select new {name.Name};

            if (command == "Login")
              {

                  foreach (var item in userName) 
                  {
                     if (model.UserName ==item.ToString())
                          {
                              ViewBag.msg = "UserName Or Password Not Match";
                              return View(); 
                             

                          }
                    
                  }

                  return RedirectToAction("Create", "Shop");
                
                }
         
            else if (command == "Register")
            {
               
               
                return RedirectToAction("Create", "Student");
            }

            else if (command == "Cancel")
            {
                // do stuff  
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Index");
            }  
        }
    }
}