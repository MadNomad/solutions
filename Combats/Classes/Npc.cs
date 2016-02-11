/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 10.02.2016
 * Time: 17:21
 */
using System;

namespace Combats.Classes
{
	/// <summary>
	/// Description of Npc.
	/// </summary>
	public class Npc : Player
	{
		public Npc(string name = "Tyler", int strength = 3, int agility = 3, int intuition = 3, int constitution = 3)
		{
			Name = name;
			Strength = strength;
			Agility = agility;
			Intuition = intuition;
			Constitution = constitution;
			
		}
		
		
	}
}
