using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp47
{
    class Student:Person
    {
        public Student(string name, string surname, int age):base(name, surname, age)
        {
                
        }
        private static int _id;
        public int Id { get; }
        public string[] Lessons;

        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {Name} {Surname}\nAge: {Age}");
        }
    }
}
