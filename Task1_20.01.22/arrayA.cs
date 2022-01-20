using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_20._01._22

{
    internal class arrayA
    {

        public static int[] GetNewArrayA() //создаем новый массив А
        {
            int[] A = new int[5];
            var rnd = new Random(55);
            var i = 0;

            while (i < A.Length)
            {
                A[i] = rnd.Next(-10, 10);
                i++;
            }

            return A;
        }


        public static int GetTheBiggestNumber(int[] array) //находим порядковый номер наибольшего элемента массива
        {
  
            int thebiggestnumercount = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[thebiggestnumercount] < array[i])
                {
                    thebiggestnumercount = i;
                }
            }

            return thebiggestnumercount;
           
        }









    }
}
