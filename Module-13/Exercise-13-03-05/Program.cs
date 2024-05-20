using System.Collections;

namespace Exercise_13_03_05
{
    internal class Program
    {
        static void FullYearList(List<string>month,ArrayList list)
        {
            var forAdding = new List<string>();

            foreach (var item in list)
            {
                if (item is string)
                {
                    forAdding.Add((string)item);
                }
            }

            month.AddRange(forAdding);

            foreach (var item in month)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            var month = new List<string>
            {
                "Jan","Feb","Mar","Apr","May"
            };

            var missing = new ArrayList()
            {
               1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            FullYearList(month,missing);


        }
    }
}
