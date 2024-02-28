using Microsoft.AspNetCore.Mvc;
using project_3.Models;
using System.Xml.Linq;

namespace project_3.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student{SId=1,SName="Prince",SClass="11A",SAge=17,SAddress="ABC"},
            new Student{SId=2,SName="Kumar",SClass="11B",SAge=17,SAddress="XYZ"},
            new Student{SId=3,SName="pavan",SClass="12A",SAge=18,SAddress="WEX"},
            new Student{SId=4,SName="Chung",SClass="12B",SAge=18,SAddress="CXZ"},
            new Student{SId=5,SName="Federal",SClass="10A",SAge=16,SAddress="BLY"},
        };
        public IActionResult Index()  
        { 
            return View(student);   
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                student.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

    }
}
