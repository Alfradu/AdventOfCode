﻿using System;
using System.IO;

namespace adventofcode
{
    class Utils
    {
        public static string[] ReadFromFile(string day)
        {
            return File.ReadAllText("C:\\Users\\Vildmusen\\source\\repos\\adventofcode\\resources\\day" + day+"input.txt").Split(',');
        }

        public static string[] ReadFromFileV2(string day)
        {
            return File.ReadAllText("C:\\Users\\Vildmusen\\source\\repos\\adventofcode\\resources\\day" + day + "input.txt").Split('\n');
        }

        public static int[] StringToIntList(string[] list)
        {
            int[] ints = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                ints[i] = Int32.Parse(list[i]);
            }
            return ints;
        }

        public static int Progress(int count, int pos, int length)
        {
            if (pos % (int)(length / 10) == 0)
            {
                Console.WriteLine(count * 10 + "% done");
                count++;
            }
            return count;
        }
    }
}
