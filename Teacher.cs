using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp47
{
    class Teacher:Person
    {
        public Teacher(string name,string surname,int age,int exp):base(name,surname,age)
        {
            _id++;
            Id = _id;
            Experience = exp;
        }
        private static int _id;
        private int _experience;
        public int Id { get; }
        public int Experience
        {
            get => _experience;
            set
            {
                if (value > 0 && value <= 80)
                    _experience = value;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Fullname: {Name} {Surname}\nAge: {Age}\nExperience: {Experience}");
        }

    }
}
