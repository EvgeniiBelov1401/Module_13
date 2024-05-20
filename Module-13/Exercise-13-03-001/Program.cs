namespace Exercise_13_03_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contacts=new List<Contact>();

            contacts.Add(new Contact("Ivan",79011234567,"ivan@mail.ru"));
            contacts.Add(new Contact("Alex",89027654321,"alex@mail.ru"));

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.Name+" "+contact.PhoneNumber+" "+contact.Email);
            }
        }
    }
}
