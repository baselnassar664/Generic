using DemoNet6.Genric;
using DemoNet6.Helper;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace DemoNet6
{


    internal class Program
    {

        public static int sum(ArrayList array)
        {
            int sum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                sum += (int)array[i];
            }
            return sum;
        }


        static void Main(string[] args)

        {
            //no use genric
            //int a = 4;
            //int b = 5;
            //Console.WriteLine($"x={a},y={b}");
            //Helperr.swap(ref a,ref b);

            //Poi po1 = new Poi() { X = 1, Y = 2 };
            //Poi po2 = new Poi() { X = 3, Y = 4 };
            //Console.WriteLine($"x={po1},y={po2}");
            //Helperr.swap(ref po1, ref po2);

            #region use Genric

            //with methode genric
            //int a = 4;
            //int b = 5;
            //Console.WriteLine($"x={a},y={b}");

            //Helperr.swap(ref a, ref b);

            //with class genric

            int a = 4;
            int b = 5;
            Console.WriteLine($"x={a},y={b}");
            Helperr<int>.swap(ref a, ref b);

            int[] number = { 1, 2, 3, 4, 5 };
            int x = Helperr<int>.Search(number, 5);
            Console.WriteLine(x);

            string[] names = { "ahmed", "basel", "amjad" };
            int y = Helperr<string>.Search(names, "basel");
            Console.WriteLine(y);

            Emp em1 = new Emp()
            {
                Id = 1,
                Name = "Basel"
            };
            Emp em2 = new Emp()
            {
                Id = 2,
                Name = "Amjad"
            };
            Emp em3 = new Emp()
            {
                Id = 3,
                Name = "Ali"
            };

            Emp[] emps = { em1, em2, em3 };

            int z = Helperr<Emp>.Search(emps, new Emp() { Id = 3, Name = "Ali" });
            Console.WriteLine(z);

            //Genric constrain
            Console.WriteLine("-------");
            Poi poi1 = new Poi()
            {
                X = 1,
                Y = 2,
            };
            Poi poi2 = new Poi()
            {
                X = 3,
                Y = 4,
            };
            Poi poi3 = new Poi()
            {
                X = 5,
                Y = 6,
            };

            Poi[] Pois = { poi1, poi2, poi3 };

            //Helperrr genric bust be poi
            int zz = Helperrr<Poi>.Search(Pois, new Poi() { X = 3, Y = 4 });
            Console.WriteLine(zz);//1
            #endregion


            Console.WriteLine("---------------------");

            #region non Genric Collection (arraylist)
            ArrayList arrayList = new ArrayList();
            Console.WriteLine($"count={arrayList.Count},capacity={arrayList.Capacity}");

            arrayList.Add(1);

            Console.WriteLine($"count={arrayList.Count},capacity={arrayList.Capacity}");
            arrayList.Add(2);
            arrayList.Add("basel");
            arrayList.Add(new Emp() { Id = 1, Name = "ALI" });

            int[] num = { 3, 4, 5 };
            arrayList.AddRange(num);
            Console.WriteLine($"count={arrayList.Count},capacity={arrayList.Capacity}");

            arrayList.TrimToSize();//count = capacity

            Console.WriteLine($"count={arrayList.Count},capacity={arrayList.Capacity}");

            //sum(arrayList); //علشان هيك سيئة للاستخدام
            //error run time
            //لانو فيها 
            //int and string

            #endregion

            Console.WriteLine("---------------------");

            #region Genric Collection (lists)

            List<int> list = new List<int>();

            Console.WriteLine($"count={list.Count},capacity={list.Capacity}");
            list.Add(1);
            Console.WriteLine($"count={list.Count},capacity={list.Capacity}");
            //list.Add("basel");//error because list is genric collection

            int[] n = { 6, 4, 5 };
            list.AddRange(n);

            list.TrimExcess();//count = capaci
            Console.WriteLine($"count={list.Count},capacity={list.Capacity}");

            foreach (int i in n) Console.WriteLine(i);



            #endregion

            Console.WriteLine("---------------------");

            #region Genric Collection (LinkedList)
            LinkedList<int> l = new LinkedList<int>();//افضل في الاضافة والحذف
            l.AddFirst(1);
            l.AddLast(2);
            l.AddLast(3);
            l.AddFirst(4);
            foreach (int item in l) Console.WriteLine(item);
            l.RemoveFirst();
            l.RemoveLast();
            Console.WriteLine("--");
            foreach (int item in l) Console.WriteLine(item);

            #endregion


            #region Genric Collection [Hash Tables]-Dictionary (key,value)
            // key must be uniuq  ممنوع يتكرر
            // set data type for key and value
            //اتحدد داتا تايب الها

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>() {
                { 1, "basel" },
                { 2, "amjad" },

            };

            keyValuePairs.Add(3, "ali");


            //keyValuePairs.Add(2, "amjad"); //error key must be uniuq  ممنوع يتكرر

            keyValuePairs[4] = "karam"; //support indexer
            Console.WriteLine(keyValuePairs[4]);//use indexer to get
            foreach (var item in keyValuePairs) { Console.WriteLine(item); }

            if (!keyValuePairs.ContainsKey(1))//if no found number 1
                keyValuePairs.Add(1, "basel");
            else
                keyValuePairs[1] = "hema";//if found >>update

            Console.WriteLine("-------");
            foreach (var item in keyValuePairs) { Console.WriteLine(item); }

            Console.WriteLine(keyValuePairs.TryGetValue(6, out string value));//false not found number 6
            Console.WriteLine(value); //null not found value
            #endregion

            Console.WriteLine("---------------------");

            #region Genric Collection [Hash Tables] (key,value)

            //not set data type for key and value
            //لاتحدد داتا تايب الها
            // key must be uniuq  ممنوع يتكرر
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One");
            numberNames.Add("Two", 2);
            numberNames.Add(3, "Three");
            //numberNames.Add(3, "Three");//error key must be uniuq  ممنوع يتكرر
            foreach (DictionaryEntry de in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            #endregion

        }
    }
}
