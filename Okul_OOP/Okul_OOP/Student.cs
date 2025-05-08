using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    // Öğrenci Sınıfı (IOgrenci arayüzünü uyguluyor)
    public class Student:IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string StudentNo { get; set; }
        public List<ICourse> CoursesTaken { get; set; }
        public DateTime Birthdate { get; set; }

        public Student()
        {
            CoursesTaken = new List<ICourse>();
        }

        public string FullName()
        {
            return $"{Name} {Surname}";
        }

        public int  CalculateAge()
        {
            TimeSpan difference = DateTime.Now - BirthDate;
            return (int)(difference.TotalDays / 365.25);
        }

        public void AddCourse(ICourse course)
        {
            CoursesTaken.Add(course);
            Console.WriteLine($"{FullName()} adlı öğrenciye {course.Name} dersi eklendi.");
        }

        public void ListCourses()
        {
            Console.WriteLine($"{FullName()} adlı öğrencinin aldığı dersler:");
            foreach (var course in CoursesTaken)
            {
                Console.WriteLine($"- {course.Name}");
            }
        }
    }
}
