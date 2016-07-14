using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller_App
{
    class Program
    {
        //This is the "main menu"... what I want the user to go through before their fortune is output
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your birth month?");
            string birthMonth = Console.ReadLine();


            Console.WriteLine("Please enter your favorite ROYGBIV color. If you do not know what ROYGBIV is, please enter help");
            string favoriteColor = Console.ReadLine();
            string[] ROYGBIV = { "red", "orange", "green", "blue", "indigo", "violet" };

            if (favoriteColor == "help")

            {
                foreach (string item in ROYGBIV)
                {
                    Console.WriteLine(item);

                }

                Console.WriteLine("Please enter your favorite of these colors");
                favoriteColor = Console.ReadLine();
            }


            Console.WriteLine("Please enter the number of siblings you have");
            int siblings = Convert.ToInt32(Console.ReadLine());

        
        
        
            // this method determines the age at which the user will retire
            if (userAge % 2 == 1)

            {
                Console.WriteLine( firstName + lastName + "will retire in 10 years");
            }

            else if (userAge % 2 != 1)
            {
                Console.WriteLine( firstName + lastName + "will retire in 25 years");
            }

        
           // this method determines the location of the user's vacation home
           if (siblings == 0)
                {
                    Console.WriteLine("with a vacation home in Hawaii"); 
                }
           else if (siblings == 1)
                {
                    Console.WriteLine("With a vacation home on a private tropical island");
                
                }
           else if (siblings == 2)
                {
                    Console.WriteLine("with a vacation home in Arizona"); 
              
                }
           else if (siblings == 3)
                {
                    Console.WriteLine("with a vacation home in Italy");
                }
           else if (siblings > 3)
                {
                    Console.WriteLine("with a vacation home in Montana");
                }


           // this method determines the user's mode of transportation 
            if (favoriteColor == "red")
            {
                Console.WriteLine(",a boat");
            }
            else if (favoriteColor == "orange")
            {
                Console.WriteLine(", a ferrari");
            }
            else if (favoriteColor == "yellow")
            {
                Console.WriteLine(", a private jet");
            }
            else if (favoriteColor == "green")
            {
                Console.WriteLine(", a bicycle");
            }
            else if (favoriteColor == "blue")
            {
                Console.WriteLine(", a bugati");
            }
            else if (favoriteColor == "indigo") 
            {
                Console.WriteLine(", a mule");
            }    
            else if (favoriteColor == "violet")
            {
                Console.WriteLine(", a yacht");
            }

            // this method determines the amount of money the user will have in the bank
            
        }       

     }

           
  }


   



