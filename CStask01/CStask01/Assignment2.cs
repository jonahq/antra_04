using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CStask01
{
    internal class Assignment2
    {
        private ArrayList arr;
        public Assignment2() { arr = new ArrayList(); }
        //Practice Arrays 01
        public void copy_arr()
        {
            int[] arr1 = new int[10];
            for (int i = 0; i < arr1.Length; i++) { arr1[i] = i; }
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++) { arr2[i] = arr1[i]; }

        }
        //Practice Arrays 02
        public void listManager(string input)
        {
            String[] parsed_input = input.Split(' ');
            switch (parsed_input[0])
            {
                case "+":
                    arr.Add(parsed_input[1]);
                    break;
                case "-":
                    arr.Remove(parsed_input[1]);
                    break;
                case "--":
                    arr.Clear();
                    break;
                default:
                    break;
            }
        }
        //Practice Arrays 03
        public int[] FindPrimesInRange(int startNum, int endNum)
        {
            int[] output = new int[endNum - startNum + 1];
            int count = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime) { output[count] = i; Console.WriteLine(i); }
                count++;
            }
            return output;
        }
        //Practice Arrays 04
        public int[] rotate(string input, int k)
        {
            string[] input_arr = input.Split(' ');
            int len = input_arr.Length;
            int[] input_int = input_arr.Select(input => int.Parse(input)).ToArray();
            int[] sum = new int[len];
            for (int i = 1; i <= k; i++)
            {
                int starter = len - i;
                for (int j = 0; j < len; j++)
                {
                    sum[j] += input_int[(starter + j) % len];
                }
            }
            foreach (int i in sum) { Console.Write(i); }
            Console.WriteLine();
            return sum;

        }
        //Practice Arrays 05
        public void longest(string input)
        {
            string[] input_arr = input.Split(' ');
            int len = input_arr.Length;
            int[] input_int = input_arr.Select(input => int.Parse(input)).ToArray();
            String token = "";
            String existing = "";
            int current = input_int[0];

            for (int i = 0; i < len; i++)
            {
                if (input_int[i] != current)
                {
                    token = input_arr[i];
                    current = input_int[i];
                }
                else
                {
                    token += input_arr[i];
                    if (token.Length > existing.Length) { existing = token; }
                }
            }
            Console.WriteLine(existing);
        }
        //Practice Arrays 07
        public void max_freq(string input)
        {
            string[] input_arr = input.Split(' ');
            Array.Sort(input_arr);
            int len = input_arr.Length;
            int[] input_int = input_arr.Select(input => int.Parse(input)).ToArray();
            String token = "";
            String existing = "";
            int current = input_int[0];

            for (int i = 0; i < len; i++)
            {
                if (input_int[i] != current)
                {
                    token = input_arr[i];
                    current = input_int[i];
                }
                else
                {
                    token += input_arr[i];
                    if (token.Length > existing.Length) { existing = token; }
                }
            }
            Console.WriteLine(existing);
        }
        //Practice Strings 01
        public void rev(string input)
        {
            char[] input_arr = input.ToCharArray();
            int len = input_arr.Length;
            string output = "";
            for (int i = len - 1; i > -1; i--)
            {
                output += input_arr[i];
            }
            Console.WriteLine(output);

        }

        //Practice Strings 02
        public void revWords(string input)
        {
            string[] input_arr = input.Split(' ');
            int len = input_arr.Length;
            string output = "";
            for (int i = len - 1; i > -1; i--)
            {
                output += input_arr[i] + " ";
            }
            Console.WriteLine(output);

        }

        public void palin(string input)
        {
            char[] input_arr = input.ToCharArray();
            ArrayList pal_arr = new ArrayList();
            string word = "";
            foreach (char elem in input_arr)
            {
                if (Char.IsLetter(elem)) { word += elem; }
                else if (word.Length > 0)
                {
                    char[] char_arr = word.ToCharArray();
                    if (char_arr[0] == char_arr[char_arr.Length - 1])
                    {
                        pal_arr.Add(word);
                        Console.Write(word + "  ");
                    }
                    word = "";
                }
            }
            Console.WriteLine();
        }
        public void website(string input)
        {
            string[] input1 = input.Split('/');
        }
    }
}
