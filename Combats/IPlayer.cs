/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 10.02.2016
 * Time: 15:36
 */
using System;

namespace Combats
{
	/// <summary>
	/// Description of IPlayer.
	/// </summary>
	public interface IPlayer
	{
		string Name {get; set;}
		int Strength {get; set;}
		int Agility {get; set;}
		int Intuition {get; set;}
		int Constitution {get; set;}
		int Hp {get; set;}
		int Damage {get; set;}
		int Dodge {get; set;}
		int Critical {get; set;}
		int FreeStatPoints {get;set;}
		
	}
}
