using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Models
{
    public class Helper
    {
        public static bool CheckName(string name)
        {
            return !string.IsNullOrEmpty(name) && name.Length >= 3 && char.IsUpper(name[0]) ;
        }
        public static bool CheckSurname(string surname)
        {
            return CheckName(surname);
        }
        public static bool CheckClassroomname(string classroomname) 
        {
            return  classroomname.Length == 3 && char.IsUpper(classroomname[0]) && char.IsUpper(classroomname[1]) && char.IsDigit(classroomname[2]);
        }
    }
}
