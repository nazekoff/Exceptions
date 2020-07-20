using System;
using System.IO;

namespace Except
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = GetRowCount("C:/Path/file.txt");
            Console.WriteLine(r);
        }

        static int GetRowCount(string path)
        {
            try
            {
                var rows = File.ReadAllLines(path);
                return rows.Length;
            }
            catch (FileNotFoundException ex)
            {
                //Console.WriteLine($"Файл {path} не был найден. Alarm!");
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Функция была вызвана с пустым аргументом. Так делать не хорошо.");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Не получилось считать файл");
                return 0;
            }
        }
    }
}
