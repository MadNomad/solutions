/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 01.02.2016
 * Time: 13:25
 */
using System;

namespace IntArraySort
{
	/// <summary>
	/// Расширение для массива челых чисел сортирующее его по возрастанию.
	/// Расширение должно принимать bool параметер который задает направление сортировки.
	/// </summary>
	public static class ShakerSortDesc
	{
		public static void ArraySortDesc(this int[] array, bool order)
		{
			// Позиции
			int current = 0;				// Текущая
            int left = 0;					// Левая
            int right = array.Length - 1;	// Правая

            if (order)
            {
				while (left < right) {
					for (int i = left; i < right; i++) { // Обработка слева направо...
						if (array[i] < array[i + 1]) {
							current = array[i + 1];
							array[i + 1] = array[i];
							array[i] = current;
							current = i;
						}
					}
					right = current;					// Установка новой границы справа
					if (left >= right)
						break;			// Выход если границы в одной точке
					for (int i = right; i > left; i--) {	// Обработка справа налево...
						if (array[i - 1] < array[i]) {
							current = array[i - 1];
							array[i - 1] = array[i];
							array[i] = current;
							current = i;
						}
					}
					left = current;						// Установка новой границы слева
				}
            }
            else
            {
				while (left < right) {
					for (int i = left; i < right; i++) { // Обработка слева направо...
						if (array[i] > array[i + 1]) {
							current = array[i];
							array[i] = array[i + 1];
							array[i + 1] = current;
							current = i;
						}
					}
					right = current;					// Установка новой границы справа
					if (left >= right)
						break;			// Выход если границы в одной точке
					for (int i = right; i > left; i--) {	// Обработка справа налево...
						if (array[i - 1] > array[i]) {
							current = array[i];
							array[i] = array[i - 1];
							array[i - 1] = current;
							current = i;
						}
					}
					left = current;						// Установка новой границы слева
				}
			}
            
		}
	}
}
