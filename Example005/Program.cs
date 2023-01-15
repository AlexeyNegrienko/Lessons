Console.Write("введите имя пользователя: ");
string  username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Маша пришла");
}
else
{
  Console.Write("Здравствуй, ");
  Console.WriteLine(username);  
}

