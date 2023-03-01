using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetUnique(new int[] {2,2,1,1,3}));
        }






        public static bool IsPangram(string str)
        {
            string Str = str;
            char[] CharsEN = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < str.Length; i++) { Str.Remove(CharsEN[i]); }
            char[] Symbols = Str.ToCharArray();
            for (int i = 0; i < CharsEN.Length; i++) { Console.WriteLine("asd"); }

            return true;
        }




        public static int GetUnique(IEnumerable<int> numbers)
        {
            int num = 0;
            int[] Numbers = numbers.ToArray();
            for (int i = 0; i < Numbers.Count(); i++)
            {
                
            }
            
            return num;


        }





        public static string Likes(string[] name)
        {
            switch (name.Length)
            {
                case 0: return "no one likes this";
                case 1: return $"{name[0]} likes this";
                case 2: return $"{name[0]} and {name[1]} like this";
                case 3: return $"{name[0]}, {name[1]} and {name[2]} like this";
                default: return $"{name[0]}, {name[1]} and {name.Length-2} others like this";
            }
        }





        public static int SumIntervals((int, int)[] intervals)
        {
            int sum = 0;
            foreach ((int, int) tuple in intervals)
            {
                sum += Math.Abs(tuple.Item2 - tuple.Item1);
            }
            return sum;
        }





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





        public static long FindNextSquare(long num)
        {
            long i = (long)Math.Sqrt(num);
            if (i * i == num) { return (i + 1) * (i + 1); }
            return -1;
        }





        public static int GetVowelCount(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }

    }
}

