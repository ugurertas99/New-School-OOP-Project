using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_OOP
{
    // Ders Arayüzü (IVarlik'tan kalıtım alıyor)
    public interface ICourse:IEntity
    {
        string Code { get; set; }
        int Credit { get; set; }
    }
}
