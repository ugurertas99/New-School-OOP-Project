using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    // Kişi Arayüzü (IVarlik'tan kalıtım alıyor)
    public interface IPerson:IEntity
    {
        string Surname { get; set; }
        DateTime Birthdate { get; set; }
        string FullName();
        int CalculateAge();
    }
}
