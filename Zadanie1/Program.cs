//Объявляем массив и его размеры
const int n = 5;
const int k = 3;
const int l = 4;
int[] A = new int[n];
int[,] B = new int[k, l];

//Вводим значения одномерного массива с клавиатуры
Console.WriteLine("Введите значения одномерного массива с клавиатуры: ");
for (int i = 0; i < n; i++)
{
    A[i] = Convert.ToInt32(Console.ReadLine());
}

//Выводим значения одномерного массива на экран
Console.Write("A: ");
foreach (int iter in A)
{
    Console.Write(iter + " ");
}
Console.WriteLine();

//Определяем значения двумерного массива случайным способом
Console.WriteLine("Определяем значения двумерного массива случайным способом: ");
Random rand1 = new Random();
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < l; j++)
    {
        B[i, j] = rand1.Next(0, 1000) / 100;
    }
}

//Выводим значения двумерного массива на экран
Console.WriteLine("B: ");
for (int i = 0; i < k; i++)
{
    for (int j = 0; j < l; j++)
    {
        Console.Write(B[i, j] + "\t");
    }
    Console.WriteLine();
}

int min = A[0];
int max = A[0];
int sum = 0;
int multi = 1;
int sumEven = 0;
int sumOddColumn = 0;

int m = 0;

foreach (int iter in A)
{
    if (iter < min)
    {
        min = iter;
    }
    if (iter > max)
    {
        max = iter;
    }
    sum += iter;
    multi *= iter;
    if (m % 2 == 0)
    {
        sumEven += iter;
    }
    m++;
}

for (int i = 0; i < k; i++)
{
    for (int j = 0; j < l; j++)
    {
        if (B[i, j] < min)
        {
            min = B[i, j];
        }
        if (B[i, j] > max)
        {
            max = B[i, j];
        }
        sum += B[i, j];
        multi *= B[i, j];

        if (j % 2 != 0)
        {
            sumOddColumn += B[i, j];
        }
    }
}
Console.WriteLine("Min = " + min);
Console.WriteLine("Max = " + max);
Console.WriteLine("Sum = " + sum);
Console.WriteLine("multi = " + multi);
Console.WriteLine("sumEven = " + sumEven);
Console.WriteLine("sumOddColumn = " + sumOddColumn);
