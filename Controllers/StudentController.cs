using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;


using WebAppStudentMVC.Models.ViewModels;
using WebAppStudentMVC.Models;

namespace WebAppStudentMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("RegularStudent");
        }

        public IActionResult RegularStudent() 
        {
            ViewData["title"] = "Lista de estudiantes regulares";

            StudentViewModel viewModel = new StudentViewModel();

            List<Student> regularStudent = DataMock.Students
                .Where(i => i.StateStudent.Equals(State.RegularStudent)).ToList();

            viewModel.Students = regularStudent;
            viewModel.StudentCount = regularStudent.Count;

            return View("Index", viewModel);
        }

        public IActionResult GraduatedStudent()
        {
            ViewData["title"] = "Lista de estudiantes titulados";
            StudentViewModel viewModel = new StudentViewModel();
            //forma 1 -> por for
            List<Student> graduatedStudent = new List<Student>();

            //foreach (Student s in DataMock.Students)
            //{
            //    if (s.StateStudent.Equals(State.Graduated))
            //    {
            //        graduatedStudent.Add(s);
            //    }
            //}

            //forma 2 -> por Linq
            graduatedStudent = DataMock.Students.Where(i => i.StateStudent.Equals(State.Graduated)).ToList();
            viewModel.Students = graduatedStudent;
            viewModel.StudentCount = graduatedStudent.Count;

            return View(viewModel);
        }
    }

}
