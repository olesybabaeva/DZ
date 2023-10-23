// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
if (numberOfDay == 6)
{
    Console.WriteLine("Да (выходной день)");
}
else if (numberOfDay == 7)
{
    Console.WriteLine("Да (выходной день)");
}
else if (numberOfDay == 1)
{
    Console.WriteLine("Нет (не выходной день)");
}
else if (numberOfDay == 2)
{
    Console.WriteLine("Нет (не выходной день)");
}
else if (numberOfDay == 3)
{
    Console.WriteLine("Нет (не выходной день)");
}
else if (numberOfDay == 4)
{
    Console.WriteLine("Нет (не выходной день)");
}
else if (numberOfDay == 5)
{
    Console.WriteLine("Нет (не выходной день)");
}
else
{
    Console.WriteLine("Такого дня нет");
}