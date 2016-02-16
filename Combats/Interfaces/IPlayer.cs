/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:38
 */
using System;
using Combats.Classes;

namespace Combats
{
	/// <summary>
	/// Description of IPlayer.
	/// </summary>
	public interface IPlayer
	{
		string Name {get; set;}
		int Hp {get;set;}
		int Damage {get;set;}
		int GetHit (Player.BodyPart arg);
		int SetBlock (Player.BodyPart arg);
		event GameControl.PlayerStatus Wound;
		event GameControl.PlayerStatus Block;
		event GameControl.PlayerStatus Death;		
	}
}
