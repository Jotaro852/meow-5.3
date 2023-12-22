using System;
using System.IO;
using System.Linq;
class work_5_3
{
    static void Main()
    {
        string[] use = File.ReadAllLines("numsTask3.txt"); // чтение данных из файла и запись в массим
        int[] chosenUse = use[0].Split(' ').Select(int.Parse).ToArray(); // разделяем строку проблеами, перобразуем в числа, кладём в массив 

        int minIndex = Array.IndexOf(chosenUse, chosenUse.Min()); // индекс миниального знач
        double averageBeforeMin = chosenUse.Take(minIndex).Average(); // ср. арефметич до минимального

        Console.WriteLine("Среднее арифметическое до минимального числа: " + averageBeforeMin); // вывод
    }
}
