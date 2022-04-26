using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserNameAndLocation();
            ChristmasCountdown(DateTime.Now);

            // Call the RunExample method from the Program Class under Main and place it beneath the ChristmasCountdown call.
            GlazerApp.RunExample();

            // ensure the application does not automatically terminate and prompt the user to press any key before exiting.
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }

        private static void GetUserNameAndLocation()
        {
            // Create a new instance of the Person class and give the instance a variable name of "person".
            Person person = new Person();

            // Prompt the user with a question "What is your name? " and assign their response to the name variable.
            Console.WriteLine("What is your name?");
            person.name = Console.ReadLine();

            // Using String Interpolation, reply and prompt the user with "Hi _______! Where are you from? "
            Console.WriteLine($"Hi {person.name}! Where are you from?");

            // Assign their response to the location attribute of person. 
            person.location = Console.ReadLine();

            // Using String Interpolation, reply and prompt the user with "I have never been to _______. I bet it is nice. Press any key to continue..."
            Console.WriteLine($"I have never been to {person.location}. I bet it is nice. Press any key to continue...");

            // Prompt the user to "Press any key to continue." And wait to proceed until a key is pressed.
            Console.ReadKey();
        }

        // The method must allow you to pass in a DateTime value when called.
        private static void ChristmasCountdown(DateTime date)
        {
            // Using String Interpolation, output the current date, but not the current time with the following message. "Today's date is: _____"
            Console.WriteLine($"Today's date is: {DateTime.Now.ToString("MM/dd/yyyy")}");

            // Create your own variable name to store the calculated value of the number of days until Christmas this year as a whole number.
            var daysTillChristmas = (DateTime.Parse("12/25/2022") - date).Days;

            // Using String Interpolation, output your variable like so "There are ___ days until Christmas!"
            Console.WriteLine($"There are {daysTillChristmas} days until Christmas!");

            // Prompt the user to "Press any key to continue." And wait to proceed until a key is pressed.
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }
    }
}
