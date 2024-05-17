using System.Collections;

namespace Exercise_13_02_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list=new ArrayList() { 2,'d',"Строка"};

            foreach(object o in list)
            {
                Console.WriteLine(o);
            }
        }
    }
}
