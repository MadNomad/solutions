/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 01.02.2016
 * Time: 12:22
 */
using System;

namespace IntArraySort
{
	/// <summary>
	/// Расширение для массива челых чисел сортирующее его по возрастанию.
	/// </summary>
	public static class ShakerSort
	{
		public static void ArraySort(this int[] array)
		{
			// Позиции
			int current = 0;				// Текущая
            int left = 0;					// Левая
            int right = array.Length - 1;	// Правая
            
            while( left < right)
            {
                for (int i = left; i < right; i++) // Обработка слева направо...
                {
                   if (array[i] > array[i + 1])
                        {
                            current = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = current;
                            current = i;
                        }
                }
                right = current;					// Установка новой границы справа
                if ( left >= right ) break;			// Выход если границы в одной точке
                for (int i = right; i > left; i--)	// Обработка справа налево...
                {
                   if (array[i-1] > array[i])
                        {
                            current = array[i];
                            array[i] = array[i-1];
                            array[i -1] = current;
                            current = i;
                        }
                }
                left = current;						// Установка новой границы слева
            }
		}
	}
}
