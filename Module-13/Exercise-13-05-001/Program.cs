namespace Exercise_13_05_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            //var element= stack.Pop();
            //var element=stack.Peek();
            //Console.WriteLine(element);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
