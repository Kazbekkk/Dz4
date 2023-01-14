/* Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
 */

/* string a = "321";
int s = a.Length;
Console.WriteLine(s); */
Console.Clear();

int num, leng, sum, i, remains; string num_str; // обьявление переменных и их тип данных


while (true)
{
    Console.WriteLine("Введите число и получите сумму цифр в числе: ");
    num_str = Console.ReadLine(); // ввод данных
    if (!int.TryParse(num_str, out num)) // првоерка на ввод числа
    {
        Console.WriteLine("Вы ввели не число!");
    }
    else break;
}

leng = num_str.Length; // получение колличества символов для использовния в цикле 
num = int.Parse(num_str); // преобразование  string в integer
sum = 0;
remains = 0;

if (num < 0) leng--; // проверка на положительное число 

for (i = 0; i < leng; i++)
{
    remains = num % 10;
    sum += remains;
    num /= 10;
}


Console.WriteLine("Сумма цифр в числе {0} равна = {1}", num_str, sum);





