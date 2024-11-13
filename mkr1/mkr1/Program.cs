using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Читання вхідного числа N з файлу INPUT.TXT
        int N = int.Parse(File.ReadAllText("INPUT.TXT"));

        int count = 0;

        // Перебираємо всі числа від 1 до N і перевіряємо умову
        for (int i = 1; i <= N; i++)
        {
            if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
            {
                count++;
            }
        }

        // Записуємо результат у файл OUTPUT.TXT
        File.WriteAllText("OUTPUT.TXT", count.ToString());
    }
}
