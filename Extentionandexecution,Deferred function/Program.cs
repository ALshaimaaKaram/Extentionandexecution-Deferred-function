using System;
using System.Collections.Generic;

namespace Extentionandexecution_Deferred_function
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Extention Function
            int num = 526;
            Console.WriteLine("The Number Reverse is " + num.Reverse());
            #endregion

            #region Eager execution / Deferred execution
            List<Employee> emps = new List<Employee>
            {
                new Employee { ID = 1, Name = "Ali" },
                new Employee { ID = 2, Name = "Hosam" }
            };


            Console.WriteLine("Eager execution");
            List<Employee> newList = (List<Employee>)emps.Filter(e => e > 1);

            foreach (Employee emp in newList)
            {
                Console.WriteLine(emp);
            }



            //Deferred execution
            Console.WriteLine("Deferred execution");
            IEnumerable<Employee> newList2 = emps.FilterDeferred(e => e > 1);
            foreach (var emp in newList2)
            {
                Console.WriteLine(emp);
            }

            #endregion
        }
    }
}
