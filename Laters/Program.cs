﻿namespace laters;
class Program
{
    static void Main(string[] args)
    {
        string str = "Для объединения строк также может использоваться метод";
        
        Latters(str, 'д', 'к');
    }
    static void Latters(string str, char firstLater, char LastLater)
    {
        str = str.ToLower();
        int first = 0;
        int last = 0;
        string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        foreach (string word in words)
        {
            if (word.StartsWith(firstLater))
                first++;
            else if (word.EndsWith(LastLater))
                last++;
        }
        Console.WriteLine($"Слов начинающихся с буквы {firstLater} {first}, а заканчивающихся на букву {LastLater} {last}");
    }
}