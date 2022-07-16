using System;

namespace WebAppStudentMVC.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public string Address { get; set; }
        public string Carrear { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public string StateStudent { get; set; }
    }

    public static class State
    {
        public const string RegularStudent = "Alumno Regular", Graduated = "Titulado";
    }
}
