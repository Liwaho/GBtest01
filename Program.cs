// Массив из строк -> массив из строк, длина которых меньше или равна тём символам.

Console.WriteLine("Сколько элементов в массиве? ");
int wordsCount = int.Parse(Console.ReadLine());
if (wordsCount > 10)
{
    Console.WriteLine("Слишком много элементов! Нужно не больше 10!");
    return;
}
string[] words = new string[wordsCount];
int newWordsCount = 0;
Console.WriteLine("Введите элементы массива.");
for (int i = 0; i < wordsCount; i++)
{
    Console.WriteLine(i + " элемент: ");
    words[i] = Console.ReadLine();
}

Console.WriteLine("Исходный массив: ");
Print(words);
Console.WriteLine("");
Count(words);
Console.WriteLine("Элементов длиной меньше или равной трём: " + newWordsCount);

string[] newWords = new string[newWordsCount];
int ni = 0;
for (int n = 0; n < wordsCount; n++)
    {
        int length = words[n].Length;
        
        if (length < 4)
        {   
            newWords[ni] = words[n];
            ni++;
        }
    }

Console.WriteLine("Новый массив: ");
Print(newWords);

void Count(string[] array)
{
    foreach (string element in array)
    {
        int length = element.Length;
        if (length < 4)
        {   
            newWordsCount++;
        }
    }
}

void Print(string[] el)
{
    int count = el.Length;
    int pos = 0;
    while (pos<count)
    {
        Console.Write(el[pos] + " ");
        pos++;
    }
}