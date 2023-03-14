using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNet6.Helper
{
    internal static class Helperr<T> 
    {

        #region non use genric
        //public static void swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"x={x},y={y}");
        //}

        //public static void swap(ref double x, ref double y)
        //{
        //    double temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"x={x},y={y}");
        //}


        //public static void swap(ref string x, ref string y)
        //{
        //    string temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"x={x},y={y}");
        //}

        //public static void swap(ref Poi x, ref Poi y)
        //{
        //    Poi temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"x={x},y={y}");
        //}
        //public static int Search(int[] arr, int number)
        //{

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] == number)
        //            return i;
        //    }
        //    return -1;//-1 not found
        //}
        #endregion

        #region use genric

         //with methode genric


        //public static void swap(ref T x, ref T y)
        //{
        //    T temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"x={x},y={y}");
        //}

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

      
        #endregion


    }
}
