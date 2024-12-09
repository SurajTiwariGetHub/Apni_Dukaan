using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Threading;


namespace Apni_Dukaan
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Program.Vegetable vegetable = new Program.Vegetable();
            Program.Fruit fruit = new Program.Fruit();
            Program.Grocery grocery = new Program.Grocery();
            Program.Store cart = new Program.Store();
            do
            {
                Console.WriteLine("Welcome To Apni_Dukaan Store. We Offer Different Categories:");
                Console.WriteLine("1. Fruit \n2. Vegetable \n3. Grocery");
                switch (Console.ReadLine())
                {
                    case "2":
                        Console.WriteLine("Currently Available Vegetables:");
                        vegetable.PrintNumbers();
                        vegetable.CartValue(cart);
                        break;
                    case "1":
                        Console.WriteLine("Currently Available Fruits:");
                        fruit.PrintNumbers();
                        fruit.CartValue(cart);
                        break;
                    case "3":
                        Console.WriteLine("Currently Available Groceries:");
                        grocery.PrintNumbers();
                        grocery.CartValue(cart);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please select a valid option.");
                        break;
                }
                Console.WriteLine("Do You Want To Add More Items? (Yes/No)");
            }
            while (Console.ReadLine().ToLower() == "yes");
            Console.WriteLine("\nItems in your Cart:");
            foreach (string str in cart.InCart)
                Console.WriteLine(str);
            string str1 = "C:\\FileStream\\Invoice.txt";
            using (FileStream fileStream = new FileStream(str1, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter((Stream)fileStream))
                {
                    streamWriter.WriteLine("Welcome To Apki_Dukan");
                    streamWriter.WriteLine("---------------------------------");
                    int num = 0;
                    foreach (string str2 in cart.InCart)
                    {
                        streamWriter.WriteLine(str2);
                        int startIndex = str2.IndexOf('₹') + 1;
                        int int32 = Convert.ToInt32(str2.Substring(startIndex));
                        num += int32;
                    }
                    streamWriter.WriteLine("------");
                    streamWriter.WriteLine(string.Format("Total Billing Amount Is :{0}", (object)num));
                }
            }
            Console.WriteLine("Invoie is generating. Plz wait...........");
            Thread.Sleep(1000);
            Process.Start(new ProcessStartInfo(str1)
            {
                UseShellExecute = true
            });
            Console.WriteLine("\nThank you for shopping with us! Have a great day...");
        }

        public class Store
        {
            public ArrayList InCart = new ArrayList();
        }

        public class Category
        {
        }

        public class Vegetable : Program.Category
        {
            public string[] v = new string[5]
            {
        "Fresh Potato : ₹25",
        "Fresh Tomato : ₹45",
        "Fresh Cucumber : ₹35",
        "LadyFinger : ₹30",
        "Pumpkin : ₹50"
            };

            public void PrintNumbers()
            {
                for (int index = 0; index < this.v.Length; ++index)
                    Console.WriteLine((index + 1).ToString() + ". " + this.v[index]);
                Console.WriteLine("Enter the Number of the vegetable you want to buy!");
            }

            public void CartValue(Program.Store cart)
            {
                int int32 = Convert.ToInt32(Console.ReadLine());
                if (int32 >= 1 && int32 <= this.v.Length)
                {
                    Console.WriteLine(this.v[int32 - 1] + ": Added To Your Cart");
                    cart.InCart.Add((object)this.v[int32 - 1]);
                }
                else
                    Console.WriteLine("Invalid choice, please select a valid vegetable number.");
            }
        }

        public class Fruit : Program.Category
        {
            public string[] v = new string[5]
            {
        "Fresh Mango : ₹150",
        "Fresh Banana : ₹80",
        "Fresh Grapes : ₹60",
        "Orange : ₹40",
        "Papaya : ₹60"
            };

            public void PrintNumbers()
            {
                for (int index = 0; index < this.v.Length; ++index)
                    Console.WriteLine((index + 1).ToString() + ". " + this.v[index]);
                Console.WriteLine("Enter the Number of the fruit you want to buy!");
            }

            public void CartValue(Program.Store cart)
            {
                int int32 = Convert.ToInt32(Console.ReadLine());
                if (int32 >= 1 && int32 <= this.v.Length)
                {
                    Console.WriteLine(this.v[int32 - 1] + ": Added To Your Cart");
                    cart.InCart.Add((object)this.v[int32 - 1]);
                }
                else
                    Console.WriteLine("Invalid choice, please select a valid fruit number.");
            }
        }

        public class Grocery : Program.Category
        {
            public string[] v = new string[5]
            {
        "Sugar : ₹76",
        "Rice : ₹85",
        "Gram : ₹115",
        "Flour : ₹48",
        "Spices : ₹87"
            };

            public void PrintNumbers()
            {
                for (int index = 0; index < this.v.Length; ++index)
                    Console.WriteLine((index + 1).ToString() + ". " + this.v[index]);
                Console.WriteLine("Enter the Number of the grocery item you want to buy!");
            }

            public void CartValue(Program.Store cart)
            {
                int int32 = Convert.ToInt32(Console.ReadLine());
                if (int32 >= 1 && int32 <= this.v.Length)
                {
                    Console.WriteLine(this.v[int32 - 1] + ": Added To Your Cart");
                    cart.InCart.Add((object)this.v[int32 - 1]);
                }
                else
                    Console.WriteLine("Invalid choice, please select a valid grocery item number.");
            }
        }
    }
}

