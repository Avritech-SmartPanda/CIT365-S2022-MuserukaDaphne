using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    // Create a new class file called "GlazerApp.cs" and set the class to static.
    public static class GlazerApp
    {
        // Create a new method called "RunExample". Remember that this method must be set to public so that
        // it can be accessed outside of the GlazerApp class. Make sure to also add the static void keywords.
        public static void RunExample()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            // the user is prompted for a width, and assign the width input value to a variable. 
            Console.Write("Enter width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            // the user is prompted for a height, and assign the height input value to a variable. 
            Console.Write("Enter height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            //  the calculated wood length in feet.
            woodLength = 2 * (width + height) * 3.25;
            Console.WriteLine("The length of the wood is " +  woodLength + " feet");

            // glass area in square meters.
            glassArea = 2 * (width * height);           
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");
        }
    }
}
