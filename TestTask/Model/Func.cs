using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Func
    {
        public static int CountEmployees(Model.Subdivision subdivisions)
        {
            int totalEmployees = 0;
            Console.WriteLine("\n-------------");
            Console.WriteLine(subdivisions.Name);
            totalEmployees += subdivisions.Users?.Count ?? 0;
            Console.WriteLine(totalEmployees);
            if (subdivisions.Subdivisions?.Any() == true)
            {
                
            
                foreach (var sub in subdivisions.Subdivisions)
                {
                    totalEmployees += sub.Users?.Count ?? 0;
                    if (sub.Subdivisions?.Any() == true)
                    {
                        totalEmployees += CountEmployees(sub);
                        Console.WriteLine("Счет"+CountEmployees(sub));
                    }
                }
            }
            Console.WriteLine(totalEmployees);
            Console.WriteLine("\n-------------");

            return totalEmployees;
        }
        
    }
}
