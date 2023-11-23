Console.Write("введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{ 
    Console.Write("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
