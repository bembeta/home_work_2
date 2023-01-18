/*   Задача 15: Напишите программу, которая принимает на вход цифру,
     обозначающую день недели, и проверяет, является ли этот день выходным.
*/

int GetNumber()
{
    Console.WriteLine("Ввидете число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberDay = GetNumber();

if (numberDay == 1)
{
    Console.WriteLine("рабочий ден(");
}
if (numberDay == 2)
{
    Console.WriteLine("рабочий ден(");
}
if (numberDay == 3)
{
    Console.WriteLine("рабочий ден(");
}
if (numberDay == 4)
{
    Console.WriteLine("рабочий ден(");
}
if (numberDay == 5)
{
    Console.WriteLine("рабочий ден(");
}
if (numberDay == 6)
{
    Console.WriteLine("Выходной)");
}
if (numberDay == 7)
{
    Console.WriteLine("Выходной)");
}
if (numberDay > 7)
{
    Console.WriteLine("Такого дня недели не существует");
}
