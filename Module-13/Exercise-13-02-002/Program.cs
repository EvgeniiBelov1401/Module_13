using System.Collections;

namespace Exercise_13_02_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var month = new[]
            {
                "Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Des"
            };

            var numbers = new[]
            {
                1,2,3,4,5,6,7,8,9,10,11,12
            };

            var arrayList=new ArrayList();

            arrayList.Add(3);
            arrayList.Add('d');
            arrayList.Add("Строка");

            arrayList.AddRange(month);
            arrayList.AddRange(numbers);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(arrayList.Count);
            
            Console.ReadLine();

            //arrayList.Clear();
            //Console.WriteLine(arrayList.Count);


            //Console.WriteLine(arrayList.Contains("fff"));


            //var arrayList1= arrayList.GetRange(3, arrayList.Count-3);
            //foreach (var item in arrayList1)
            //{
            //    Console.WriteLine(item);
            //}


            //Console.WriteLine(arrayList.IndexOf(11));


            //arrayList.Insert(3, "Insert");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine(arrayList.Count);


            //arrayList.Remove(6);
            //arrayList.Remove("Des");
            //arrayList.RemoveAt(0);
            // arrayList.RemoveAt(2);
            //arrayList.RemoveRange(0,3);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine(arrayList.Count);



            //arrayList.Reverse();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //arrayList.Sort();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}


            //arrayList.SetRange(0,numbers);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
