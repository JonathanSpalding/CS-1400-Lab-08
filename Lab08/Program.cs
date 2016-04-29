// Author: Jonathan Spalding
// Assignment: Lab 08
// Instructor Roger deBry
// Clas: CS 1400
// Date Written: 2/2/2016
//
// "I declare that the following source code was written solely by me. I understand that copying any source code, in whole or in part, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy."
//----------------------------------------------------


using System;
using static System.Console;

namespace Lab08
{
    class Program
    {
        // The static void Main Method
        // Purpose: take the radius of one circle, and find the unused space between four of these circles in a square. (In other words, get Farmer John the area of the grey area between his crops)
        // Parameters: None? I deleted everything in the parentheses below.
        // Returns: none
        static void Main()
        {
            // declare the variables and constants that will be used in the program.

            // ask the user to input the radius of one of his fields and put that in a variable.

            // Multiply this radius squared (math.pow()) by pi (math.PI()) and put it in its own variable as the area.

            // Multiply the radius by two, then squared to find the area of the square between the four vertices, then assign it to a variable as the area for the squre.

            // Subract the circle's area from the square's area, and the difference is the area of the greyed out area in the diagram mentioned in the assignment.

            // Output in a writeline the area so the user can know the answer.

            ReadKey(true);
        }
    }
}
