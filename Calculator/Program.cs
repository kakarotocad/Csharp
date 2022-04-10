using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            run();
        }

        static void run()
        {
            int option;
            double v1, v2;

            do
            {
                option = Menu();

                if (option >= 1 && option <= 4)
                {
                    Console.WriteLine("Please Inform the first Value: ");
                    v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please Inform the Second Value: ");
                    v2 = double.Parse(Console.ReadLine());

                    Console.WriteLine($"O resultado da operação é: {Operation(v1, v2, option)}");
                }
                else System.Environment.Exit(0);



            } while (option != 5);
        }

        static int Menu()
        {
    

            Console.WriteLine("====== Calculator Menu ======");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - EXIT");
            Console.WriteLine("Please Inform the operation: ");
            var option = int.Parse(Console.ReadLine());
            return option;
        }

        static double Operation(double v1, double v2, int op)
        {
            switch(op){
                case 1: return v1 + v2;break;
                case 2: return v1 - v2;break;
                case 3: return v1 / v2; break;
                case 4: return v1 * v2; break;
                default: return 0; break;
            }
        }
    }



}

