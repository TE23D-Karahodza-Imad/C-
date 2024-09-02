Console.WriteLine("Användarnamn: ");
string name = Console.ReadLine();

if (name.ToLower() == "imad")
{
Console.WriteLine("Inloggad! Välkommen!");
}

else if (name == "Adam")
{
Console.WriteLine("Du får inte komma in!");
}
else if (name == "Dahri")
{
    Console.WriteLine("Tagga härifrån");
}

else 
{
    Console.WriteLine("DU är stupid!");
}

Console.ReadLine();
