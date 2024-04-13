using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
   public   class Classroom
    {

        public int Id { get; set; }
       
        public string Name { get; set; }
 

        public  Classnum Type;
        private Student[] Students=new  Student[0];
        public int No;
      
       

        public Classroom(int id,string name, Classnum type)
        {
            Id = id;
            Name = name;
            Type= type;
            
        }

      

        public void Addstudent(Student student)
        {
            if (Students.Length >= (Type == Classnum.Backend ? 20 : 15))
            {
                throw new InvalidOperationException("Classroom doludur");
            }

            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }


        public Student FindStudentById(int id)
        {
            foreach (var student in Students)
            {
                if (student.Id == id)
                {
                    student.Showinfo();
                }
            }
            return null;
        }


        public void Deletestudentbyid(int id)
        {
            try
            {
                int index = -1;
                for (int i = 0; i < Students.Length; i++)
                {
                    if (Students[i].Id == id)
                    {
                        index = i;
                        break;
                    }
                }

                if (index != -1)
                {
                    Array.Copy(Students, index + 1, Students, index, Students.Length - index - 1);
                    Array.Resize(ref Students, Students.Length - 1);
                    
                }
                else
                {
                    throw new StudentNotFoundException("Student tapilmadi!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Allstudents()
        {
            foreach (var pt in Students)
            {
                pt.Showinfo();
            }
        }








    }
}
