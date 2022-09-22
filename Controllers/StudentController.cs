using WebApplicationCore1.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore1.Models;
using WebApplicationCore1.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplicationCore1.Controllers
{

    public class StudentController : Controller
    {
        private readonly DataContext _dataContext;
        public StudentController(DataContext dataContext)
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
            var Students = _dataContext.Student.ToList();
            return View(Students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var Courses = _dataContext.Course.Select(x => new SelectListItem()
            {
                Text=x.Title,
                Value=x.Id.ToString()
            }).ToList();
            CreateStudentViewModel vm = new CreateStudentViewModel();
            vm.Courses = Courses;
            return View(vm);
        }
        [HttpGet]
        public IActionResult Details(int Id)
        {
            var Students = _dataContext.Student.Where(x => x.Id == Id).FirstOrDefault();
            return View(Students);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var Students = _dataContext.Student.Where(x => x.Id == Id).FirstOrDefault();
            return View(Students);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var Students = _dataContext.Student.Where(x => x.Id == Id).FirstOrDefault();
            return View(Students);
        }

        /// <summary>
        /// Post Section
        /// </summary>
        /// <returns></returns>
        /// 

        [HttpPost]
        public async Task<IActionResult> Create(CreateStudentViewModel Model)
        {

            var student = new Student()
            {
                Name = Model.Name,
                Enrolled = Model.Enrolled
            };

            var SelectedCourses = Model.Courses.Where(x => x.Selected).Select(y => y.Value).ToList();
            foreach(var Item in SelectedCourses)
            {
                student.Enrollment.Add(new StudentCourse()
                {
                    CourseId=int.Parse(Item)
                });
            }
            _dataContext.Student.Add(student);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(Student Model)
        {
            _dataContext.Student.Update(Model);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(Student Model)
        {
            _dataContext.Student.Remove(Model);
            _dataContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
