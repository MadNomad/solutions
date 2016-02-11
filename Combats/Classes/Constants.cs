/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 10.02.2016
 * Time: 16:16
 */
using System;

namespace Combats.Classes
{
	/// <summary>
	/// Description of Constants.
	/// </summary>
	public static class Constants
	{
        public const int damageMultiplier = 1; // Множитель урона
        public const int dodgeMultiplier = 5; // Множитель шанса увернуться
        public const int criticalMultiplier = 5; // Множитель шанса крита
        public const int hpMultiplier = 10; // Множитель очков здоровья
        public const int pointsNumber = 5; // Кол-во очков умений при создании бойца
        public const int pointsSummAtGen = 17; // Общее максимальное кол-во очков умений при генерации
        public const int damageVariety = 5; // Значение разброса урона
	}
}
