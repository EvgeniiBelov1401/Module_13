using System.Collections;
using System.Text;

namespace Exercise_13_02_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static ArrayList ListReMake(ArrayList list)
            {
                var arrayListRemake= new ArrayList();
                var sum = 0;
                StringBuilder text = new StringBuilder();

                foreach (var item in list)
                {
                    if (item is int)
                    {
                        sum +=(int) item;
                    }
                    else
                    {
                        text.Append(item);
                    }
                }
                arrayListRemake.Add(sum);
                arrayListRemake.Add(text);

                return arrayListRemake;
            }

            var arrayListStart = new ArrayList()
            {
                1,"Привет",12,"Как дела",100,"Hello",87,"world"
            };

            foreach(var item in ListReMake(arrayListStart))
            {
                Console.WriteLine(item);
            }
        }
    }
}
