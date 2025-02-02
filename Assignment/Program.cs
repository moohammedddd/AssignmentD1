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
        }
    }
}
