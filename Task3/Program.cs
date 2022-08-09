/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите длину массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int[] arr = GetArray(elementsCount);
PrintArray(arr);

int minInd = 0;
int maxInd = 0;
int res = 0;

for (int i = 1; i < elementsCount; i++)
{
    while (arr[maxInd] < arr[i])
    {
        maxInd = i;
    }
    while (arr[minInd] > arr[i])
    {
        minInd = i;
    }
}

res = arr[maxInd] - arr[minInd];
Console.WriteLine(res);

