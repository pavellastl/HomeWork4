Console.Clear();
Console.WriteLine("Введите целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число");

int number2 = Convert.ToInt32(Console.ReadLine());

int factorial = number1;
for (int i = 1; i < number2; i++)
{
    
    factorial = factorial * number1;

}
Console.WriteLine($"{number1} в степени {number2} = {factorial}", " ");



