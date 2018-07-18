using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3_071718
{
    class Program
    {
        static void Main(string[] args)
        {
            string Continue = "y";
             
             

                Console.WriteLine("Greetings!! What is your name?");
                string nameUsed = Console.ReadLine();
            while(Continue == "y"){
                Console.WriteLine($"Ok {nameUsed}, Please enter a whole number between 1 and 100.");
                string numChose = Console.ReadLine();

                int wholeNum = int.Parse(numChose);


                if (wholeNum % 2 == 0)

                {
                    if (wholeNum >= 2 && wholeNum <= 25)
                    {
                        Console.WriteLine($"Thanks {nameUsed}!! You entered {numChose} and it's even and less than 25.");
                        Console.ReadLine();
                    }

                    else if (wholeNum >= 25)
                    {
                        Console.WriteLine($"Thanks {nameUsed}!! You entered {numChose}");
                        Console.ReadLine();
                    }
                }

                else

                    Console.WriteLine($"Thanks {nameUsed}!! You entered {numChose} and it's odd");
                Console.ReadLine();
                Console.WriteLine($"Would you like to continue {nameUsed}?");
                
                Continue = Console.ReadLine();
                Continue = Continue.ToLower();

                if (Continue != "y")
                Console.WriteLine($"Bye {nameUsed}!!");
                Console.ReadLine();




            }
                    
        }
    }
}
