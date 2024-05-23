namespace Exercise_13_04_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, string[]>();

            cities.Add("Россия", new[] {"Москва","Санкт-Петербург","Казань"});
            cities.Add("Украина", new[] { "Киев", "Львов", "Николаев", "Одесса" });
            cities.Add("Беларусь", new[] { "Минск", "Витебск", "Гродно" });


            //cities["Россия"] = new[] { "Мурманск", "Волгоград" };
            //cities.Remove("Беларусь");
            

            foreach (var country in cities)
            {
                Console.Write(country.Key+": ");
                foreach (var city in country.Value)
                {
                    Console.Write(city + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            

            var russianCities = cities["Россия"];
            Console.Write("Города России: ");
            foreach (var city in russianCities)
            {
                Console.Write(city+" ");
            }
        }
    }
}
