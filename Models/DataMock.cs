using System;
using System.Collections.Generic;

using WebAppStudentMVC.Models;

namespace WebAppStudentMVC.Models
{
    public static class DataMock
    {
        public static List<Student> Students = new List<Student>() {
            new Student() { StartDate = new DateTime(2020, 05, 05), FirstName = "Gustavo", LastName = "Rebolledo",
                            Address = "Carrera #123", Dni = "11.111.111-1",
                            Email = "gustavo.rebolledo@virginiogomez.cl", Carrear = "Analista Programador", StateStudent = State.RegularStudent },
            new Student() { StartDate = new DateTime(2020, 05, 05), FirstName = "Gustavo", LastName = "Rebolledo",
                            Address = "Carrera #123", Dni = "11.111.111-1",
                            Email = "gustavo.rebolledo@virginiogomez.cl", Carrear = "Analista Programador", StateStudent = State.Graduated  },
            new Student() { StartDate = new DateTime(2020, 05, 05), FirstName = "Gustavo", LastName = "Rebolledo",
                            Address = "Carrera #123", Dni = "11.111.111-1",
                            Email = "gustavo.rebolledo@virginiogomez.cl", Carrear = "Analista Programador", StateStudent = State.Graduated  },
            new Student() { StartDate = new DateTime(2020, 05, 05), FirstName = "Gustavo", LastName = "Rebolledo",
                            Address = "Carrera #123", Dni = "11.111.111-1",
                            Email = "gustavo.rebolledo@virginiogomez.cl", Carrear = "Analista Programador", StateStudent = State.RegularStudent  }
        };

        public static bool AddStudent(Student student)
        {
            try
            {
                Students.Add(student);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
