namespace Exercise_13_03_04
{
    internal class Program
    {
        static void ShowBook(List<Contact> list)
        {
            foreach (Contact contact in list)
            {
                Console.WriteLine(contact.Name+" "+contact.PhoneNumber+" "+contact.Email);
            }
            Console.ReadLine();            
        }
        static void AddUnique(ref List<Contact> list)
        {
            bool isExist=false;
            Console.WriteLine("Введите новый контакт:");
            Contact newContact = new Contact(Console.ReadLine(), long.Parse(Console.ReadLine()), Console.ReadLine());


            foreach (Contact item in list)
            {
                if (item.Name == newContact.Name)
                {
                    Console.WriteLine("Этот контак создан ранее");
                    isExist = true;
                    break;
                }
               
            }
            if (!isExist)
            {
                list.Add(newContact);
                Console.WriteLine("Новый контакт добавлен");
            }
            else
            {
                Console.WriteLine("Контакт был добален ранее");
            }
        }
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>
            {
                new Contact("Ivan",79011234567,"ivan@mail.ru"),
                new Contact("Alex",89027654321,"alex@,ail.ru")
            };
           
             ShowBook(phoneBook);

            AddUnique(ref phoneBook);

            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));
            ShowBook(phoneBook);

            


        }
    }
}
