using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class Pizza
    {
        private string size;
        private int cheeseToppings;
        private int pepperoniToppings;
        private int hamToppings;

        // Constructor
        public Pizza(string size, int cheeseToppings, int pepperoniToppings, int hamToppings)
        {
            this.size = size;
            this.cheeseToppings = cheeseToppings;
            this.pepperoniToppings = pepperoniToppings;
            this.hamToppings = hamToppings;
        }

        // Properties using get and set methods
        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public int CheeseToppings
        {
            get { return cheeseToppings; }
            set { cheeseToppings = value; }
        }

        public int PepperoniToppings
        {
            get { return pepperoniToppings; }
            set { pepperoniToppings = value; }
        }

        public int HamToppings
        {
            get { return hamToppings; }
            set { hamToppings = value; }
        }

        // Method to calculate the cost of the pizza
        public double CalcCost()
        {
            double cost = 0;

            switch (size.ToLower())
            {
                case "small":
                    cost = 10 + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
                    break;
                case "medium":
                    cost = 12 + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
                    break;
                case "large":
                    cost = 14 + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
                    break;
                default:
                    Console.WriteLine("Invalid size");
                    break;
            }

            return cost;
        }

        // Method to get the description of the pizza
        public string GetDescription()
        {
            return $"{size} pizza with {cheeseToppings} cheese toppings, {pepperoniToppings} pepperoni toppings, and {hamToppings} ham toppings.";
        }
    }

}








