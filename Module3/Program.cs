
 using System;

 using System.Collections.Generic;


namespace Module3
{

        class Program
        {

            static void Main(string[] args)
            {
                Shop shop = new Shop();

                do
                {
                    Console.WriteLine("Please,select from the list: ");

                    Console.WriteLine("T-Short - (enter 1)");
                    Console.WriteLine("Jeans - (enter 2)");
                    Console.WriteLine("Jacken - (enter 3");

                    var choice = Console.ReadLine();
                    BaseClothes baseClothes = null;
                    if (choice == "1")
                    {
                        baseClothes = new BaseClothes("T-Short", 20);
                    }
                    else if (choice == "2")
                    {
                        baseClothes = new BaseClothes("Jeans", 10);
                    }
                    else if (choice == "3")
                    {
                        baseClothes = new BaseClothes("Jacken", 10);
                    }
                    else
                    {
                        throw new ArgumentException();
                    }

                    Console.WriteLine("Entre name:");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter price:");
                    double Price = Convert.ToDouble(Console.ReadLine());

                    var clothes = new Clothes(Name, Price, baseClothes);
                    shop.clothes.Add(clothes);

                    Console.WriteLine("Added: {0}", clothes.Name);

                    Console.WriteLine("Do you want to continue shoping?");
                    Console.WriteLine("YES or NO");
                    var c = Console.ReadLine();
                    if (c == "YES")
                    {
                        continue;
                    }
                    else if (c == "NO")
                    {
                        break;
                    }


                } while (true);



            }
        }
    }