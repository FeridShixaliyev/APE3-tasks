using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp46
{
    class Student
    {
        public Student(string fullname,int age)
        {
            _id++;
            Id = _id;
            FullName = fullname;
            Age = age;
        }
        private static int _id;
        private int _age;
        public string FullName { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if (value > 0 && value < 150)
                    _age = value;
            }
        }
        public int Id { get; }
        
    }
}
