namespace Exercise_13_05_002
{
    internal class Program
    {
        static void ShowStack(Stack<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();

                var numbers = new Stack<int>();

                for (int i = 0; i < 10; i++)
                {
                    numbers.Push(random.Next(100));
                }

                ShowStack(numbers);




                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
