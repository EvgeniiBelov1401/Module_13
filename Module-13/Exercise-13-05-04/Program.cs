namespace Exercise_13_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words=new Stack<string>();

            while (true)
            {
                Console.Write("Введите слово(слова): ");
                var input = Console.ReadLine();
                if (input == "pop")
                {
                    words.TryPop(out string popResult);
                }
                else if (input == "peek")
                {
                    words.TryPeek(out string peekResult);
                    Console.Write(peekResult);
                }
                else
                {
                    words.Push(input);
                }
                

                

                Console.WriteLine();
                Console.Write("Стэк: ");
                if (words.Count == 0)
                {
                    Console.Write("-");
                }
                foreach (var word in words)
                {
                    Console.Write(word+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
