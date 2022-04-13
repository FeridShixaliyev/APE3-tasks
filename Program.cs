using System;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            int exp;
            bool check = true;
                Console.WriteLine("Mellimin tecrube puanini daxil edin:");
            do
            {
                exp = Convert.ToInt32(Console.ReadLine());
                if (exp > 0 && exp <= 80)
                    check = false;
                else
                    Console.WriteLine("Tecrube puani 0-80 araliginda olmalidi!!");
            } while (check);

            Teacher teacher = new Teacher("Gulnar","Aliyev",32,exp);
            teacher.ShowInfo();

            //Student student = new Student();
        }
    }
}
