/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 16.02.2016
 * Time: 12:29
 */
using System;

namespace Combats
{
	/// <summary>
	/// Description of Presenter.
	/// </summary>
	public class Presenter
	{
		
		GameControl game;
		MainForm app;
		
		
		public Presenter(MainForm app)
		{
			this.app = app;
			this.game = new GameControl(this);
			app.labelPlayerName2.Text = game.npc.Name;
		}
		
		public void ChangeName(string name)
		{
			game.ChangeName(name);
			AddToLog("Изменено имя персонажа на "+ game.human.Name);
		}
		
		public void AddToLog(string text)
		{
			app.richBattleLog.Text += text + Environment.NewLine;
		}
		
	}
}
