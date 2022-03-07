using System;

namespace Assignment1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int option;

            Create_Student c = new Create_Student();

            do
            {
                Console.WriteLine("1.Press 1 for Creating a New Student Account.");
                Console.WriteLine("2.Press 2 for Entering the Marks.");
                Console.WriteLine("3.Press 3 for Display Marks.");
                Console.WriteLine("4.Press 4 for RankList.");
                Console.WriteLine("5.Press 5 for exit.");
                Console.WriteLine("select an option please.");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        c.Create_Student_Account();

                        break;
                    case 2:
                        c.Enter_Marks();
                        break;
                    case 3:
                        c.Display();
                        break;
                    case 4:
                        c.RankList();
                        break;
                    case 5:
                        return;
                }
            } while (option != 6);
        }

    }
    }



