namespace Exercise_13_03_002
{
    internal class Program
    {
        static void ShowList(List<string> list)
        {
            foreach (var item in list)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            var months = new List<string>()
            {
                "Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep"
            };


            ShowList(months);

            //Добавление элементов в Лист
            //months.Add("Oct");
            //ShowList(months);


            //Добавление массива в Лист
            //months.AddRange(new[] {"Oct","Nov", "Dec"});
            //ShowList(months);


            //Бинарный поиск. Обязательно Лист должен быть отсортирован
            //months.Sort();
            //int result = months.BinarySearch("Jul");
            //Console.WriteLine(result);


            //Получение индекса элемента в Листе
            //int index = months.IndexOf("Feb");
            //Console.WriteLine(index);


            //Вставка элемента на позицию в Листе
            //months.Insert(0, "New Year");
            //ShowList(months);


            //Удаление элемента по инлексу в Листе
            //months.RemoveAt(3);
            //ShowList(months);
        }
    }
}
