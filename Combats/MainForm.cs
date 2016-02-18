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
using System.Drawing;
using System.Linq;

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
        void ButtonStartGameClick(object sender, EventArgs e)
        {
            presenter.StartNewGame(this.textPlayerName1.Text);
        }
        void ButtonNewGameClick(object sender, EventArgs e)
        {
            presenter.StartNewGame(this.labelPlayerName1.Text);
        }
        void ButtonRoundClick(object sender, EventArgs e)
        {
            this.panel1.BackColor = Color.Empty;
            this.panel2.BackColor = Color.Empty;
            string attackPoint = null;
            string blockPoint = null;

            if (this.panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) != null)
            {
                attackPoint = this.panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            }
            else
            {
                this.panel1.BackColor = Color.IndianRed;
            }
            if (this.panel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked) != null)
            {
                blockPoint = this.panel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            }
            else
            {
                this.panel2.BackColor = Color.IndianRed;
            }
            if (!String.IsNullOrEmpty(attackPoint)  && !String.IsNullOrEmpty(blockPoint))
            {
                this.panel1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Checked = false;
                this.panel2.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Checked = false;
                presenter.NextRound (attackPoint, blockPoint);
            }
        }
    }
}
