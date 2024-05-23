using System.Diagnostics;
using System.Diagnostics.Contracts;

namespace Exercise_13_04_04
{
    internal class Program
    {
        static void ShowPhoneBook(Dictionary<string,Contact> list)
        {
            foreach (var contct in list)
            {
                Console.Write($"{contct.Key}: {contct.Value.phoneNumber},{contct.Value.Email}\n");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            
            var phoneBook=new Dictionary<string, Contact>();

            phoneBook.Add("Иван Алексеев",new Contact(79011234567,"ivan@mail.ru"));
            phoneBook.Add("Олег Петров",new Contact(79077654321,"oleg@mail.ru"));
            ShowPhoneBook(phoneBook);


            phoneBook.TryAdd("Ирина Сидорова",new Contact(79022345678,"irina@mail.ru"));
            ShowPhoneBook(phoneBook);


            if(phoneBook.TryGetValue("Ирина Сидорова",out Contact contact))
            {
                contact.phoneNumber = 79001112233;
            }
            else
            {
                Console.WriteLine($"Контакта не существует");
            }

            var timeTestNonsorted = Stopwatch.StartNew();
            ShowPhoneBook(phoneBook);
            Console.WriteLine(timeTestNonsorted.Elapsed.Nanoseconds);

            var phoneBookSorted = new SortedDictionary<string,Contact>();
            phoneBookSorted.Add("Иван Алексеев", new Contact(79011234567, "ivan@mail.ru"));
            phoneBookSorted.Add("Олег Петров", new Contact(79077654321, "oleg@mail.ru"));
            phoneBookSorted.Add("Ирина Сидорова", new Contact(79022345678, "irina@mail.ru"));

            var timeTestSorted = Stopwatch.StartNew();
            foreach (var item in phoneBookSorted)
            {
                Console.Write($"{item.Key}: {item.Value.phoneNumber},{item.Value.Email}\n");
            }
            Console.WriteLine(timeTestSorted.Elapsed.Nanoseconds);

        }
    }
}
