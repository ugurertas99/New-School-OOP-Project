using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    // Ders Sınıfı (IDers arayüzünü uyguluyor)
    public class Course : ICourse
    {
        public string Code { get; set; }
        public int Credit { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci nesnesi oluşturma
            Student stdnt1 = new Student
            {
                Id = 1,
                Name = "Ayşe",
                Surname = "Yılmaz",
                StudentNo = "202310101",
                Birthdate = new DateTime(2005, 5, 15)
            };

            Student stdnt2 = new Student
            {
                Id = 2,
                Name = "Ali",
                Surname = "Demir",
                StudentNo = "202310102",
                Birthdate = new DateTime(2004, 12, 20)
            };

            // Öğretmen nesnesi oluşturma
           Teacher tch1 = new Teacher
            {
                Id = 101,
                Name = "Mehmet",
                Surname = "Öztürk",
                Subject= "Matematik",
                Birthdate = new DateTime(1980, 8, 2)
            };

            Teacher tch2 = new Teacher
            {
                Id = 102,
                Name = "Zeynep",
                Surname = "Kara",
                Subject = "Türkçe",
               Birthdate = new DateTime(1985, 3, 10)
            };

            // Ders nesneleri oluşturma
           Course matematikDersi = new Course { Id = 1, Name = "Matematik", Code = "MAT101", Credit = 4 };
           Course turkceDersi = new Course { Id = 2, Name = "Türkçe", Code = "TUR101", Credit = 3 };
            Course fizikDersi = new Course { Id = 3, Name = "Fizik", Code = "FZK101", Credit = 4 };

            // Öğrencilere ders ekleme
            stdnt1.AddCourse(matematikDersi);
            stdnt2.AddCourse(turkceDersi);
            stdnt2.AddCourse(fizikDersi);

            // Öğretmenlere ders atama
            tch1.AssignCourse(matematikDersi);
            tch1.AssignCourse(fizikDersi);
            tch2.AssignCourse(turkceDersi);

            // Öğrencilerin aldığı dersleri listeleme
            Console.WriteLine("\nÖğrenci Ders Listeleri:");
            stdnt1.ListCourses();
            stdnt2.ListCourses();

            // Öğretmenlerin verdiği dersleri listeleme
            Console.WriteLine("\nÖğretmen Ders Listeleri:");
            tch1.ListCoursesGiven();
            tch2.ListCoursesGiven();

            // Öğrenci ve öğretmenlerin tam adlarını ve yaşlarını yazdırma
            Console.WriteLine("\nKişi Bilgileri:");
            Console.WriteLine($"{stdnt1.FullName()} - Age: {stdnt1.CalculateAge()}");
            Console.WriteLine($"{stdnt2.FullName()} - Age: {stdnt2.CalculateAge()}");
            Console.WriteLine($"{tch1.FullName()} - Age: {tch1.CalculateAge()} - Subject: {tch1.Subject}");
            Console.WriteLine($"{tch2.FullName()} - Age: {tch2.CalculateAge()} - Subject: {tch2.Subject}");
        }
    }
}



