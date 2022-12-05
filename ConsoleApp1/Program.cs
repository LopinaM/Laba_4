using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,] array1;
            //array1 = new double[,] { { 8, 8, 7 }, { 4, 2, 9 }, { 6, 3, 9 }, { 4, 7, 1 }, { 7, 6, 5 } };

            //double[,] array2;
            //array2 = new double[,] { { 5, 1, 5 }, { 6, 8, 3 }, { 2, 4, 2 }, { 6, 8, 2 }, { 3, 2, 4 } };

            //double[,] array3;
            //array3 = new double[,] { { 9, 4, 4 }, { 8, 6, 7 }, { 6, 8, 4 }, { 7, 3, 8 }, { 7, 4, 3 } };


            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("СИСТЕМА КОЛЛЕКТИВНОГО ВЫБОРА ПО НЕСКОЛЬКИМ КРИТЕРИЯМ");
            Console.WriteLine("Выбор семейной поездки в школьные каникулы");
            Console.WriteLine("Эксперты - папа, мама, ребенок");
            Console.WriteLine("Критерии: цена, дальность, желание");
            Console.WriteLine();
            //Console.WriteLine("Коэффициенты доверия к экспертам: 0,6  0,3  0,1 ");
            //Console.WriteLine("Коэффициенты важности критерия: 0,4  0,2  0,4 ");
            Console.WriteLine("Альтернативы: Санкт-Петербург, Калининград, Волгоград, Грузия, Армения");
            Console.WriteLine();


            int x = 5;
            int y = 3;
            //Console.WriteLine("Введите размерность данных ");
            //int x = Int32.Parse(Console.ReadLine());
            //int y = Int32.Parse(Console.ReadLine());
            double[,] array1 = new double[x, y];
            Console.WriteLine("Заполните данные (1): ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array1[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double[,] array2 = new double[x, y];
            Console.WriteLine("Заполните данные (2): ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array2[i, j] = double.Parse(Console.ReadLine());
                }
            }
            double[,] array3 = new double[x, y];
            Console.WriteLine("Заполните данные (3): ");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array3[i, j] = double.Parse(Console.ReadLine());
                }
            }

            //вывод массива на экран
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("{0}\t", array11[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Введите коэффициенты важности критерия: ");
            //Console.WriteLine("Для 1го эксперта: ");
            //double a1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Для 2го эксперта: ");
            //double b1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Для 3го эксперта: ");
            //double c1 = Convert.ToDouble(Console.ReadLine());
            double[] ark1 = new double[3];
            Console.WriteLine("Заполните данные для экспертов (1го-3го соответственно): ");
            for (int k = 0; k < 3; k++)
            {
                ark1[k] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("----------------------------------------------------------------------");

         

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Баллы 1го эксперта: ");
            double[,] ar1 = new double[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {                   
                    ar1[i, j] = array1[i,j] * ark1[j];
                    Console.Write("{0}\t", ar1[i, j]);
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Баллы 2го эксперта: ");
            double[,] ar2 = new double[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    ar2[i, j] = array2[i, j] * ark1[j];
                    Console.Write("{0}\t", ar2[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Баллы 3го эксперта: ");
            double[,] ar3 = new double[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    ar3[i, j] = array3[i, j] * ark1[j];
                    Console.Write("{0}\t", ar3[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Введите коэффициенты доверия к экспертам: " );
            Console.WriteLine("Для 1го эксперта: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Для 2го эксперта: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Для 3го эксперта: ");
            double c = Convert.ToDouble(Console.ReadLine());


            // эксперты 
            //double a = 0.6;
            //double b = 0.3;
            //double c = 0.1;


            double[] new1 = new double[5];
            double[] new2 = new double[5];
            double[] new3 = new double[5];
            Console.WriteLine("Подсчет суммы быллов для каждой альтернативы 1го эксперта (Папы): ");
            for (int i = 0; i < ar1.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < ar1.GetLength(1); j++)
                {
                    sum += ar1[i, j];
                    new1[i] = sum;
                }
                Console.WriteLine(sum );
            }

            ////массив сумм
            //for (int i = 0; i < 5; i++)
            //{
            //        Console.Write("{0}\t", new1[i]);
            //}

            Console.WriteLine();
            Console.WriteLine("Подсчет суммы быллов для каждой альтернативы 2го эксперта (Мамы): ");
            for (int i = 0; i < ar2.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < ar2.GetLength(1); j++)
                {
                    sum += ar2[i, j];
                    new2[i] = sum;
                }
                Console.WriteLine(sum);
            }

            ////массив сумм
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0}\t", new2[i]);
            //}
            
            Console.WriteLine();
            Console.WriteLine("Подсчет суммы быллов для каждой альтернативы 3го эксперта (Ребенка): ");
            for (int i = 0; i < ar3.GetLength(0); i++)
            {
                double sum = 0;
                for (int j = 0; j < ar3.GetLength(1); j++)
                {
                    sum += ar3[i, j];
                    new3[i] = sum;
                }
                Console.WriteLine(sum);
            }

            ////массив сумм
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0}\t", new3[i]);
            //}



            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Массив общих сумм: ");
            double[] new5 = new double[5];

            for (int i = 0; i < 5; i ++)
            {
                new5[i] = a * 1 * new1[i] + b * 2 * new2[i] + c * 3 * new3[i];
                Console.Write("{0}\t", new5[i]);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            int index = 0;
            double max = new5[0]; // максимальный элемент. Для начала
            for (int i = 0; i < 5; i++) // проходим по всем элементам масива
            {
                if (new5[i] > max)
                {
                    max = new5[i];
                    index = i;
                }
            }
            index = index + 1;
            //Console.WriteLine("Вывод:  " + max);
            Console.WriteLine("Вывод: исходя из того, что посчитала система, наиболее приемлемая альтернатива - " + index);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();


           //Альтернативы: Санкт-Петербург, Калининград, Волгоград, Грузия, Армения
            if (max == new5[0])
                Console.WriteLine("Исходя из введенных данных наиболее приемлемая альтернатива на данный момент - Санкт-Петербург");
            if (max == new5[1])
                Console.WriteLine("Исходя из введенных данных наиболее приемлемая альтернатива на данный момент - Калининград");
            if (max == new5[2])
                Console.WriteLine("Исходя из введенных данных наиболее приемлемая альтернатива на данный момент - Волгоград");
            if (max == new5[3])
                Console.WriteLine("Исходя из введенных данных наиболее приемлемая альтернатива на данный момент - Грузия");
            if (max == new5[4])
                Console.WriteLine("Исходя из введенных данных наиболее приемлемая альтернатива на данный момент - Армения");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("МЕТОД БОРДА");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();



            double[] new11 = new double[5];
            double[] new22 = new double[5];
            double[] new33 = new double[5];
            Console.WriteLine("Подсчет суммы быллов для каждой альтернативы 1го эксперта (Папы): ");
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                double sum1 = 0;
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    sum1 += array1[i, j];
                    new11[i] = sum1;
                }
                Console.WriteLine(sum1);
            }
    

            Console.WriteLine();
            Console.WriteLine("Подсчет суммы быллов для каждой альтернативы 2го эксперта (Мамы): ");
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                double sum2 = 0;
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    sum2 += array2[i, j];
                    new22[i] = sum2;
                }
                Console.WriteLine(sum2);
            }

        
            Console.WriteLine();
            Console.WriteLine("Подсчет суммы быллов для каждой альтернативы 3го эксперта (Ребенка): ");
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                double sum3 = 0;
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    sum3 += array3[i, j];
                    new33[i] = sum3;
                }
                Console.WriteLine(sum3);
            }

            Console.WriteLine("Массив общих сумм: ");
            double[] new6 = new double[5];

            for (int i = 0; i < 5; i++)
            {
                new6[i] = new11[i] + new22[i] + new33[i];
                Console.Write("{0}\t", new6[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            int indx = 0;
            double maxel = new6[0]; // максимальный элемент
            for (int i = 0; i < 5; i++) // проходим по всем элементам масива
            {
                if (new6[i] > maxel)
                {
                    maxel = new6[i];
                    indx = i;
                }
            }
            indx = indx + 1;
            //Console.WriteLine("Вывод:  " + maxel);
            Console.WriteLine("Вывод: исходя из того, что посчитала система, наиболее приемлемая альтернатива - " + indx);
            //Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();


            //Альтернативы: Санкт-Петербург, Калининград, Волгоград, Грузия, Армения
            if (maxel == new6[0])
                Console.WriteLine("Исходя из введенных данных наиболее приемлемая альтернатива на данный момент - Санкт-Петербург");
            if (maxel == new6[1])
                Console.WriteLine("Исходя из введенных данных наиболее приемлемая альтернатива на данный момент - Калининград");
            if (maxel == new6[2])
                Console.WriteLine("Исходя из введенных данных наиболее приемлемая альтернатива на данный момент - Волгоград");
            if (maxel == new6[3])
                Console.WriteLine("Исходя из введенных данных наиболее приемлемая альтернатива на данный момент - Грузия");
            if (maxel == new6[4])
                Console.WriteLine("Исходя из введенных данных наиболее приемлемая альтернатива на данный момент - Армения");
            Console.WriteLine("----------------------------------------------------------------------");
        }
    }
}
