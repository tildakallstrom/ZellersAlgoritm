using System;

using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {

    
                        Console.WriteLine("Enter birthday (YYYY/MM/DD):");


                var birthday = Console.ReadLine();
            DateTime dt;


            // Check the date format
            if (DateTime.TryParse(birthday, out dt))
            {

                string[] Y = birthday.Split('/');

                string year = Y[0];
                int d = int.Parse(Y[2]);
                int m = int.Parse(Y[1]);
                int y = int.Parse(year.Substring(2, 2));
                int c = int.Parse(year.Substring(0, 2));



                if (m < 3) { m += 12; y--; }

                var numberofweek = (d + ((13 * (m + 1)) / 5) + y + (y / 4) + (c / 4) + 5 * c) % 7;

                string weekday = null;


                if (numberofweek == 1)
                {
                    weekday = "Sunday";
                }
                else if (numberofweek == 2)
                {
                    weekday = "Monday";
                }
                else if (numberofweek == 3)
                {
                    weekday = "Tuesday";
                }
                else if (numberofweek == 4)
                {
                    weekday = "Wednesday";
                }
                else if (numberofweek == 5)
                {
                    weekday = "Thursday";
                }
                else if (numberofweek == 6)
                {
                    weekday = "Friday";
                }
                else if (numberofweek == 0)
                {
                    weekday = "Saturday";
                }

                Console.WriteLine("You were born on a " + weekday);


            }      else
            {
                Console.WriteLine("Write your birthday YYYY/MM/DD");
            }   
        }
    }
}
