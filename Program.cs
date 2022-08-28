/*Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3


Console.Write("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];

void InputNumbers(int size)
{
for (int i = 0; i < size; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    array [i] = Convert.ToInt32(Console.ReadLine());
  }
}
int Comparison(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}
InputNumbers(size);
Console.WriteLine($"Введено чисел больше 0: {Comparison(array)} ");

Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write ("Введите значение b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите значение k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите значение b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите значение k2:");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine ($"Точка пересечения: {x} , {y}");

Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
Console.Write ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int remainder = 0;
int i = 0;
int [] result = new int [10];
while ( number >= 1)
{
  remainder = number % 2;
  result[i] = remainder;
  i++;

  number /= 2;
  Console.Write(remainder);
}

 
