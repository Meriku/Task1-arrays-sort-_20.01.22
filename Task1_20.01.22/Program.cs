using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// В целочисленном массиве B[6] 
// определить сумму положительных элементов, 
// делящихся на 3 без остатка и поставить ее 
// на место максимального элемента массива A[5].



namespace Task1_20._01._22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var newarrayB = arrayB.GetNewArrayB(); //создаем новый массив В
            Console.WriteLine($"Новый массив [В]: [{String.Join(", ", newarrayB)}]");

            var newarrayА = arrayA.GetNewArrayA(); //создаем новый массив А
            Console.WriteLine($"Новый массив [А]: [{String.Join(", ", newarrayА)}]");

            var SumOfPositiveNum = arrayB.GetSumOfPositiveNum(newarrayB);  //выводим результат GetSumOfPositiveNum
            Console.WriteLine($"\nСумма всех положительных чисел массива [В] которые без остатка делятся на 3: " +
                $"{SumOfPositiveNum}");

            var TheBiggestNumer = arrayA.GetTheBiggestNumber(newarrayА);  //выводим результат GetTheBiggestNumber
            Console.WriteLine($"Наибольшее число массива [А] это: {newarrayА[TheBiggestNumer]}, " +
                $"его порядковый номер {TheBiggestNumer+1}"); //для лучшего понимания с консоли, добавим 1 к порядковому номеру в тексте

            Console.WriteLine("\nПодставим сумму всех положительных чисел массива [B] которые без остатка делятся на 3 \n" +
                "на место наибольшего числа массива [А]");

            newarrayА[TheBiggestNumer] = SumOfPositiveNum;

            Console.WriteLine($"Получим следующий массив: [{String.Join(", ", newarrayА)}]");

            Console.ReadLine();


           // задание было выполнено без поиска готовых алгоритмов решений



        }
    }
}
