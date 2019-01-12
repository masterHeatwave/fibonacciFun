using System;
using static System.Console;

namespace fibonacciSeq
{
    class fProgram

    {

        static int p1 = 0, p2 = 1, p3; //declaring Fibonacci int values 



        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the Fibonacci Con - C - QUEnce Game!!!");


            System.Threading.Thread.Sleep(2000); // pausing the system


            Console.WriteLine("Would you like to play a round???");


            string answer = Console.ReadLine(); // taking input from the user 


            System.Threading.Thread.Sleep(2000);


            if (answer == "yes") // checking user's input 

            {

                Console.WriteLine("Ok... So please provide an initial numerical value:");


                int count = Int32.Parse(Console.ReadLine()); 


                System.Threading.Thread.Sleep(2000);


                Console.WriteLine("Ok...so in this case the Fibonacci numbers would be...");


                System.Threading.Thread.Sleep(2000);


                Console.Write(p1 + " " + p2);  // adding user's input to the sequence


                for (int i = 2; i < count; i++)


                {
                    p3 = p1 + p2;

                    Console.Write(" " + p3);

                    p1 = p2;

                    p2 = p3;
                }

                // creating Fibonacci Sequence array by adding the initial number to the next one


                Console.WriteLine(" \n Thanks for using Fibonacci's Magic!...");




            }


            else

            {

                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("Aaaallrighty... bye bye then!...");

                // Closes the current process
                Environment.Exit(0);


            }
		

		}
          
	}

}
