using System;

namespace AnalogueClockAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the input hours and minutes (you have only 5 tries)");
            int hours = 0;
            int minutes = 0;
            bool HoursCheck = false;
            bool MinutesCheck = false;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please input the hours of the analogue clock! (1-12): ");
                hours = int.Parse(Console.ReadLine());
                if (hours <= 12 && hours >= 1)
                {
                    HoursCheck = true;
                    break;
                }
                else{
                    Console.WriteLine("Invalid Input type you have only " + (5 - (i+1)) + " chances");
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter minutes (0-59): ");
                minutes = int.Parse(Console.ReadLine());
                if (minutes <= 59 && minutes >= 0)
                {
                    MinutesCheck = true;
                    break;
                }
                else{
                    Console.WriteLine("Invalid Input type you have only " + (5 - (i+1)) + " chances");
                }
            }

            if (HoursCheck && MinutesCheck)
            {
                
                int hourHandAngle = (hours % 12) * 30 + (minutes / 2);
                int minuteHandAngle = minutes * 6;
                int angle = Math.Abs(hourHandAngle - minuteHandAngle);
                if (angle > 180)
                {
                    angle = 360 - angle;
                }

                Console.WriteLine("The lesser angle between the hour hand and minute hand is {angle} degrees.");
            }
            else
            {
                Console.WriteLine("You have inputted wrong. Come back and try again ;)");
            }
        }
    }
}