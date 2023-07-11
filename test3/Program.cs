Console.Clear();
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int result = Numbersum(number);
Console.WriteLine(result);
int Numbersum(int num)
{
     int sum = 0;
    while(num > 0)
    {
        num = num % 10;
        sum = sum + num;
        return sum;
    }
}