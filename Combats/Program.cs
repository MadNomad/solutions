/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 09.02.2016
 * Time: 22:27
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Combats.Classes;

namespace Combats
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
