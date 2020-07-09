//Find Cost of Tile to Cover W x H Floor – Calculate the total cost of tile it would take to cover a floor plan of width and height, using a cost entered by the user.
using System;
using Utlity;

namespace FindCostofTile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program will ask you to enter width, then height, then cost of tile and give back total cost.");
            Console.WriteLine();
            Console.Write("Enter width:");
            float widthInput = UserInput.GetUserFloatInput();

            Console.Write("Enter height:");
            float heightInput = UserInput.GetUserFloatInput();

            Console.Write("Enter cost of tile:");
            float costperTile = UserInput.GetUserFloatInput();

            float totalCost = FindCost(widthInput, heightInput, costperTile);
            Console.WriteLine("Total Cost: $" + totalCost);
        }

        static float FindCost(float width, float height, float costPerTile)
        {
            float cost = width * height * costPerTile;
            return cost;
        }
        
    }
}
