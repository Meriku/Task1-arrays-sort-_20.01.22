using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_20._01._22
{
    internal class arrayB
    {

        public static int[] GetNewArrayB () // создаем новый масив В из шести элементов
        {
            int[] B = new int[6];
            var rnd = new Random(66);
            var i = 0;

            while (i < B.Length)
            {
                B[i] = rnd.Next(-10, 10);
                i++;
            }

            return B;
        }



        public static int GetSumOfPositiveNum(int[] array)
        //считаем сумму всех положительных элементов массива
        //которые делятся на 3 без остатка
        {
            var i = 0;
            var result = 0;

            while (i < array.Length)
            {

                if (array[i] > 0 && (array[i] % 3 == 0)) //если положительное и делится без остатка
                {
                    result += array[i];                 //добавляем к результату
                }

                i++;

            }

            return result;                              
            // возвращаем сумму положительных элементов которые делятся на 3 без остатка

        }




    }



}
