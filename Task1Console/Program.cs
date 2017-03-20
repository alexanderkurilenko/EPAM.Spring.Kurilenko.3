using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1Logic;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = { new int[] { 1, 8, 3, 90, -900, -4 },
                                      new int[] { },
                                      new int[] { 86, 46, 100 }, 
                                      new int[] { 0, 461, -1 } 
                                  };
            int[][] tempArray = (int[][])array.Clone();
            
            JaggedArraySorter.SortingBySumOfRowElements(tempArray);
            JaggedArraySorter.ShowJaggedArray(tempArray);

            Console.ReadKey();


           
        }
    }
}
