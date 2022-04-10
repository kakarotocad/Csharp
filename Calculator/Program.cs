using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the function run() that start the program
            run();
        }

        //This function keep the user in the loop and call the other functions to execute the program
        static void run()
        {
            
            int option; //Store the option selected by the user
            double v1, v2; //Store the values that is going to be used by the program

            do
            {
                //CAll the function menu() and storage the option selected by the user
                option = Menu();

                //Check if the option selected is valid to collect the values to run the Operation function
                if (option >= 1 && option <= 4)
                {
                    Console.WriteLine("Please Inform the first Value: ");
                    v1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please Inform the Second Value: ");
                    v2 = double.Parse(Console.ReadLine());

                    //Write the result in the Console calling the function Operation()
                    Console.WriteLine($"O resultado da operação é: {Operation(v1, v2, option)}");
                }
                //In case of the function is not equal a valid function terminate the program
                else System.Environment.Exit(0);

            //Loop condition 
            } while (option != 5);
        }

        //Function that construct a menu in the screen
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

        //Function that run the calculation and return the result
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

