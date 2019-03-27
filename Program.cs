using System;

/**
*   Program takes the current meter reading(CMR) and previous meter reading(PMR) 
*   It checks the connection type and displays the bill
*   CMR - PMR = num units consumed in this month
* */

namespace Meter_Reading
{
    class Program
    {
        static void Main(string[] args)
        {
            int calcBill = 0;

            Console.WriteLine("********************************     Welcome     ******************************** \n");

            do
            {
                int cmr = 0, pmr = 0;
                int conType = 0;
                double billAmt = 0;
                int units = 0;
                
                Console.WriteLine("Please enter the Previous Meter Reading: ");
                pmr = int.Parse(Console.ReadLine());
                Console.WriteLine("The PMR you have entered is: {0}", pmr);
                Console.WriteLine("\n");

                Console.WriteLine("Please enter the Current Meter Reading: ");
                cmr = int.Parse(Console.ReadLine());
                Console.WriteLine("The CMR you have entered is: {0}", cmr);
                Console.WriteLine("\n");

                Console.WriteLine("Please indicate your type of connection: \n");
                S: Console.WriteLine("1. Domestic Consumer | 2. Non-domestic/Commercial");
                conType = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                units = cmr - pmr;
                
                switch (conType)
                {
                    case 1:
                        Console.WriteLine("========================Domestic Consumer========================");

                        if (units >= 0)
                        {
                            billAmt = units * 5;
                        }
                        else if (units >= 201)
                        {
                            billAmt = units * 7.20;
                        }
                        else if (units >= 301)
                        {
                            billAmt = units * 8.50;
                        }
                        else if (units >= 401)
                        {
                            billAmt = units * 9;
                        }
                        else if (units > 800)
                        {
                            billAmt = units * 9.50;
                        }
                        else
                        {
                            units = units * -1;
                            //goto S;
                        }

                        Console.WriteLine("The bill you owing is R{0}, please send payments to your nearest municipality\n", billAmt);

                        break;
                    case 2:
                        Console.WriteLine("=====================Non-domestic/Commercial=====================");
                        if (units >= 0)
                        {
                            billAmt = units * 7.50;
                        }
                        else if (units >= 101)
                        {
                            billAmt = units * 8.90;
                        }
                        else if (units >= 301)
                        {
                            billAmt = units * 9.40;
                        }
                        else if (units > 500)
                        {
                            billAmt = units * 10;
                        }
                        else
                        {
                            units = units * -1;
                            //goto S;
                        }

                        Console.WriteLine("The bill you owing is R{0}, please send payments to your nearest municipality\n", billAmt);

                        break;
                    default:
                        Console.WriteLine("Invalid Option! Please choose 1 for Domestic Consumer or 2 for Non-domestic/Commercial \n");
                        goto S;
                        //break;
                }

                Console.WriteLine("Please press 1 if you would like to calculate another bill.");
                calcBill = int.Parse(Console.ReadLine());

            } while (calcBill == 1);
            Console.WriteLine("Thank you for using the Bill Calculator!");

        }
    }
}
