using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeesByName = new SortedList<string, List<Employee>>();

            employeesByName.Add("Sales", new List<Employee> { new Employee(), new Employee(), new Employee() });
            employeesByName.Add("Engineering", new List<Employee> { new Employee(), new Employee() });

            foreach (var item in employeesByName)
            {
                Console.WriteLine("The count of employees for {0} is {1}",
                            item.Key, item.Value.Count
                        );
                Console.ReadLine();
            }
        }
    }
}
