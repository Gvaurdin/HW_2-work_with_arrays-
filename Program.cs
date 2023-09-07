using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_work_with_arrays_
{
    internal class Program
    {
        static int[] Create_Array(int size, short mod)
        {
            if (size <= 0 || size > 20)
            {
                Console.WriteLine("Incorrect size array");
                return null;
            }
            else
            {
                int[] array = new int[size];
                Random rand = new Random();
                for (global::System.Int32 i = 0; i < array.Length; i++)
                {
                    if (mod == 0) array[i] = rand.Next(-20, 20);
                    else if (mod == 1) array[i] = rand.Next(10);
                }
                return array;
            }
        }
        static void Delete_Is_Zero(int[] array)
        {
            if (!array.Any())
            {
                Console.WriteLine("Array is empty!");
                return;
            }
            else
            {
                for (global::System.Int32 i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        for (global::System.Int32 j = i; j < array.Length - 1; j++)
                        {
                            array[j] = array[j + 1];
                        }
                        array[array.Length - 1] = -1;
                        i--;
                    }
                }
            }
        }
        static void Print_Array(int[] array)
        {
            if (!array.Any())
            {
                Console.WriteLine("Array is empty!");
                return;
            }
            else
            {
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
        static int[][] Create_Uneven_Array(int row, int col)
        {
            if (row <= 0 || row > 5 ||
                col <= 0 || col > 10)
            {
                Console.WriteLine("Incorrect size array");
                return null;
            }
            else
            {
                Random rand = new Random();
                int[][] array = new int[row][];
                for (global::System.Int32 i = 0; i < row; i++)
                {
                    array[i] = new int[rand.Next(2, col)];
                }
                for (global::System.Int32 i = 0; i < array.Length; i++)
                {
                    for (global::System.Int32 j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] = rand.Next(20);
                    }
                }
                return array;
            }
        }
        static void Print_Uneven_Array(int[][] array)
        {
            if (!array.Any())
            {
                Console.WriteLine("Array is empty!");
                return;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (global::System.Int32 j = 0; j < array[i].Length; j++)
                    {
                        Console.Write(array[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static int Count_Keys_Number(int[][] array, int key)
        {
            if (!array.Any())
            {
                Console.WriteLine("Array is empty!");
                return 0;
            }
            else if (key <= 0 || key > 20)
            {
                Console.WriteLine("Incorrect key...");
                return 0;
            }
            else
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    for (global::System.Int32 j = 0; j < array[i].Length; j++)
                    {
                        if (array[i][j] == key) count++;
                    }
                }
                return count;
            }
        }

        static int[,] Create_twoDimensional_Array(int row, int col)
        {
            if (row <= 0 || row > 5 ||
                col <= 0 || col > 10)
            {
                Console.WriteLine("Incorrect size array");
                return null;
            }
            else
            {
                Random rand = new Random();
                int[,] array = new int[row, col];
                for (global::System.Int32 i = 0; i < row; i++)
                {
                    for (global::System.Int32 j = 0; j < col; j++)
                    {
                        array[i, j] = rand.Next(20);
                    }
                }
                return array;
            }
        }
        static void Print_twoDimensional_Array(int[,] array)
        {
            if (array == null)
            {
                Console.WriteLine("Array is empty!");
                return;
            }
            else
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (global::System.Int32 j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Replacing_Columns(int[,] array, int col_1, int col_2)
        {
            if (array == null)
            {
                Console.WriteLine("Array is empty!");
                return;
            }
            else
            {
                int tmp;
                col_1--; col_2--;
                if(col_1 < 0 || col_1 >  array.GetLength(1)||
                    col_2 < 0 || col_2 > array.GetLength(1))
                {
                    Console.WriteLine("Incorrect value column 1 or column 2");
                    return;
                }
                else
                {
                    for (global::System.Int32 i = 0; i < array.GetLength(0); i++)
                    {
                        tmp = array[i, col_1];
                        array[i, col_1] = array[i, col_2];
                        array[i, col_2] = tmp;
                    }
                }
            }
        }
        static void Menu()
        {
            char menu; bool flag = false; int size = 0, row = 0, col = 0;
            while (flag == false)
            {
                Console.Clear();
                Console.WriteLine("\t\tArray editor\n" +
                    "\tEnter 1 to delete zero from array\n" +
                    "\tEnter 2 to sort array(negative -> positive)\n" +
                    "\tEnter 3 to find count keys in uneven-array\n" +
                    "\tEnter 4 to replace columns in two - dimensional array\n" +
                    "\tEnter 5 to exit\n" +
                    "Your action : ");
                menu = char.Parse(Console.ReadLine());
                while (menu != '1' && menu != '2' &&
                    menu != '3' && menu != '4' && menu != '5')
                {
                    Console.WriteLine("Error input comand\n" +
                        "Try input comand again : ");
                }
                switch (menu)
                {
                    case '1':
                        {
                            Console.Clear();
                            Console.WriteLine("Enter to size array(from 5 to 20) : ");
                            size = int.Parse(Console.ReadLine());
                            if (size < 5 || size > 20)
                            {
                                Console.WriteLine("Incorrect input size");
                                Console.ReadKey();
                            }
                            else
                            {
                                int[] array = Create_Array(size,1);
                                Console.WriteLine("Your default array : ");
                                Print_Array(array);
                                Console.WriteLine("\n=============== Modified array======================\n");
                                Delete_Is_Zero(array);
                                Print_Array(array);
                                Console.ReadKey();
                            }
                        }
                        break;
                    case '2':
                        {
                            Console.Clear();
                            Console.WriteLine("Enter to size array(from 5 to 20) : ");
                            size = int.Parse(Console.ReadLine());
                            if (size < 5 || size > 20)
                            {
                                Console.WriteLine("Incorrect input size");
                                Console.ReadKey();
                            }
                            else
                            {
                                int[] array = Create_Array(size,0);
                                Console.WriteLine("Your default array : ");
                                Print_Array(array);
                                Console.WriteLine("\n=============== Negative ->" +
                                    " Positive numbers to array======================\n");
                                Array.Sort(array);
                                Print_Array(array);
                                Console.ReadKey();
                            }
                        }
                        break;
                    case '3':
                        {
                            Console.Clear();
                            Console.WriteLine("Enter to count rows for array(max 5) : ");
                            row = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter to count cols for random creating uneven-array(max 5) : ");
                            col = int.Parse(Console.ReadLine());
                            if (row <= 0 || row > 5 ||
                                col <= 0 || col > 5)
                            {
                                Console.WriteLine("Incorrect input count rows or count cols");
                                Console.ReadKey();
                            }
                            else
                            {
                                int[][] array = Create_Uneven_Array(row, col);
                                Console.WriteLine("Your uneven-array : ");
                                Print_Uneven_Array(array);
                                Console.WriteLine("Enter to number-key to lern count this key in array : ");
                                int key = int.Parse(Console.ReadLine());
                                if (key < -20 || key > 20)
                                {
                                    Console.WriteLine("Incorrect input key-number");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    int count = Count_Keys_Number(array, key);
                                    if (count == 0)
                                    {
                                        Console.WriteLine("Not find to select key in array");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Count find in arrasy select keys_number : " + count);
                                    }
                                    Console.ReadKey();
                                }
                            }
                        }
                        break;
                    case '4':
                        {
                            Console.Clear();
                            Console.WriteLine("Enter to count rows for array(max 5) : ");
                            row = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter to count cols for array(max 5) : ");
                            col = int.Parse(Console.ReadLine());
                            if (row <= 0 || row > 5 ||
                                col <= 0 || col > 5)
                            {
                                Console.WriteLine("Incorrect input count rows or count cols");
                                Console.ReadKey();
                            }
                            else
                            {
                                int[,] array = Create_twoDimensional_Array(row, col);
                                Console.WriteLine("Your two - dimensional array : ");
                                Print_twoDimensional_Array(array);
                                int col_1 = 0, col_2 = 0;
                                Console.WriteLine("Enter column indexes to replace :");
                                Console.WriteLine("Column 1 : ");
                                col_1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Column 2 : ");
                                col_2 = int.Parse(Console.ReadLine());
                                Console.WriteLine("\n=================== Modified two-dimensional array ===========\n");
                                Replacing_Columns(array, col_1,col_2);
                                Print_twoDimensional_Array(array);
                                Console.ReadKey();
                            }
                        }
                        break;
                    case '5':
                        {
                            Console.Clear();
                            Console.WriteLine("Exit from program...");
                            flag = true;
                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
    }
}
