Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "рита")
{
  Console.WriteLine("Ура, это же Рита! ");  
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);      
}