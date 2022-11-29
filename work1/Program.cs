// Задача №2. Программа, которая на вход принимает 2 числа и сравнивает их между собой
Console.WriteLine("Введите 1-ое число (целое число)");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число (целое число)");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
    Console.WriteLine($"Максимальное число из введеных это {a}");
}
if (a<b)
{
    Console.WriteLine($"Максимальное число из введеных это {b}");
}
