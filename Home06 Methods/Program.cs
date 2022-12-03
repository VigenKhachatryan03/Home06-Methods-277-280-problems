using System;

namespace Home06_Methods
{
    class Program
    {

        static void PrintArr(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((char)arr[i] + " ");
            }
            Console.WriteLine();
        }
        static char[] T277Char(char[] arr, char symbol)
        {
            Console.WriteLine("T277___________________________________");
            Console.WriteLine();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != symbol)
                {
                    count++;
                }

            }
            Console.WriteLine($"new_array Lenght is {count}");
            int point = 0;
            char[] new_arr = new char[count];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != symbol)
                {
                    new_arr[point] = (char)arr[i];
                    point++;
                }

            }
            return new_arr;
        }
        static char[] T278Char(char[] arr)
        {
            Console.WriteLine("T278___________________________________");
            Console.WriteLine();
            char[] new_array = new char[arr.Length % 2 == 0 ? arr.Length / 2:arr.Length/2+1] ;
            int point = 0;
            for (int i = 1; i < arr.Length; i += 2)
            {
                new_array[point] = arr[i];
                point++;
            }

          
            return new_array;
        }
        static char[] T279Char(char[] arr, char symbol)
        {
            Console.WriteLine("T279___________________________________");
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > (int)symbol)
                {
                    count++;
                }

            }
            Console.WriteLine($"new_array Lenght is {count}");
            char[] new_arr = new char[count];

            int point = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > (int)symbol)
                {
                    new_arr[point] = (char)arr[i];
                    point++;
                }

            }
            return new_arr;
        }
        static char[] T280Char(char[] arr, char symbol)
        {
            Console.WriteLine("T280___________________________________");
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == symbol)
                {
                    count++;
                }

            }
            Console.WriteLine($"new_array Lenght is {arr.Length + count}");
            char[] new_arr = new char[arr.Length + count];

            int point = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == symbol)
                {
                    new_arr[point] = (char)arr[i];
                    point++;
                    new_arr[point] = (char)arr[i];
                    point++;
                }
                else
                {
                    new_arr[point] = (char)arr[i];
                    point++;
                }

            }
            return new_arr;
        }




        static void Main(string[] args)
        {
            char[] array = new char[] { 'b', 'b', 'b', 'c', 'e', '2', 'e', 'r', '6', 'b', 'u', 'l', 'o', 'k', 'o', 'b', 'a', 'b', 'u', 'l', 'o', 'k', 'o', 'l', 'b' };
            PrintArr(array);
            Console.WriteLine($"array Lenght is {array.Length}");
            Console.WriteLine();

            PrintArr(T277Char(array, 'b'));
            Console.WriteLine();
            PrintArr(T278Char(array));
            Console.WriteLine();
            PrintArr(T279Char(array, 'k'));
            Console.WriteLine();
            PrintArr(T280Char(array, 'k'));

        }
    }
}
