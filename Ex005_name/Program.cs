Console.Write("Введите свое имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "юля") 
{
    Console.WriteLine("Так это же ЮЛЯ");
}
else
{
    Console.Write("Ну привет, ");
    Console.WriteLine(username);
}