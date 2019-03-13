using System;

namespace Holiday
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Create a method that takes the day you are leaving on vacation and 
            //how many days you will be gone and return the name of the day of the week you will return.

            //Algorithm:
            //Ask the user for the date of vacation
            //Create a DateTime variable and store value in it
            //Ask user for how many days they will be gone
            //Create an int type variable and store user input in it
            //Find date of return by adding daysOfVacation to dateOfVacation
            //print the date of return and give name of the week of return

            //Testing DayOfWeek funtion
            //DateTime myValue = DateTime.Today;
            //Console.WriteLine($"Today is {myValue.DayOfWeek}");


            Console.WriteLine("Enter your travel date in the format mm/dd/yyyy");
            DateTime travel_Date_For_Vacation = DateTime.Parse(Console.ReadLine().Trim());

            Console.WriteLine("Enter how many days you will be on vacation: ");
            int days_Of_Vacation = int.Parse(Console.ReadLine());

            string day_Of_Return = DayReturning(travel_Date_For_Vacation, days_Of_Vacation);
            Console.WriteLine($"Your vacation starts on {travel_Date_For_Vacation}");
            Console.WriteLine($"You will be back on {day_Of_Return}");

            
            Console.ReadLine();
        }
        public static string DayReturning(DateTime vacationDate, int totalDaysVacation)
        {
            DateTime return_Day = vacationDate.AddDays(totalDaysVacation);
            //Console.WriteLine(return_Day.DayOfWeek);
            //Console.ReadLine();
            return return_Day.DayOfWeek.ToString();
        }

        
    }
}
