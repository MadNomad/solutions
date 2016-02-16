/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:04
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Combats.Classes;

namespace Combats
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Presenter presenter;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			presenter = new Presenter(this);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonChangeName1Click(object sender, EventArgs e)
		{
			
			presenter.ChangeName(this.textPlayerName1.Text);
	
		}
	}
}
