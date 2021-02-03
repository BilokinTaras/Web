using System;
using System.Linq;
using System.Collections.Generic;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список студентів та їхня оплата за навчання");
            Student stud1 = new Student("Sergiy", 21, 1, 34);
            Console.WriteLine(stud1);
            payment study1 = new payment(10000);
            study1.RegisterHandler(new payment.AccountStateHandler(Show_Message));
            study1.Withdraw(10000);
            Student stud2 = new Student("Nastya", 19, 2, 54);
            Console.WriteLine(stud2);
            payment study2 = new payment(9999);
            study2.RegisterHandler(new payment.AccountStateHandler(Show_Message));
            study2.Withdraw(10000);
            Console.WriteLine("Список кафедр ");
             List<cathedra> Newcathedra = new List<cathedra>(2);
             Newcathedra.Add(new cathedra() { Id = 1, Name = "IT", Floor = 2, Audience = 223});
             Newcathedra.Add(new cathedra() { Id = 2, Name = "Biology", Floor = 3, Audience = 341 });
             Newcathedra.Add(new cathedra() { Id = 2, Name = "Physical", Floor = 4, Audience = 489 });
             Newcathedra.Add(new cathedra() { Id = 2, Name = "Geographical", Floor = 3, Audience = 389 });
            foreach (cathedra i in Newcathedra)
            {
                Console.WriteLine(i);
            }
                Console.ReadKey();
        }
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }
    }
}

