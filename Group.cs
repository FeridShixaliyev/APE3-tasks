using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp46
{
    class Group
    {
        public int GroupNo { get; set; }
        
        public Student[] students = new Student[0];
        
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
    }
}
