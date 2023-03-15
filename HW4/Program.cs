using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Возведение числа A в степень B
            int z = printInputInt("Введите число, которое будет возведено в степень");
            print($"\nПолученное значение:{Pow(z, printInputInt("\nВведите степень"))}\n");
            #endregion

            #region На вход число, на выходе сумма цифр числа
            print($"\nСумма чисел в заданной цифра = {SumAllNumbers(printInputInt("Введите число, сумма цифр которого вас интересует"))}\n");
            #endregion

            #region Задать массив из 8 элементов, вывод их на экран
            print($"\nПолученный массив: {ArrayToString(InputArray(printInputInt("Введите размер массива")), ", ")}\n");
            #endregion
        }

        /// <summary>
        /// удобство вывода без лишнего текста
        /// </summary>
        /// <param name="mes">текст для вывода в консоль</param>
        static void print(string mes)
        {
            Console.WriteLine(mes);
        }

        /// <summary>
        /// отображение сообщения, прием из консоли значения, перевод полученного значения в число
        /// </summary>
        /// <param name="mes">сообщение перед запросом числа</param>
        /// <returns>число, введенное пользователем в консоли</returns>
        static int printInputInt(string mes)
        {
            Console.WriteLine(mes);
            int.TryParse(Console.ReadLine(), out int userNumber);
            return userNumber;
        }

        /// <summary>
        /// Метод возводит число в степень
        /// </summary>
        /// <param name="A">число</param>
        /// <param name="B">степень</param>
        /// <returns>число возведенное в степень</returns>
        static int Pow(int A, int B)
        {
            int z = A;
            for (int i = 1; i < B; i++)
            {
                z *= A;
            }

            return z;
        }

        /// <summary>
        /// Метод складывает все числа из заданной цифры
        /// </summary>
        /// <param name="x">цифра, сумму чисел которой необходимо найти</param>
        /// <returns>сумма всех чисел заданной цифры</returns>
        static int SumAllNumbers(int x)
        {
            int temp = x;
            int count = 0;

            while (temp > 0)
            {
                temp = temp / 10;
                count++; // узнаем количество цифр в числе
            }
            temp = 0;

            for (int i = 0; i < count; i++)
            {
                temp += (int)((x % Math.Pow(10, i + 1) - x % Math.Pow(10, i)) / Math.Pow(10, i));
            }
            
            return temp;
        }

        /// <summary>
        /// Ввод числового массива заданного размера
        /// </summary>
        /// <param name="c">размер массива</param>
        /// <returns>массив, введенный пользователем</returns>
        static int[] InputArray(int c)
        {
            int[] arr = new int[c];

            for (int i = 0; i < c; i++)
            {
                print($"\nВведите {i + 1} число массива");
                int.TryParse(Console.ReadLine(), out int userNumber);
                arr[i] += userNumber;
            }

            return arr;
        }

        /// <summary>
        /// Перевод числового массива в строку, с дополнительным форматированием
        /// </summary>
        /// <param name="array">числовой массив для перевода в строку</param>
        /// /// <param name="addStr">дополнительные символы после числа</param>
        /// <returns>строка сформированная из массива и дополнительного форматирования</returns>
        static string ArrayToString (int[] array, string addStr)
        {
            string z = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                {
                    z += array[i].ToString() + addStr;
                }
                else
                {
                    z += array[i].ToString();
                }     
            }
            return z;
        }
    }
}