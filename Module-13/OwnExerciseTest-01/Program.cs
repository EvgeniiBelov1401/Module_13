namespace OwnExerciseTest_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                var nonSortedList = new List<int>();


                for (int i = 0; i < random.Next(100); i++)
                {
                    nonSortedList.Add(random.Next(100));
                }

                Console.WriteLine($"Показать неотсортированный лист из {nonSortedList.Count} элементов:");
                Console.ReadLine();

                foreach (var item in nonSortedList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Лист из уникальных элементов");
                Console.ReadLine();

                var uniqueList = new SortedSet<int>(nonSortedList);

                Console.WriteLine($"Лист из {uniqueList.Count} уникальных элементов:");
                foreach (var item in uniqueList)
                {
                    Console.WriteLine(item);
                }



                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
