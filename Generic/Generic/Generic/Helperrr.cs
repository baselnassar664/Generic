using DemoNet6.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.Genric
{
    internal static class Helperrr<T> where T : Poi
    {
        /*primary constrain [0:1]
         * 1>>genral primary constrain
         * class >>T must be class
         * struct >>T must be struct
         * class >>T must be enum
         * 
         * 2>>specail primary constrain
         * 
         * 
         * */

        public static void swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"x={x},y={y}");
        }


        public static int Search(T[] arr, T value)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                //if (arr[i] == value)//error
                if (arr[i].Equals(value))
                    return i;
            }
            return -1;//-1 not found
        }

    }
}
