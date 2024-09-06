Console.WriteLine("Användarnamn: ");
string name = Console.ReadLine();


if (name.ToLower() == "micke")
{
  Console.WriteLine("Inloggad! Välkommen!");
}
else if (name == "martin" || name == "liv")
{
  Console.WriteLine("Mja, kanske");
}
else
{
  Console.WriteLine("Nuh-uuh!");
}

Console.ReadLine();