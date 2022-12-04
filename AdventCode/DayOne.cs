using System;
using System.Linq;

namespace AdventCode
{ 
    internal class DayOne
    {
        static void Main()
        {
            //TODO Read input file. Reads each line and adds them to array seperately 
            String[] lines = File.ReadAllLines(@"C:\Users\jmota\Desktop\C#practice\AdventCode\AdventCode\input.txt");

            int calories = 0;
            List<int>elf = new List<int>();
                        
            foreach (var line in lines)
            {
                 if (string.IsNullOrEmpty(line))
                {
                    //TODO If there is a null line and add the calories, reset count
                    elf.Add(calories);
                    calories = 0;
                }
                else
                {
                    //covert line to int and add it to the calories in
                    calories = calories + int.Parse(line);
                }
            }
            Console.WriteLine(elf.Max());
        }
    }
}