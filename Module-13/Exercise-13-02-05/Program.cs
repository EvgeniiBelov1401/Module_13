using System.Collections;

namespace Exercise_13_02_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new ArrayList()
            {
                "Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Des"
            };

            var numbers = new ArrayList()
            {
                1,2,3,4,5,6,7,8,9,10,11,12
            };

            var combinedList = new ArrayList();

            foreach (var number in numbers)
            {
                combinedList.Add(months[(int)number-1]);
                combinedList.Add(number);
            }

            foreach(var item in combinedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
