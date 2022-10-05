Console.WriteLine("Введите любое целое число");
int user_number = int.Parse(Console.ReadLine());

if (user_number % 2 == 0)
{
    Console.WriteLine("Это число четное?");
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Это число четное?");
    Console.WriteLine("Нет");
}
