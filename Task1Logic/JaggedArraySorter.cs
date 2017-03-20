using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1Logic
{
    public class JaggedArraySorter
    {
        /// <summary>
        /// Sorting By Max Element
        /// </summary>
        /// <param name="array"></param>
        /// <param name="inc"></param>
        public static void SortingByMaxRowElement(int[][] array, bool inc = true)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            SortRows(array, CompareByMaxElement, inc);
        }

       /// <summary>
       /// Sorting by min element
       /// </summary>
       /// <param name="array"></param>
       /// <param name="inc"></param>
        public static void SortingByMinRowElement(int[][] array, bool inc = true)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            SortRows(array, CompareByMinElement, inc);
        }


        /// <summary>
        /// Sorting by sum of elements
        /// </summary>
        /// <param name="array"></param>
        /// <param name="inc"></param>
        public static void SortingBySumOfRowElements(int[][] array, bool inc = true)
        {
            if (array == null)
            {
                throw new NullReferenceException();
            }

            SortRows(array, CompareBySumOfElements, inc);
        }

        /// <summary>
        /// Sorting according to compareMethod parameter
        /// </summary>
        /// <param name="array"></param>
        /// <param name="compareMethod"></param>
        /// <param name="inc"></param>
        public static void SortRows(int[][] array, Func<int[], int[], int> compareMethod, bool inc = true)
        {
            
            if (array == null)
            {
                throw new NullReferenceException();
            }

            if (compareMethod == null)
            {
                throw new NullReferenceException();
            }

            int i = 1;
            bool found = true;

            while (i < array.Length && found)
            {
                found = false;
                for (int j = array.Length - 1; j >= i; j--)
                {
                    if (compareMethod(array[j - 1], array[j]) > 0 == inc)
                    {
                        Swap(array, j, j - 1);
                    }
                    found = true;
                }

                i++;
            }
        }

        /// <summary>
        ///Console-Print of array 
        /// </summary>
        /// <param name="array"></param>
        public static void ShowJaggedArray(int[][] array)
        {
            System.Console.Write("{");
            foreach (int[] row in array)
            {
                System.Console.Write(" { ");
                foreach (int element in row)
                {
                    System.Console.Write(element + " ");
                }
                System.Console.Write("} ");
            }
            System.Console.WriteLine("}");
        }


        #region PrivateMethods
        private static void Swap(int[][] array, int i, int j)
        {
            int[] tmp = array[j];
            array[j] = array[i];
            array[i] = tmp;
        }

        private static int CompareByMaxElement(int[] arr1, int[] arr2)
        {
            int firstMax = GetMaxElement(arr1);
            int secondMax = GetMaxElement(arr2);
            return firstMax.CompareTo(secondMax);
        }

        private static int GetMaxElement(int[] array)
        {
            int max = int.MinValue;
            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        private static int CompareByMinElement(int[] arr1, int[] arr2)
        {
            int firstMin = GetMinElement(arr1);
            int secondMin = GetMinElement(arr2);
            return firstMin.CompareTo(secondMin);
        }

        private static int GetMinElement(int[] array)
        {
            int min = int.MaxValue;
            foreach (int element in array)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        private static int CompareBySumOfElements(int[] arr1, int[] arr2)
        {
            int firstSum = GetSum(arr1);
            int secondSum = GetSum(arr2);
            return firstSum.CompareTo(secondSum);
        }

        private static int GetSum(int[] array)
        {
            int sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum;
        }
        #endregion
    }
       
}
