/*  Задача 10: Напишите программу, которая принимает на вход
    трёхзначное число и на выходе показывает вторую цифру этого числа.
*/
int GetNumber()
{
Console.WriteLine("Введите любое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int fnumber = GetNumber();
{
  Console.WriteLine((fnumber / 10) % 10); 
}
