using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    // Öğretmen Arayüzü (IKisi'den kalıtım alıyor)
    public interface ITeacher:IPerson
    {
        string Subject { get; set; }
        List<ICourse> CoursesGiven { get; set; }
        void AssignCourse (ICourse course);
        void ListCoursesGiven();
    }
}
