// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("введите число А");                        // сообщение о вводе числа
int numA = Convert.ToInt32(Console.ReadLine());              // присваивание числу numА введенного значения
Console.WriteLine("введите степень B");                      // сообщение о вводе степени
int numB = Convert.ToInt32(Console.ReadLine());              // присваивание переменной numB введенного значения

double rezultat = Math.Pow(numA, numB);                      // собственно само решение через метод Math.Pow uly имеется 2 аргумента первый число второй степень
Console.WriteLine("Результат - "+rezultat);                  // вывод  результата
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Razmer(int num)                                          // метод нпхожденич разрядности
{
    int razr = 0;                                            // определчем переменную
    while (num>0)                                            // до тех пор пока число больше 1 выполнячется цикл
    {
        num = num /10;
        razr++;                                              // счетчик разрядности
    }
    return razr;                                             // возврат значения
}
int Last_digit(int dig)                                      // метод возврата последней цифры в числе
{
    int num3 = dig % 10;
    return num3;

}
//---------------------------------------Основная программа----------------------------------------

Console.WriteLine("введите число ");                         // вводим число
int num = Convert.ToInt32(Console.ReadLine());               // конвертируем присваиваем переменной
int num2 = num;                                              // объявление некоторых переменных
int rez = 0;
int j = 10;
int kolich= Razmer(num);                                     // вызов метода
for (int i=1; i<kolich+1; i++)                               // закпскаем цикл по количеству цифр в числе
{
    rez = rez + Last_digit(num2);                            // каждый раз прибавляем последнюю цифру после (int ) деления на 10 (с отбросом значения после запятой)
    num2 = num2/j;                                           // делим ццифру на 10 с отсечением остатка после запятой
}
Console.WriteLine($"сумма {kolich} цифр в числе равна {rez}"); // вывод конечного результата

*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine("Для генерации массива нажмите Enter");                   // вывод информаци на экран
Console.ReadLine();                                                         // одидание нажатия клавишы Enter для проджолжения
int[] array = {0,0,0,0,0,0,0,0};                                            // определяем пустой массив

for(int i=0; i < 8; i++)                                                    // создаем цикл от 0 до 7 с применением генератора чисел
{
    int num = new Random().Next(10,100);                                    // при каждой итерации присваиваем переменной num генерированное значение от 10 до 100
    array[i] = num;                                                         // каждому i - тому значению массива присваивается переменная num
   // Console.WriteLine($"значение массива ячейки {i} является {num}");     // здесь закоментировано вспомогательная строка информирования при отладке программы))
}

Console.Write("Массив рандомных чисел - array = {");                             // вывод на экран массива чисел 
for (int i=0; i<8; i++)                                                 // при помощи цикла от 0 до 7 
{
    Console.Write(array[i]);
    if (i < 7)                                                          // создаем условие для печати запятой междду символами массива при выводе на экран (если не 8 элемент то печатаем запятую)
    {
        Console.Write(", ");
    }
    else  {Console.Write("}");}                                         // если последний элемент то ставим фигурную скобку)
}




