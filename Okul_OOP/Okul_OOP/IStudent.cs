using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    // Öğrenci Arayüzü (IKisi'den kalıtım alıyor)
    public interface IStudent:IPerson
    {
        string StudentNo { get; set; }
        List<ICourse> CoursesTaken { get; set; }
        void AddCourse (ICourse course);
        void ListCourses();
    }
}
