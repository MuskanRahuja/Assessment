using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Pizza pizza1 = new Pizza("medium", 2, 1, 1);
            Pizza pizza2 = new Pizza("large", 3, 2, 0);

            Console.WriteLine("Pizza 1: " + pizza1.GetDescription());
            Console.WriteLine("Cost of Pizza 1: $" + pizza1.CalcCost());

            Console.WriteLine("\nPizza 2: " + pizza2.GetDescription());
            Console.WriteLine("Cost of Pizza 2: $" + pizza2.CalcCost());
        }
    }

}

