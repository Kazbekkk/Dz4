/* Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. */
Console.Clear();

int  size, i, num_ar; Random r = new Random(); // обьявление переменных 

Console.WriteLine("Введите размер массива:");
size = int.Parse(Console.ReadLine()); // задаем размер массива 
int [] array = new int [size]; // создаем массив размер которого определяет "size"

// здаем значения в массив сами
for (i = 0; i < size; i++)
{
    Console.WriteLine("Введите числа которое хотите добавить в массив:");
    num_ar = int.Parse(Console.ReadLine());
    array [i] = num_ar; // присваеваем новые значения в массив
}

// задаем значения в массив рандомно
/* for (i = 0; i < size; i++)
{
    num_ar = r.Next(0, 100000000);
    array [i] = num_ar; // присваеваем новые значения в массив
} */

var str = string.Join(" ", array);
Console.WriteLine($"Числа которые добавили в массив {str}");



/* foreach (int array_new in array )
{
    Console.WriteLine($"Числа которые добавили в массив {array_new} ");
} */
