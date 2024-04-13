using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public  class Student
    {
        private static int id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int No { get; internal set; }

        public Student( string name, string surname) 
        { 
            Id =++id;
            Name = name;
            Surname = surname;

        }
        public void Showinfo()
        {
            Console.WriteLine($"ID: {Id}, Ad: {Name}, Soyad: {Surname}");
        }
    }
}
