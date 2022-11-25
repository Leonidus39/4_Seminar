/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

// Функция подсчета цифр в числе
Console.WriteLine("Введите число  ");
int number = Convert.ToInt32(Console.ReadLine());
int lengh = quantity(number);
SummaNumbers(number, lengh);

int quantity(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SummaNumbers(int n, int lengh)
{
    int sum = 0;
    for (int i = 1; i <= lengh; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
