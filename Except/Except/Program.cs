using System;
using System.Collections.Generic;
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
                List<int> nums = new List<int>();

                for (int i = 0; i < numString.Length; i++)
                {
                    int num;
                    if (Int32.TryParse(numString[i], out num))
                        nums.Add(num);

                    //try
                    //{
                    //    int num = Int32.Parse(numString[i]);
                    //    nums.Add(num);
                    //}
                    //catch (Exception) 
                    //{
                    //    Console.WriteLine("В массиве есть не число");
                    //}
                }

                

                return nums.ToArray();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Не удалось считать содержимое файла {path}");
                return new int[0];
            }
        }
                        
    }
}
