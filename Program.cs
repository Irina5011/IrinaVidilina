
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите чсло =>");  // вывод пргилащшеня для ввода
string strValue = Console.ReadLine();   // ввод строки

int value = int.Parse(strValue);        // преобразуем строку в целое число

            if (value % 2 == 0)
            {
                Console.WriteLine("четное");
            }
            else
            {
                Console.WriteLine("не четное");
            }