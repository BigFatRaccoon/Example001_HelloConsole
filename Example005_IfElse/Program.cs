Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Палыч")
{
    Console.WriteLine("Да это же Палыч!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
