char[] alphabetArr = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

Console.Write("Введите фразу: ");
string phrase = Console.ReadLine();

char[] phraseArr = phrase.ToCharArray();
char[] finalArr = phraseArr;                    // Итоговый массив, шифрованная фраза
char[] finalArr2 = phraseArr;                   // Расшифровка

//Шифрование
for (var k = 0; k < phraseArr.Length; k++)
{
    var ch = phraseArr[k];
    for (int i = 0; i < alphabetArr.Length; i++)
    {                                          
        if (ch == alphabetArr[i])
        {                        
            int n = i + 3;
            if (n > 33)
            {
                n = n % 33;
            }

            finalArr[k] = alphabetArr[n];
        }
        if (ch == ' ')
        {
            finalArr[k] = ' ';
        }
    }
}
Console.WriteLine("Шифрую:");
foreach (char item in finalArr)
{
    Console.Write(item);
}

// Расшифровка
for (var q = 0; q < phraseArr.Length; q++)
{
    var chr = phraseArr[q];
    for (int r = 0; r < alphabetArr.Length; r++)
    {                                        
        if (chr == alphabetArr[r])
        {                      
            int m = r - 3;
            if (m < 0)
            {
                m = 33 + m;
            }

            finalArr2[q] = alphabetArr[m];
        }
        if (chr == ' ')
        {
            finalArr2[q] = ' ';
        }
    }
}

Console.WriteLine("\nРасшифровка:");
foreach (char item in finalArr2)
{
    Console.Write(item);
}