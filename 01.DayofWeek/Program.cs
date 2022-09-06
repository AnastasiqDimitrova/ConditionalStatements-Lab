using System;

namespace _01.DayofWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double EXCELLENT_GRADE = 5.5;
            double currentGrade = double. Parse(Console.ReadLine());
            bool isExcellentGrade = currentGrade >= EXCELLENT_GRADE;
            if (isExcellentGrade)
                Console.WriteLine("Excellent!");
        }
        
    }
}
