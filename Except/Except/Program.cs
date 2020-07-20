using System;
using System.IO;

namespace Except
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var nums = GetArrayFromFile("path.txt");
        }


        static int[] GetArrayFromFile(string path)
        {
            try
            {
                string content = File.ReadAllText(path);
                var numString = content.Split(" ");
                int[] nums = new int[numString.Length];

                for (int i = 0; i < numString.Length; i++)
                {
                    try
                    {
                        int num = Int32.Parse(numString[i]);
                        nums[i] = num;
                    }
                    catch (Exception) 
                    {
                        Console.WriteLine("В массиве есть не число");
                    }
                }
                return nums;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Не удалось считать содержимое файла {path}");
                return new int[0];
            }
        }
                        
    }
}
