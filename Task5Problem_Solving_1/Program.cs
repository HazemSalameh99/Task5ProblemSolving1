using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5Problem_Solving_1
{
    class Program
    {
        static int ConvertMinutesToSeconds(int minutes)
        {
            int seconds = minutes * 60;
            return seconds;
        }
        static int IncrementByOne(int number)
        {
            return number + 1;
        }
        static int GetFirstElement(int[]arr)
        {
            return arr[0];
        }
        static double CalculateTriangleArea(double Base, double Height)
        {
            double area = 0.5 * Base * Height;
            return area;
        }
        static int evenNumberEvenIndex(int[] numbers)
        {
            //int []result;
            foreach (int num in numbers)
            {
                if (num % 2 == 0 && numbers[num]%2==0)
                {
                        Console.WriteLine(num);
                }
            }
            return 0;
        }
        static string[] EvenIndexOddLength(string[] strings)
        {
            return strings.Where((str, index) => index % 2 == 0 && str.Length % 2 != 0).ToArray();
        }
        //static int[] PowerElementIndex(int[] nums)
        //{
        //    List result = new List();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        result.Add((int)Math.Pow(nums[i], i));
        //    }
        //    return result.ToArray();
        //}

        static int MultiplicationUsingSum(int a, int b)
        {
            int result = 0;
            for (int i = 0; i < b; i++)
            {
                result += a;
            }
            return result;
        }
        static int MultiplicationFromFirstToSecond(int start, int end)
        {
            int result = start;
            for (int i = start + 1; i <= end; i++)
            {
                result *= i;
            }
            return result;
        }
        static double AverageOfArray(int[] nums)
        {
            return nums.Average();
        }
        static void Main(string[] args)
        {
            //// 1
            //int minutes = 10;
            //Console.WriteLine($"{minutes} minute == {ConvertMinutesToSeconds(minutes)} Second");


            //// 2
            //int num = 5;
            //Console.WriteLine(IncrementByOne(num));


            //// 3
            //int[] number = { 1, 2, 3, 4, 5, 6 };
            //Console.WriteLine(GetFirstElement(number));



            //// 4
            //double Base = 5;
            //double Height = 9;
            //Console.WriteLine(CalculateTriangleArea(Base, Height));



            //// 5
            //int []nums = { 5, 2, 2, 1, 8, 66, 55, 77, 34, 9, 55, 1 };
            //Console.WriteLine((evenNumberEvenIndex(nums)));


            //// 6
            //string[] strings = { "alex", "mercer", "madrasa", "rashed2", "emad", "hala" };
            //Console.WriteLine(string.Join(", ", EvenIndexOddLength(strings)));


            ////7
            //int[] numsPower = { 44, 5, 4, 3, 2, 10 };
            //Console.WriteLine(string.Join(", ", PowerElementIndex(numsPower)));


            //// 8
            //Console.WriteLine(MultiplicationUsingSum(5, 4));
            //Console.WriteLine(MultiplicationUsingSum(2, 8));
            //Console.WriteLine(MultiplicationUsingSum(7, 6));



            //// 9
            //Console.WriteLine(MultiplicationFromFirstToSecond(4, 5)); 
            //Console.WriteLine(MultiplicationFromFirstToSecond(3, 6));



            // 10
            int[] nums = { 1, 2, 3, 8, 9 };
            Console.WriteLine(AverageOfArray(nums));
            int[] nums2 = { 1, 2, 3, 8, 9, 77 };
            Console.WriteLine(AverageOfArray(nums2));




        }
    }
}
