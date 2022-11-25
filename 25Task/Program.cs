/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243
2, 4 -> 16
 */
Console.WriteLine("Введите число А ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int number2 = Convert.ToInt32(Console.ReadLine());
Degree(number1, number2);
void Degree (int a, int b)
{
    int result = 1;
for (int i = 0; i < b; i++)
{
    result = result*a;
}Console.WriteLine(result);

}
