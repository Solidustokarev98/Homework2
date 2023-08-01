//Объявляем массив и его размеры
using System.Drawing;

const int k = 5;
const int l = 5;

int[,] Arr = new int[k, l];

//Определяем значения двумерного массива случайным способом
Console.WriteLine("Определяем значения двумерного массива случайным способом: ");
Random rand1 = new Random();
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < l; j++)
    {
        Arr[i, j] = rand1.Next(-100, 100);
    }
}

//Выводим значения двумерного массива на экран
Console.WriteLine("Значения массива: ");
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < l; j++)
    {
        Console.Write(Arr[i, j] + "\t");
    }
    Console.WriteLine();
}

int min = Arr[0,0];
int max = Arr[0,0];
int sum = 0;
bool isBetween = false;
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < l; j++)
    {
        if (Arr[i, j] < min)
        {
            min = Arr[i, j];
        }
        if (Arr[i, j] > max)
        {
            max = Arr[i, j];
        }
    }
}

for (int i = 0; i < k; i++)
{
    for (int j = 0; j < l; j++)
    {
        if (Arr[i, j] == min || Arr[i, j] == max)
        {
            if (isBetween)
            {
                isBetween = false;
            }
            else
            {
                isBetween = true;
            }
        }
        else if (isBetween)
        {
            sum += Arr[i, j];
        }
    }
}

Console.WriteLine($"Сумма элементов между минимальным ({min}) и максимальным ({max}) элементами равна {sum}");