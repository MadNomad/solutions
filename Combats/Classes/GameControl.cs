/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:57
 */
using System;
using Combats.Classes;
using System.Windows.Forms;

namespace Combats
{
	/// <summary>
	/// Description of GameControl.
	/// </summary>
	public class GameControl
	{
		public delegate void PlayerStatus (string name, int xp, int damage);

		public IPlayer human;
		public IPlayer npc;
		Presenter view;

		public GameControl(Presenter view)
		{
			this.view = view;
			human = new Human();
			npc = new Npc();
			human.

		}
		
		public void ChangeName (string name)
		{
			human.Name = name;
		}
		
//		public void DoRound ()
	}
}
