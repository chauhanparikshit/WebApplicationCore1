using WebApplicationCore1.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore1.Models;

namespace WebApplicationCore1.Controllers
{
    public class CourseController : Controller
    {
        private readonly DataContext _dataContext;
        public CourseController (DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        /// <summary>
        /// Get Section
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            var Courses = _dataContext.Course.ToList();
            return View(Courses);
        }
        [HttpGet]
        public IActionResult Create()
        {            
            return View();
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var Course = _dataContext.Course.Where(x => x.Id == Id).FirstOrDefault();
            return View(Course);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var Course = _dataContext.Course.Where(x => x.Id == Id).FirstOrDefault();
            return View(Course);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var Course = _dataContext.Course.Where(x => x.Id == Id).FirstOrDefault();
            return View(Course);
        }

        /// <summary>
        /// Post Section
        /// </summary>
        /// <returns></returns>
        /// 

        [HttpPost]
        public IActionResult Create( Course Model)
        {
            _dataContext.Course.Add(Model);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Course Model)
        {
            _dataContext.Course.Update(Model);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Course Model)
        {
            _dataContext.Course.Remove(Model);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
