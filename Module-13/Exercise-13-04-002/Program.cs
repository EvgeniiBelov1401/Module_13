namespace Exercise_13_04_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items=new Dictionary<string,string>();


            //МЕТОДЫ
            #region Add()
            items.Add("гитара", "Струнный щипковый музыкальный инструмент");
            items.Add("барабан", "Ударный инструмент");
            items.Add("тромбон", "Духовой инструмент");
            #endregion

            #region ContainsKey()
            bool guitarExist = items.ContainsKey("гитара");
            bool drumEXist = items.ContainsKey("виолончель");
            #endregion

            #region ContainsValue()
            bool exist = items.ContainsValue("Ударный инструмент");
            #endregion

            //СВОЙСТВА

            #region Keys
            var musicItems=new Dictionary<string,string>();
            musicItems.Add("гитара", "Струнный щипковый музыкальный инструмент");
            musicItems.Add("барабан", "Ударный инструмент");
            musicItems.Add("тромбон", "Духовой инструмент");

            foreach(var c in musicItems.Keys)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
            #endregion

            #region Values
            foreach(var c in musicItems.Values)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
            #endregion
        }
    }
}
