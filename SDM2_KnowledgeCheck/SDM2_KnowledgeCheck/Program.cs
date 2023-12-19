using SDM2_KnowledgeCheck.Objects;
using System;
using System.Collections.Generic;

namespace SDM2_KnowledgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many parts do you want to add? ");
            var numberOfParts = int.Parse(Console.ReadLine());

            var partList = new List<Part>();
            for (int i = 0; i < numberOfParts; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var plate = new Plate();

                Console.WriteLine("Enter plate name ");
                plate.Name = Console.ReadLine();
                Console.WriteLine("Enter plate description");
                plate.Description = Console.ReadLine();
                Console.WriteLine("Enter plate length in decimal inches");
                plate.Length = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter plate width in decimal inches");
                plate.Width = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter plate height in decimal inches");
                plate.Height = Double.Parse(Console.ReadLine());

                partList.Add(plate);
            }
            // Print out the list of records using Console.WriteLine()
            foreach (var part in partList)
            {
                string output = part.ToString();
                Console.WriteLine(output);
            }
        }
    }
}


