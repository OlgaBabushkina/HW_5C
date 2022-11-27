/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
int count = 0;
for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0)
            {
                count++;
            }
        Console.Write(array[i] + " ");
    }
Console.WriteLine($"количество четных чисел в массиве = " + count);

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */ 

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
int sum = 0;
for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(0,100);
            if (i % 2 > 0)
                {
                    sum = sum + array[i];
                }
        Console.Write(array[i] + " ");
    }
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = " + sum);

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double [size];
for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100) + new Random().NextDouble();
        Console.Write(Math.Round(array[i]) + " ");
    
    }
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            {
                min = array[i];
            }
        if (array[i] > max)
            {
                max = array[i];
            }
    }
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = " + (Math.Round(max)-Math.Round(min)));
Console.WriteLine($"Минимальное значение массива = " + Math.Round(min));
Console.WriteLine($"Максимальное значение массива = " + Math.Round(max));
