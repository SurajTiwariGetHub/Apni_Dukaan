using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Apni_Dukaan
{
    public class Program
    {
        public class Store
        {

        }
        public class Category : Store
        {

        }
        public class Vegetable : Category
        {
            public string[] v = { "Fresh Potato", "Fresh Tomato", "Fresh Cucumber", "LadyFinger", "Pumpkin" };

            public void PrintNumbers()
            {
                
               
                for (int i = 0; i < v.Length; i++)
                {
                    Console.WriteLine(i+1 +". "+ v[i]);
                }
                    Console.WriteLine("Put the Number of vegetable do want to buy!");
                    int store = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine($"{v[store -1]}:Added In Your Cart");
                }
             
            }
        public class Fruit : Category
        {
            public string[] v = { "Fresh Mango", "Fresh Banana", "Fresh Graphes", "Orange", "Papaya" };

            public void PrintNumbers()
            {
             

                for (int i = 0; i < v.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + v[i]);
                }
                Console.WriteLine("Put the Number of fruit do want to buy!");
                int store = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{v[store - 1]}:Added In Your Cart");

            }
        }
        public class Grocery : Category
        {
            public string[] v = { "Sugar", "Rice", "Gram", "Flour", "Spices" };

            public void PrintNumbers()
            {
                

                for (int i = 0; i < v.Length; i++)
                {
                    Console.WriteLine(i + 1 + ". " + v[i]);

                }
                Console.WriteLine("Put the Number of grocery do want to buy!");
                int store = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{v[store - 1]}:Added In Your Cart");
            }

        }

        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Welcome To Apni_Dukaan Stroe \n We Are Serving Different Type Of Items Like \n 1.Fruit \n 2.Vegetable \n 3.Grocery");
                string choice = Convert.ToString(Console.ReadLine());

                Vegetable veg = new Vegetable();
                Fruit fru = new Fruit();
                Grocery gro = new Grocery();


                if (choice == "2")
                {

                    Console.WriteLine("Currently Available Item Are:");
                    veg.PrintNumbers();
                }
                else if (choice == "1")
                {

                    Console.WriteLine("Currently Available Item Are:");
                    fru.PrintNumbers();
                }
                else if (choice == "3")
                {

                    Console.WriteLine("Currently Available Item Are:");
                    gro.PrintNumbers();
                }
                Console.WriteLine("Do You Want To See More ITem!? If Want Then Press Yes!");

            } while (Console.ReadLine().ToLower() == "yes");
        }
    }
}
    

