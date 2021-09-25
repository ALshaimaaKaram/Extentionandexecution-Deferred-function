using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentionandexecution_Deferred_function
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        

        public override string ToString()
        {
            return $"The ID is {ID}, The Name is {Name}";
        }
    }
}
