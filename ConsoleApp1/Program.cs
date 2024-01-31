using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "С:\\Users\\tyr1k_qq\\Desktop\\test.txt";

        List<string> LissTTest = new List<string>();

        // Считываем содержимое файла и сохраняем его в список
        try
        {
            LissTTest = File.ReadAllLines(path).ToList();
        }
        catch (IOException ex)
        {
            Console.WriteLine("Произошла ошибка при чтении файла: " + ex.Message);
            return;
        }

        // Выводим содержимое списка
        foreach (string строка in LissTTest)
        {
            Console.WriteLine(строка);
        }
    }
}