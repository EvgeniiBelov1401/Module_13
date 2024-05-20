namespace Exercise_13_03_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13.3.12
            while (true)
            {
                //13.3.10
                //string text = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

                //Console.WriteLine(text);

                Console.Write("Введите любой текст: ");
                string text = Console.ReadLine();

                Console.WriteLine();

                var sentence = text.ToCharArray();

                var uniqueChar = new HashSet<char>(sentence);
                foreach (char ch in uniqueChar)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
                Console.WriteLine(uniqueChar.Count);


                //13.3.11

                var numbers = new[]
                {
                '0','1','2','3','4','5','6','7','8','9'
                };

                var signes = new[]
                {
                ' ',',','.'
                };


                bool isNumberIn = uniqueChar.Overlaps(numbers);
                uniqueChar.ExceptWith(signes);
                Console.WriteLine($"\nЦифры присутствуют в предложении: {isNumberIn}\nКол-во символов без знаков препинания: {uniqueChar.Count}");


                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
