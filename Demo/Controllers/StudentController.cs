using Demo.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class StudentController : Controller
    {
        DemoContext context = new DemoContext();
        public IActionResult Index()
        {
            ViewBag.data = context.Students.ToList();

            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {//hello im here
            context.Students.Add(student);
            context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            //hello im here
            ViewBag.item= context.Students.Find(id);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
            return RedirectToAction("index");
        }

      
        public IActionResult Delete(int id)
        {
            context.Students.Remove(new Student() { StudentId=id});
            context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
