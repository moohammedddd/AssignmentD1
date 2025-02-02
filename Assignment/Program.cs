using System.ComponentModel.Design;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int[] arr = { 5, 2, 6, 4, 8, 2, 7, };
            Helper<int>.BubbleSort(arr);
            foreach (int item in arr)
            {
                Console.WriteLine($"{item}");
            }
            #endregion

            #region Q2
            Range range = new Range(10, 20);
            if (Helper<int>.InRange(range.min, range.max, 15)) 
                Console.WriteLine("the value in the range}");
            else
                Console.WriteLine("the value is not in the range");

            Console.WriteLine($"The Length is {Helper<int>.GetLength(range.min, range.max)}");
           
            #endregion

        }
    }
}
