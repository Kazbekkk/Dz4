/* Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. */
Console.Clear();

double num, degree, natural; string num_str, degree_str; // задаем переменные

while (true) // бесконечный цикл
{
    
    Console.WriteLine("Введите число: ");
    num_str = Console.ReadLine();
    if (num_str == "Q") break; // остановка цикла
    if (!double.TryParse(num_str, out num)) // проверка на ввод числа
    {
        Console.WriteLine("Вы ввели не число!");
    }
    num = double.Parse(num_str);

    Console.WriteLine("Введите степень: ");
    degree_str = Console.ReadLine();
    if (!double.TryParse(degree_str, out degree))
    {
        Console.WriteLine("Вы ввели не число!");
    }
    degree = double.Parse(degree_str);

    natural = Math.Pow(num, degree); // возведение в степень
    Console.WriteLine("Натуральная степень числа {0} будет {1}", num, natural);

}
