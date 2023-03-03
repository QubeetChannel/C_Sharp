using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }





        // НЕ РЕШЕНО
        // https://www.codewars.com/kata/550f22f4d758534c1100025a
        public static string[] dirReduc(string[] arr)
        {
            string[] str = { "hello", "world" };
            int[] Way = { 0, 0 };
            foreach (string i in arr) {
                switch (i) {
                    case "NORTH": Way[0] -= 1; break;
                    case "SOUTH": Way[0] += 1; break;
                    case "WEST": Way[1] -= 1; break;
                    case "EAST": Way[1] += 1; break;
            }}
            for (int i = 0; i < Way.Length; i++)
            {
                while (Way[i] != 0)
                {

                }
            }
            Console.Write($"{Way[0]}, {Way[1]} ");
            return str;
        }





        // НЕ РЕШЕНО
        //
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int num = 0;
            int[] Numbers = numbers.ToArray();
            for (int i = 0; i < Numbers.Count(); i++)
            {
                
            }
            
            return num;


        }





        // НЕ РЕШЕНО
        // https://www.codewars.com/kata/52b7ed099cdc285c300001cd
        public static int SumIntervals((int, int)[] intervals)
        {
            int sum = 0;
            foreach ((int, int) tuple in intervals)
            {
                sum += Math.Abs(tuple.Item2 - tuple.Item1);
            }
            return sum;
        }





        // РЕШЕНО
        // https://www.codewars.com/kata/545cedaa9943f7fe7b000048
        public static bool IsPangram(string str)
        {
            char[] CharsEN = "abcdefghijklmnopqrstuvwxyz".ToArray();

            foreach (char C in CharsEN)
            {
                if (str.Contains(C) || str.Contains(char.ToUpper(C))) { continue; }
                return false;
            }
            return true;
        }





        // РЕШЕНО
        // https://www.codewars.com/kata/55466989aeecab5aac00003e
        public static List<int> sqInRect(int lng, int wdth)
        {
            List<int> result = new List<int> { };

            if (lng != wdth)
            {
                int[] Array = { lng, wdth };
                while (Array[0] != 0 && Array[1] != 0)
                {
                    int min = Math.Min(Array[0], Array[1]);
                    Array[0] = Math.Max(Array[0], Array[1]) - min;
                    Array[1] = min;
                    result.Add(min);
                }
                return result;
            }
            return null;
        }





        // РЕШЕНО
        // https://www.codewars.com/kata/5266876b8f4bf2da9b000362
        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0: return "no one likes this";
                case 1: return $"{name[0]} likes this";
                case 2: return $"{name[0]} and {name[1]} like this";
                case 3: return $"{name[0]}, {name[1]} and {name[2]} like this";
                default: return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }





        // РЕШЕНО
        // https://www.codewars.com/kata/578553c3a1b8d5c40300037c
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            string num = "";
            foreach (int i in BinaryArray) { num += $"{i}"; }
            return Convert.ToInt32(num, 2);
        }

        public static int binaryArrayToNumber2(int[] BinaryArray)
        {
            return Convert.ToInt32(string.Join("", BinaryArray), 2);
        }





        // РЕШЕНО
        // https://www.codewars.com/kata/541c8630095125aba6000c00
        public static int DigitalRoot(long n)
        {
            while ($"{n}".Length > 1)
            {
                int sum = 0;
                foreach (char c in $"{n}") sum += int.Parse($"{c}");
                n = sum;
            }
            return (int)n;
        }





        // РЕШЕНО
        // https://www.codewars.com/kata/5287e858c6b5a9678200083c
        public static bool Narcissistic(int value)
        {
            double result = 0;
            string StrValue = Convert.ToString(value);

            for (int i = 0; i < StrValue.Length; i++)
            {
                result += Math.Pow(Char.GetNumericValue(StrValue[i]), StrValue.Length);
            }
            if (result == value) { return true; }

            return false;
        }





        // РЕШЕНО
        // https://www.codewars.com/kata/56269eb78ad2e4ced1000013
        public static long FindNextSquare(long num)
        {
            long i = (long)Math.Sqrt(num);
            if (i * i == num) { return (i + 1) * (i + 1); }
            return -1;
        }





        // РЕШЕНО
        // https://www.codewars.com/kata/54ff3102c1bad923760001f3
        public static int GetVowelCount(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }
    }
}

