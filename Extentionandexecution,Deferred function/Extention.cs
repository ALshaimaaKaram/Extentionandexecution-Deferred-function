using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentionandexecution_Deferred_function
{
    static class Extention
    {
        public static int Reverse(this int num)
        {
            int numR = 0;
            while (num > 0)
            {
                int rem = num % 10;
                numR = (numR * 10) + rem;
                num = num / 10;
            }

            return numR;
        }

        public static IEnumerable<Employee> Filter(this List<Employee> emp ,Predicate<int> predicate)
        {
            List<Employee> employees = new List<Employee>();

            foreach (Employee em in emp)
            {
                if (predicate(em.ID))
                    employees.Add(em);
            }

            return employees;
        }

        public static IEnumerable<Employee> FilterDeferred (this List<Employee> emp, Predicate<int> predicate)
        {
            List<Employee> employees = new List<Employee>();

            foreach (Employee em in emp)
            {
                if (predicate(em.ID))
                    employees.Add(em);
            }

            foreach (Employee employee in employees)
            {
                yield return employee;
            }
        }
    }
}
