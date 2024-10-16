List<string> contacts = new List<string> { };
string newcontact;
string YesNo;
int action;
bool exitcheck = true;

while (exitcheck)
{
    Console.WriteLine($"Welcome to the contact manager!");
    Console.Write($"Insert one of the following numbers:\n" +
        $"1 - Add a contact\n" +
        $"2 - View contacts\n" +
        $"3 - Contact Searcher\n" +
        $"4 - Delete a contact\n");
    action = int.Parse(Console.ReadLine());


    if (action == 1)
    {
        Console.Write("Write the contact to add: ");
        newcontact = Console.ReadLine();
        if (!contacts.Contains(newcontact))
        {
            contacts.Add(newcontact);
        }
        else
        {
            Console.WriteLine("You already have this contact!");
        }
    }
    else if (action == 2)
    {
        Console.Write("Your contacts: ");
        foreach (string contact in contacts)
        {
            Console.Write($"{contact} ");
        }
    }
    else if (action == 3)
    {
        Console.Write("Write the contact to check: ");
        newcontact = Console.ReadLine();
        if (contacts.Contains(newcontact))
        {
            Console.WriteLine($"{newcontact} is saved in your contacts.");
        }

    }
    else if (action == 4)
    {
        Console.Write("Write the contact to delete: ");
        newcontact = Console.ReadLine();
        if (contacts.Contains(newcontact))
        {
            contacts.Remove(newcontact);
            Console.WriteLine("The contact was deleted succesfully.");
        }
        else
        {
            Console.WriteLine("You don't have this contact!");
        }

    }

    Console.WriteLine("Do you wish to exit the program? If not, you will be sent back to the start menù. Y/N");
    YesNo = Console.ReadLine();
    if (YesNo == "Y")
    {
        exitcheck = false;
    }

    Console.Clear();

}