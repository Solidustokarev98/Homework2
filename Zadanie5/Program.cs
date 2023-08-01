Console.WriteLine("Введите арифметическое выражение (числа и операции через пробел): ");
string? str = Console.ReadLine();

string[] arrayOfString = str.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

double result = 0, num1 = 0;
bool plus = true;
for (int i = 0; i < arrayOfString.Length; i++)
{
    if (double.TryParse(arrayOfString[i], out num1))
    {
        if (plus)
            result = result + num1;
        else
            result = result - num1;
    }
    else
    {
        if (arrayOfString[i] == "+")
            plus = true;
        else
            plus = false;
    }
}
Console.WriteLine(result);