using Microsoft.AspNetCore.Mvc;
using MVC_test.DataBase;
using MVC_test.Models;

namespace MVC_test.Controllers
{
    public class PostController : Controller
    {
        [HttpPost]
        public ActionResult CrateStudent(Student student)
        {
            //if (ModelState.IsValid) { }
            if (student == null)
                return BadRequest();
            db.students.Add(student);
            return RedirectToAction("GetData");
            

        }


        public ActionResult GetData()
        {
            var data=db.students;
            //return View(data);
            return View("Showdata",data);
        }
        
        
    }
}
