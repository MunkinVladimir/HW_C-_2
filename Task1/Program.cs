// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
// using System;

// class Program
// {
//     static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("Введите целое число или 'q' для выхода:");
//             string input = Console.ReadLine();

//             if (input == "q")
//             {
//                 break;
//             }

//             int number;
//             if (int.TryParse(input, out number))
//             {
//                 if (GetSumOfDigits(number) % 2 == 0)
//                 {
//                     break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Некорректный ввод. Попробуйте снова.");
//             }
//         }
//     }

//     static int GetSumOfDigits(int number)
//     {
//         int sum = 0;
//         while (number != 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }
//         return sum;
//     }
// }


// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// using System;

// class Program
// {
//     static void Main()
//     {
//         Random random = new Random();
//         int[] numbers = new int[10]; // Массив из 10 элементов

//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = random.Next(100, 1000);
//         }

//         int countEvenNumbers = 0;
//         foreach (int num in numbers)
//         {
//             if (num % 2 == 0)
//             {
//                 countEvenNumbers++;
//             }
//         }

//         Console.WriteLine("Сгенерированный массив:");
//         foreach (int num in numbers)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine();
//         Console.WriteLine($"Количество четных чисел в массиве: {countEvenNumbers}");
//     }
// }

// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый 
// элемент станет последним, второй – предпоследним и т.д.)
using System;

class Program
{
    static void Main()
    {
        int[] array = { 4, 34, 4, 4, 2, 89, 87 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        ReverseArray(array);

        Console.WriteLine("Перевернутый массив:");
        PrintArray(array);
    }

    static void ReverseArray(int[] arr)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {

            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
