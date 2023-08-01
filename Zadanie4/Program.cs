// Объявляем массивы
int[,] arr1 = new int[5, 5];
int[,] arr2 = new int[5, 5];

// Заполняем массивы случайными числами
Random rand = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)  arr1[i, j] = rand.Next(20);
}    
    
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)  arr2[i, j] = rand.Next(20);
}
    
// Выводим массивы на экран
Console.WriteLine("Массив 1:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(arr1[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nМассив 2:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(arr2[i, j] + "\t");
    }
    Console.WriteLine();
}

// Умножение на число
Console.WriteLine("\nУмножим первый массив на два:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write((arr1[i, j] * 2) + "\t");
    }
    Console.WriteLine();
}

// Сложение матриц
Console.WriteLine("\nСумма первого и второго массивов:");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write((arr1[i, j] + arr2[i, j]) + "\t");

    }
    Console.WriteLine();
}

// Умножение матриц
Console.WriteLine("Произведение:");
int[,] arr3 = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        for (int k = 0; k < 5; k++)
        {
            arr3[i, j] += arr1[i, k] * arr2[k, j];
        }
    }
}

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(arr3[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.ReadKey();
