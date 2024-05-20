using System.Xml.Linq;

namespace Exercise_13_03_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new[]
            {
                "Анна",
                "Алексей",
                "Игорь",
                "Юлия",
                "Антон",
                "Павел",
                "Светлана",
                "Антон",
                "Юлия",
                "Игорь"
            };
            Console.WriteLine($"Длина массива: {names.Length}\n");
            foreach ( var name in names )
            {
                Console.WriteLine( name );
            }
            Console.WriteLine();
            Console.ReadLine();


            var uniqueNames =new HashSet<string>(names);
            Console.WriteLine($"Длина хэш-сета: {uniqueNames.Count}\n");
            foreach(var item in uniqueNames ) 
            { 
                Console.WriteLine( item ); 
            }
            Console.ReadLine();


            uniqueNames.UnionWith(new[] { "Игорь", "Юлия","Андрей"});
            Console.WriteLine($"Длина хэш-сета после объединения: {uniqueNames.Count}\n");
            foreach (var item in uniqueNames)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
