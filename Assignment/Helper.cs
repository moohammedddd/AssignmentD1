using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Helper<T> where T : IComparable<T> , INumber<T>
    {
        #region methoodQ1
        public static void Swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        public static bool IsSorted(T[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static void BubbleSort(T[] Arr)
        {
            bool sorted;
            if (!IsSorted(Arr))
                for (int i = 0; i < Arr.Length - 1; i++)
                {
                    sorted = false;
                    for (int j = 0; j < Arr.Length - 1 - i; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                            Helper<T>.Swap(ref Arr[j], ref Arr[j + 1]);
                        sorted = true;
                    }
                    if (!sorted)
                        break;
                }
        }
        #endregion

        #region methodQ2
        public static bool InRange(T min, T max, T value)
        {
            if (value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0)
            {
                return true;
            }
            return false;
           
        }

        public static T GetLength (T min, T max)
            {
            return max - min;

           }
        #endregion    

    }
}