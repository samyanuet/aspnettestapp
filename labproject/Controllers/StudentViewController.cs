using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace labproject.Controllers
{
    public class StudentViewController : Controller
    {
        // GET: StudentView
        public ActionResult StudentList()
        {
            return View();
        }

        public ActionResult AddStudentPage()
        {
            return View();
        }
    }
}