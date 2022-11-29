// Задача №6. Программа, которая на вход принимает число и выдает, является ли число четным
Console.WriteLine("Пожалуйста введите целое число");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Число {num} четное");
}
else
{
    Console.WriteLine($"Число {num} НЕ четное");
}
