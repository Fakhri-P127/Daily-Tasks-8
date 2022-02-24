using System;

namespace Daily_Tasks_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullname;
            string groupno;
           
            do
            {
                Console.Write("Fullname: ");
                fullname = Console.ReadLine();
            } while (!Student.CheckFullname(fullname));

            do
            {
                Console.Write("GroupNo: ");
                groupno = Console.ReadLine();
            } while (!Student.CheckGroupNo(groupno));

            Console.Write("Age: ");
            byte age = Convert.ToByte(Console.ReadLine());
            Student student = new Student(fullname, groupno, age);
            Console.WriteLine($"Fullname: {student.Fullname}\nGroupNo: {student.GroupNo}\nAge: {student.Age}");                        
        }
    }
}
