/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 10.02.2016
 * Time: 16:09
 */
using System;
using System.Diagnostics;
using Combats;


namespace Combats.Classes
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	public abstract class Player : IPlayer
	{
		public int Attack ()
		{
			Random rnd = new Random();
			int doDamage = rnd.Next(Damage - Constants.damageVariety, Damage + Constants.damageVariety + 1);
			if (doDamage < 1)
			{
				Console.WriteLine("{0} попал, но не нанес ощутимого урона!", Name);
				return 0;
			}
			else
			{
				Console.WriteLine("{0} ударил и нанес {1} урона!", Name, doDamage);
				return doDamage;
			}
		}

		public void ShowDebug()
		{
			Debug.WriteLine(Name);
			Debug.WriteLine("Создан персонаж {0} с характеристиками:", Name);
			Debug.WriteLine("Сила: {0}", Strength);
			Debug.WriteLine("Ловкость: {0}", Agility);
			Debug.WriteLine("Интуиция: {0}", Intuition);
			Debug.WriteLine("Сложение: {0}", Constitution);
			Debug.WriteLine("Свободных характеристик {0}", FreeStatPoints);
		}
		
		
		#region IPlayer implementation
		private string name;
		public string Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}
		private int strength;
		public int Strength {
			get {
				return strength;
			}
			set {
				strength = value;
			}
		}
		private int agility;
		public int Agility {
			get {
				return agility;
			}
			set {
				agility = value;
			}
		}
		private int intuition;
		public int Intuition {
			get {
				return intuition;
			}
			set {
				intuition = value;
			}
		}
		private int constitution;
		public int Constitution {
			get {
				return constitution;
			}
			set {
				constitution = value;
			}
		}
		private int hp;
		public int Hp {
			get {
				return hp;
			}
			set {
				hp = Constitution * Constants.hpMultiplier;
			}
		}
		private int damage;
		public int Damage {
			get {
				return damage;
			}
			set {
				damage = Strength * Constants.damageMultiplier;
			}
		}
		private int dodge;
		public int Dodge {
			get {
				return dodge;
			}
			set {
				dodge = Agility * Constants.dodgeMultiplier;
			}
		}
		private int critical;
		public int Critical {
			get {
				return critical;
			}
			set {
				critical = Intuition * Constants.criticalMultiplier;
			}
		}
		private int freeStatPoints;
		public int FreeStatPoints {
			get {
				return freeStatPoints;
			}
			set {
				freeStatPoints = value;
			}
		}
		#endregion
	}
}
