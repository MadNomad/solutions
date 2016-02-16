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
	/// Description of Npc.
	/// </summary>
	public class Npc : Player
	{
		Random rnd = new Random();
		
		
		public Npc(string name = "Tyler", int hp = 100, int damage = 5)
		{
			Name = name;
			Hp = hp;
			Damage = damage;
		}
		
		public BodyPart GenRandPart ()
		{
			return (BodyPart)rnd.Next(1, 4);
		}
		
		public override int GetHit()
		{
			return (int)GenRandPart();
		}
		
		public override int SetBlock()
		{
			return (int)GenRandPart();
		}
	}
}
