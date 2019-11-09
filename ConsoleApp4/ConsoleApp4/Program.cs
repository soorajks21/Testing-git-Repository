using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {


        static void Main(string[] args)
        {

            List<Employee> list = new List<Employee>()
            {
                new Employee{ Name="sooraj", Id=1, experience = 6 },
                new Employee { Name= "jerald", Id= 2 , experience = 8}
            };

            //            Ispromotable ispromotable = new Ispromotable(IsEligible);

            Employee.hike(list, emp => emp.experience > 5);
            Console.ReadLine();
        }



        //public static bool IsEligible(Employee employees)
        //{

        //    if (employees.experience > 5)
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }



    delegate bool Ispromotable(Employee emp);

    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int experience { get; set; }


        public static void hike(List<Employee> employees, Ispromotable ispromotable)
        {

            foreach (var emp in employees)
            {
                if (ispromotable(emp))
                {
                    Console.WriteLine(emp.Name);
                }
            }
        }
    }
}


