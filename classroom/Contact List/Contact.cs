namespace Contact_List;

public class Contact
{
    private static List<Contact> _contacts = new List<Contact>();
    private string Name { get; set; }
    private string PhoneNumber { get; set; }
    private string Email { get; set; }

    private Contact(string name, string phoneNumber, string email)
    {
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public static void AddNewContact()
    {
        Console.Write("Enter the contact's name: ");
        var name = Console.ReadLine();
        Console.Write("Enter the contact's phone number: ");
        var phoneNumber = Console.ReadLine();
        Console.Write("Enter the contact's email: ");
        var email = Console.ReadLine();

        var contact = new Contact(name, phoneNumber, email);
        _contacts.Add(contact);

        Console.WriteLine("Contact added successfully!");
    }

    public static void ListAllContacts()
    {
        for (int i = 0; i < _contacts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_contacts[i]}");
        }
    }

    public static void SearchByName()
    {
        Console.Write("Enter the name to search for: ");
        var name = Console.ReadLine();
        Console.WriteLine("Searching...");
        var contact = _contacts.Find(a => a.Name == name).ToString();
        if (contact == string.Empty)
        {
            Console.WriteLine("Contact not found.");
        }

        Console.WriteLine("Results:\n" + contact);
    }

    public override string ToString()
    {
        return $"{Name}, Phone: {PhoneNumber}, Email: {Email}";
    }
}