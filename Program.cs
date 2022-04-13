using System;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group();
            Student student = new Student("Ferid Sixaliyev", 21);
            group.AddStudent(student);
            foreach (Student item in group.students)
            {
                Console.WriteLine($"Fullname: {item.FullName}\nAge: {item.Age}\nId: {item.Id}");
            }
        }
    }
}
