using System;

namespace SelfTrainingProject.InterviewExcersize.FindHighestAndLowestNumberInAnArray
{
    class Program
    {
        public static int lowestNumberInArray = int.MaxValue;
        public static int highestNumberInArray = int.MinValue;

        public static int[] MyArray = new int[25]
        {19, 21, 98, 5000, 76, 21, 10, -5000, 46, 92, 18, -4999, 07, -11, -59, 997, 283, 1, -595, -928, 1000, -1, 3021, -3021, 123};

        public static void Main(string[] args)
        {
            foreach (var item in MyArray)
            {
                if (item < lowestNumberInArray)
                {
                    lowestNumberInArray = item;
                }
                if (item > highestNumberInArray)
                {
                    highestNumberInArray = item;
                }
            }
            Console.WriteLine("lowest number in array : " + lowestNumberInArray);
            Console.WriteLine("highest number in array : " + highestNumberInArray);

        }
    }
}
