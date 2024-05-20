namespace Exercise_13_03_004
{
    internal class Program
    {
        static void PrintCollection(SortedSet<char> values)
        {
            foreach (char value in values)
            {
                Console.Write(value+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var collect1=new SortedSet<char>();
            var collect2=new SortedSet<char>();

            collect1.Add('B');
            collect1.Add('A');
            collect1.Add('D');
            collect1.Add('C');
            collect1.Add('Z');

            collect2.Add('X');
            collect2.Add('Y');
            collect2.Add('Z');

            PrintCollection(collect1);
            PrintCollection(collect2);

            Console.ReadLine();

            collect1.ExceptWith(collect2);
            PrintCollection(collect1);
            PrintCollection(collect2);
        }
    }
}
