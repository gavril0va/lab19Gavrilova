Console.Write("Введите строку: ");
string text = Console.ReadLine() ?? "";

Console.WriteLine("Анализ строки");
Console.WriteLine($"Исходная строка: [{text}]");
Console.WriteLine($"Длина: {text.Length}");
Console.WriteLine($"Букв: {CountLetters(text)}");
Console.WriteLine($"Цифр: {CountDigits(text)}");
Console.WriteLine($"Пробелов: {CountCharacter(text, ' ')}");
Console.WriteLine($"Слов: {CountWords(text)}");
Console.WriteLine($"Без пробелов по краям: [{text.Trim()}]");
Console.WriteLine($"Верхний регистр: [{text.ToUpper()}]");
Console.WriteLine($"Замена пробелов: [{text.Replace(' ', '_')}]");

Console.Write("Введите один символ для поиска: ");
char target = Convert.ToChar(Console.ReadLine());
int index = FindCharacterIndex(text, target);

if (index != -1)
{
    Console.WriteLine($"Первый индекс: {index}");
}
else
{
    Console.WriteLine("Символ не найден");
}

int CountLetters(string text)
{
    int count = 0;
    foreach (char symbol in text)
    {
        if (char.IsLetter(symbol))
        {
            count++;
        }
    }
    return count;
}

int CountDigits(string text)
{
    int count = 0;
    foreach (char symbol in text)
    {
        if (char.IsDigit(symbol))
        {
            count++;
        }
    }
    return count;
}

int CountCharacter(string text, char target)
{
    int count = 0;
    foreach (char symbol in text)
    {
        if (symbol == target)
        {
            count++;
        }
    }
    return count;
}

int CountWords(string text)
{
    string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}

int FindCharacterIndex(string text, char target)
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            return i;
        }
    }
    return -1;
}

//2
int CountVowels(string text)
{
    string vowels = "аеёиоуыэюя";
    int count = 0;
    
    foreach (char symbol in text)
    {
        char lowerSymbol = char.ToLowerInvariant(symbol);
        if (vowels.Contains(lowerSymbol))
        {
            count++;
        }
    }
    
    return count;
}

Console.WriteLine($"Гласных букв: {CountVowels(text)}");
