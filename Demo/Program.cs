using System.Collections;

namespace Demo
{
    internal class Program
    {
        public static int? SumArrayList(ArrayList arrayList)
        {
            int? Sum = 0;
            if (arrayList is not null)
            {
                for (int i = 0; i < arrayList.Count; i++)
                {
                    Sum += (int?)arrayList[i];
                }
            }
            return Sum;
        }
        static void Main(string[] args)
        {
            #region Video 1
            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine($"Count ==> {arrayList.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity}");
            //arrayList.Add(1);
            //Console.WriteLine($"Count ==> {arrayList.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity}");
            //arrayList.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"Count ==> {arrayList.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList.Capacity}");
            //ArrayList arrayList1 = new ArrayList(5);
            //Console.WriteLine($"Count ==> {arrayList1.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            //arrayList1.AddRange(new int[] { 1, 2, 3, 4, 5 });
            //Console.WriteLine($"Count ==> {arrayList1.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            //arrayList1.Add(6);
            //Console.WriteLine($"Count ==> {arrayList1.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            //arrayList1.TrimToSize();
            //Console.WriteLine($"Count ==> {arrayList1.Count}");
            //Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            //arrayList1.Add("Mostafa");
            //int? Sum = SumArrayList(arrayList1); 
            //Console.WriteLine(Sum);
            #endregion

            #region Video 2
            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count ==> {Numbers.Count}");
            //Console.WriteLine($"Capacity ==> {Numbers.Capacity}");
            //Console.WriteLine();
            //Numbers.Add(1);
            //Console.WriteLine($"Count ==> {Numbers.Count}");
            //Console.WriteLine($"Capacity ==> {Numbers.Capacity}");
            //Console.WriteLine();
            //Numbers.AddRange(new int[] { 2, 3, 4 });
            //Console.WriteLine($"Count ==> {Numbers.Count}");
            //Console.WriteLine($"Capacity ==> {Numbers.Capacity}");
            //Console.WriteLine();
            //Numbers.Add(5);
            //Console.WriteLine($"Count ==> {Numbers.Count}");
            //Console.WriteLine($"Capacity ==> {Numbers.Capacity}");
            //Console.WriteLine(); 
            //Numbers.TrimExcess();
            //Console.WriteLine($"Count ==> {Numbers.Count}");
            //Console.WriteLine($"Capacity ==> {Numbers.Capacity}");
            //Console.WriteLine();
            //List<int> Numbers2 = new List<int>(5) { 1,2,3,4,5};
            //Console.WriteLine($"Count ==> {Numbers2.Count}");
            //Console.WriteLine($"Capacity ==> {Numbers2.Capacity}");
            //Console.WriteLine();
            //Numbers2.Add(6);
            //Console.WriteLine($"Count ==> {Numbers2.Count}");
            //Console.WriteLine($"Capacity ==> {Numbers2.Capacity}");
            //Console.WriteLine();
            //foreach(int Number in Numbers2)
            //{
            //    Console.WriteLine(Number);
            //}
            //Console.WriteLine();
            //List<int> Numbers3 = new List<int>(5) {1,2,3,4,5};
            ////Numbers3.Add("Mostafa");
            //Console.WriteLine(Helper.SumList(Numbers3));
            #endregion

            #region Video 3
            List<int> Numbers = new List<int>();
            Numbers.Add(1);
            Numbers.AddRange(new int[] {2,3});
            Numbers.Insert(3,4);
            Numbers.InsertRange(4, new int[] {5,2 });
            //Numbers.Clear();
            foreach(int Number in Numbers)
            {
                Console.WriteLine(Number);
            }
            Console.WriteLine(Numbers.Contains(9));
            Console.WriteLine(Numbers.Contains(5));
            Console.WriteLine(Numbers.Capacity);
            Console.WriteLine(Numbers.EnsureCapacity(9));
            Console.WriteLine(Numbers.IndexOf(2));
            Console.WriteLine(Numbers.LastIndexOf(2));
            #endregion
        }
    }
}
