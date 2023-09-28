using System;
using System.Collections.Generic;
using System.Linq;



class Program
{

    static void Main(string[] args)
    {
        var phoneBook = new List<Contact>();

        phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
        phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

        var grouped = phoneBook.GroupBy(c => c.Email.Split("@").Last());

        
        foreach (var group in grouped)
        {
            
            if (group.Key.Contains("example"))
            {
                Console.WriteLine("Фейковые адреса: ");

                foreach (var contact in group)
                    Console.WriteLine(contact.Name + " " + contact.Email);

            }
            else
            {
                Console.WriteLine("Реальные адреса: ");
                foreach (var contact in group)
                    Console.WriteLine(contact.Name + " " + contact.Email);
            }

            Console.WriteLine();
        }

    }

}
public class Contact
{
    public Contact(string name, long phoneNumber, String email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public String Name { get; }
    public long PhoneNumber { get; }
    public String Email { get; }
}




