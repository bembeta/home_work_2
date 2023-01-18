/*  Задача 13: Напишите программу, которая выводит третью цифру
    заданного числа или сообщает, что третьей цифры нет.
 */

 int GetNumber()
 {
    Console.WriteLine("Введите число до 999: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
 }

int fnumber = GetNumber(); 
{
    if (fnumber >= 100) 
    {
        fnumber = fnumber % 10;
        Console.WriteLine(fnumber);
    }
    else
    {
        Console.WriteLine("Число из двух цифр");
    }
}
