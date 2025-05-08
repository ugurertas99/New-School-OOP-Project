using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    public class Teacher : ITeacher 
    {
        public string Subject { get; set; }
        public List<ICourse> CoursesGiven { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public Teacher()
        {
            CoursesGiven = new List<ICourse>();
        }


        public void AssignCourse(ICourse course)
        {
            CoursesGiven.Add(course);
            Console.WriteLine($"{FullName()} adlı öğretmene {course.Name} dersi atandı.");
        }

        public int CalculateAge()
        {
            TimeSpan difference = DateTime.Now - Birthdate;
            return (int)(difference.TotalDays / 365.25);
        }

        public string FullName()
        {
            return $"{Name} {Surname}";
        }

        public void ListCoursesGiven()
        {
            Console.WriteLine($"{FullName()} adlı öğretmenin verdiği dersler:");
            foreach (var course in CoursesGiven)
            {
                Console.WriteLine($"- {course.Name}");
            }
        }
    }
}
