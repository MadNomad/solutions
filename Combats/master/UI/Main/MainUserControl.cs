﻿/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 25.02.2016
 * Time: 9:58
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Combats
{
    /// <summary>
    /// Description of MainUserControl.
    /// </summary>
    public partial class MainUserControl : BaseUserConrol
    {
        public MainUserControl()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
        }

        void StartGameClick(object sender, EventArgs e)
        {
            if (InputPlayerName.Text == "")
            {
                InputPlayerName.BackColor = Color.IndianRed;
                return;
            }
            else
            {
                InputPlayerName.BackColor = Color.Empty;
            }
            MainForm.PlayerName = InputPlayerName.Text;
            SwitchScene(Scene.Battle);
        }
    }
}
