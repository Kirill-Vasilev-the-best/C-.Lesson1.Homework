// Задача №4. Программа, которая на вход принимает 3 числа и выдает максимальное из них
Console.WriteLine("Введите 1-ое число (целое число)");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число (целое число)");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ое число (целое число)");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{

}
else if (a > c)
{
    Console.WriteLine($"Максимальное число из введеных это {a}");
}
else
{
    Console.WriteLine($"Максимальное число из введеных это {c}");
}
if (a < b)
{

}
else if (b > c)
{
    Console.WriteLine($"Максимальное число из введеных это {b}");
}
else
{
    Console.WriteLine($"Максимальное число из введеных это {c}");
}
