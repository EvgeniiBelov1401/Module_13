namespace Exercise_13_03_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

            Console.WriteLine(text);
            Console.WriteLine();

            var sentence = text.ToCharArray();

            var uniqueChar=new HashSet<char>(sentence);
            foreach(char ch in uniqueChar)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
            Console.WriteLine(uniqueChar.Count);

        }   
    }
}
