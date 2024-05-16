namespace Exercise_13_01_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bookPath = @"D:\Programming\Skillfactory\C#_projects\Module_13\Module-13\Exercise-13-01-06\cdev_Text.txt";

            string bookText=File.ReadAllText(bookPath);

            char[] separators = {' ','\n','\r'};

            var words=bookText.Split(separators,StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(words.Length);
        }
    }
}
