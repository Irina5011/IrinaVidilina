// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число =>");  // вывод пргилащшеня для ввода
string strValue1 = Console.ReadLine();   // ввод строки

int value1 = int.Parse(strValue1);        // преобразуем строку в целое число

Console.WriteLine("Введите второе число=>");  // вывод пргилащшеня для ввода

string strValue2 = Console.ReadLine();   // ввод строки

int value2 = int.Parse(strValue2);        // преобразуем строку в целое число

if (value1 > value2)
{ 
Console.WriteLine("max = " + value1 + " min = "+ value2); //вывод результата
}
if (value2 > value1)
{ 
Console.WriteLine("max = " + value2 + " min = "+ value1); //вывод результата
}

