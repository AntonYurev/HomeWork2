// выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num = num * -1;
while (num/10 > 100)
{
    num = num / 10;
}
if (num / 100 == 0) 
{
    Console.Write("У числа нет третьей цифры.");
}
else
{
num = num % 10;
Console.Write("Третья цифра числа: " +num);
}