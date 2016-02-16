/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:42
 */
using System;

namespace Combats.Classes
{
	/// <summary>
	/// Description of Human.
	/// </summary>
	public class Human : Player
	{
		bool isHumanAttacker;
		
		public Human(string name = "Jack", int hp = 100, int damage = 5)
		{
			Name = name;
			Hp = hp;
			Damage = damage;
		}
	}
}
