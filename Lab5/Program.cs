using System;

namespace Lab5
{
    class Program
    {
        static void Main()
        {
            do
            {
                //prompt for num 1 - 10
                Console.Write("Enter a number between 1 and 20: ");
                string userInput = Console.ReadLine();

                //call data validation method
                long userNum = Validate(userInput);

                //call factorial calculation method
                long fac = FactorialCalc(userNum);

                //write factorial var answer
                Console.WriteLine(fac);
            }
            //call continue method
            while (Continue() == 1);
        }

        //data validation method
        static long Validate(string un)
        {
            long num = 0;
            //check for number
            if (!long.TryParse(un, out num))
            {
                Console.WriteLine("Please enter a number.");
                num = 0;
            }
            //check for 1-10
            else if (num > 20 || num < 1)
            {
                Console.WriteLine("Please enter a number in the given range.");
                num = 0;
            }
            else if(long.TryParse(un, out num))
            {
                num = long.Parse(un);
            }
            return num;
        }

        //factorial calculaiton method return long
        static long FactorialCalc(long num)
        {
            long hold = num;
            //if the number is 1, manually return 1
            if (num <= 1)
            {
                return 1;
            }
            //return the number times 
            return num * FactorialCalc(num - 1);
        }

        //continue method
        static int Continue()
        {
            string response;
            int situ = 3;
            while(situ == 3)
            {
                Console.WriteLine("Continue? (y/n): ");
                response = Console.ReadLine().ToLower();

                if (response == "y" || response == "yes")
                {
                    //if yes, restart at main
                    situ = 1;
                }
                else if (response == "n" || response == "no")
                {
                    //if no, exit
                    situ = 0;
                }
                else if (response != "n" || response != "no" || response != "y" || response != "yes")
                {
                    situ = 3;
                }

                if (situ == 3)
                {
                    Console.WriteLine("Please enter valid response.");
                }
            }
            return situ;
        }
    }
}
