using Contact_List;

Console.WriteLine("Welcome to your Contact List.\n");
while (true)
{
    Console.WriteLine("Please choose an option:\n" +
                      "1. Add Contact\n" +
                      "2. View All Contacts\n" +
                      "3. Search Contacts\n" +
                      "4. Exit");
    var option = Console.ReadLine();
    switch (option)
    {
        case "1":
        {
            Contact.AddNewContact();
            break;
        }
        case "2":
        {
            Contact.ListAllContacts();
            break;
        }
        case "3":
        {
            Contact.SearchByName();
            break;
        }
        case "4":
        {
            Console.WriteLine("Exiting application");
            return;
        }
        default:
        {
            Console.WriteLine("Wrong option, try again.");
            break;
        }
    }
}