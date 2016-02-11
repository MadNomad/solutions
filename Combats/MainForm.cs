/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 09.02.2016
 * Time: 22:27
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Combats.Classes;
using System.Diagnostics;

namespace Combats
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Controls.Add(this.groupFight);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ButtonStartClick(object sender, EventArgs e)
		{
			startWindow.Visible = false;
			startWindow.TabIndex = 4;
//			npc.Name = "TestName";
			Player npc = new Npc("TestName");
			groupFight.Visible = true;
			groupFight.TabIndex = 0;
			label2.Text = npc.Name;
			npc.ShowDebug();
		}

		void NumericUpDownStrengthValueChanged(object sender, System.EventArgs e)
		{
			throw new System.NotImplementedException();
		}
	}
}
