using System;

string newcontact;
List<string> contacts = new List<string>();

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

Console.Write("Your contacts: ");
foreach (string contact in contacts)
{
    Console.WriteLine($"{contact} ");
}

Console.Write("Write the contact to check: ");
newcontact = Console.ReadLine();
if (contacts.Contains(newcontact))
{
    Console.WriteLine($"{newcontact} is saved in your contacts.");
}

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

