// принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите любое трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = num % 100;
num = num / 10;
Console.Write("Вторая цифра этого числа: "+num);
