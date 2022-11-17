// Массив из строк -> массив из строк, длина которых меньше или равна тём символам.
Console.WriteLine("Сколько элементов в массиве? ");
int wordsCount = int.Parse(Console.ReadLine());
string[] words = new string[wordsCount];
int newWordsCount = 0;
string[] newWords = new string[newWordsCount];
Console.WriteLine("Введите элементы массива.");
for (int i = 0; i < wordsCount; i++)
{
    Console.WriteLine(i + " элемент: ");
    words[i] = Console.ReadLine();
}

