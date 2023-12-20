int size = 10;

double[] arr = new double[size];

Random rand = new Random();
for (int i = 0; i < size; i++)
{
    arr[i] = rand.NextDouble() * 100;
}

Console.WriteLine("Массив:");
foreach(double num in arr)
{
    Console.Write(num + " ");
}
Console.WriteLine();

double max = arr[0];
double min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < min)
        min = arr[i];
    else if (arr[i] > max)
        max = arr[i];
}
Console.WriteLine("Разница между максимальным и минимальным значением массива: " + (max - min));
