List<string> contatti = new List<string> {};
Console.Write("Scrivi il contatto per aggiungerlo o rimuoverlo: ");
string newcontact = Console.ReadLine();
int control = 0;
if (!contatti.Contains(newcontact))
{
    contatti.Add(newcontact);
}

Console.WriteLine("I contatti sono: ");

foreach  (string contact in contatti)
{
    Console.Write($"{contact} ");
}