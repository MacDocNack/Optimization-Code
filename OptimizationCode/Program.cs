using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";
        Dictionary<string, int> wordCounts = WordFrequency(text);

        foreach (var item in wordCounts)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }

    static Dictionary<string, int> WordFrequency(string text)
    {
        string[] words = text.ToLower().Split(' '); // Сразу приравниваем строку к нижнему регистру, вместо использования ToLower в цикле
        Dictionary<string, int> result = new Dictionary<string, int>();

        // Использование foreach для удобного взаимодействия с элементами
        foreach (var item in words)
        {
            if (result.ContainsKey(item))
            {
                result[item] += 1; // Изменение значения без ненужного присваивания переменной
            }
            else
            {
                result.Add(item, 1);
            }
        }

        return result; // Избавление от второго списка
    }
}