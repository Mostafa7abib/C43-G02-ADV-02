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
            ArrayList arrayList = new ArrayList();
            Console.WriteLine($"Count ==> {arrayList.Count}");
            Console.WriteLine($"Capacity ==> {arrayList.Capacity}");
            arrayList.Add(1);
            Console.WriteLine($"Count ==> {arrayList.Count}");
            Console.WriteLine($"Capacity ==> {arrayList.Capacity}");
            arrayList.AddRange(new int[] { 2, 3, 4 });
            Console.WriteLine($"Count ==> {arrayList.Count}");
            Console.WriteLine($"Capacity ==> {arrayList.Capacity}");
            ArrayList arrayList1 = new ArrayList(5);
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.AddRange(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.Add(6);
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.TrimToSize();
            Console.WriteLine($"Count ==> {arrayList1.Count}");
            Console.WriteLine($"Capacity ==> {arrayList1.Capacity}");
            arrayList1.Add("Mostafa");
            int? Sum = SumArrayList(arrayList1); 
            Console.WriteLine(Sum);
            #endregion
        }
    }
}
