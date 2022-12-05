using System;
using System.Linq;

namespace AdventCode
{
    internal class DayOne
    {
        static void Main()
        {
            //TODO Read input file within InputFile folder. Reads each line and adds them to array seperately 
            String[] lines = File.ReadAllLines(@"InputFile/DayOne.txt");

            int calories = 0;

            List<int> elf = new List<int>();

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
            //Finding Max
            Console.WriteLine(elf.Max());

            /*Part Two: Find the top three Elves carrying the most Calories. How many Calories are those Elves carrying in total? */
            //Sorting through elf list and getting top 3 amounts
            var topThree = elf.OrderByDescending(i => i).Take(3);
            Console.WriteLine(string.Join(",", topThree));
            //summing top 3 amounts
            Console.WriteLine(topThree.Sum());
        }

    }
}