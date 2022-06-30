using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStask01
{
    internal class Assignment1
    {

        //Write program to enter an integer number of centuries and convert it to years, days, hours,
        //minutes, seconds, milliseconds, microseconds, nanoseconds.
        public void Countyear()
        {
            long input;
            input = long.Parse(Console.ReadLine());

            Console.WriteLine(input + " Centuries = "
                 + input * 100 + " years = " + input * 100 * 365 + " days = "
                + input * 100 * 365 * 24 + " hours = "
                + input * 100 * 365 * 24 * 60 + " minutes = "
                 + input * 100 * 365 * 24 * 60 * 60 + " seconds = "
                + input * 100 * 365 * 24 * 60 * 60 * 1000 + " miliseconds = "
                + input * 100 * 365 * 24 * 60 * 60 * 1000 * 1000 + " microseconds = "
                + +input * 100 * 365 * 24 * 60 * 60 * 1000 * 1000 * 1000 + "nanoseconds"
                );
        }
        //Practice loops and operators 01
        public void Fizzbuzz()
        {
            for (byte i = 0; i < 100; i++)
            {
                if (i % 15 == 0) { Console.WriteLine("Fizzbuzz"); }
                else if (i % 3 == 0) { Console.WriteLine("Fizz"); }
                else if (i % 5 == 0) { Console.WriteLine("Buzz"); }
                else { Console.WriteLine(i); }
            }
        }
        //Practice loops and operators 02
        //pass how many level you wanna print as argument
        public void pyramid(int level)
        {
            for(int i = 0; i < level; i++) 
            {
                String space = new String(' ', level - 1 - i);
                String output = new string('*', i * 2 + 1);
                Console.WriteLine(space + output); 
            }
        }
        //Practice loops and operators 03
        public void guess()
        {
            Random random = new Random();
            int input = int.Parse(Console.ReadLine());
            int guessNum = random.Next() % 3 + 1;
            if(input < 1 || input > 3)
            {
                Console.WriteLine("Out of Range");
            }
            else if(input == guessNum)
            {
                Console.WriteLine("Correct");
            }
            else if (input < guessNum)
            {
                Console.WriteLine("Low");
            }
            else if (input > guessNum)
            {
                Console.WriteLine("High");
            }
        }
        //Practice loops and operators 04
        //if someone born on 1995:04:14, then input 19950414
        public void birthday(int input)
        {
            int day = 0;
            day += (2022 - input / 10000) * 365;
            day += (06 - (input % 10000) / 100) * 30;
            day += 28 - (input % 100); 
            int daysToNextAnniversary = 10000 - (day % 10000);
            Console.WriteLine(day + "   " + daysToNextAnniversary);
        }

        //Practice loops and operators 05
        public void dateTime()
        {
            DateTime dateTime = DateTime.Now;
            int hour = Int16.Parse(dateTime.ToString("HH")) * 3600;
            hour += Int16.Parse(dateTime.ToString("mm")) * 60;
            hour += Int16.Parse(dateTime.ToString("ss"));
            Console.WriteLine(hour);
            if (hour < 6 * 3600) { Console.WriteLine("Good Night"); }
            if (hour >= 6 * 3600 && hour < 12 * 3600) 
            { Console.WriteLine("Good Morning"); }
            if (hour >= 12 * 3600 && hour < 18 * 3600) 
            { Console.WriteLine("Good Afternoon"); }
            if (hour >= 18 * 3600) { Console.WriteLine("Good Evening"); }

        }
        //Practice loops and operators 06
        public void count()
        {
            
            for(int counter = 1; counter <= 4; counter++)
            {
                String output = "";
                for (int i = 0; i <= 24; i += counter) 
                {
                    output += i.ToString() + " ";
                }
                Console.WriteLine(output);
            }
        }


    }


}
