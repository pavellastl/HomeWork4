Console.Clear();
int[] array = new int[8];

FillArray(array);
PrintArray(array);

void FillArray(int[] arr)
{
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1,100);
}
}

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write(arr[i] + " ");
}
}