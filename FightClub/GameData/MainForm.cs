/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 28.03.2016
 * Time: 10:31
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GameData.UI;

namespace GameData
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
            this.DoubleBuffered = true;
            InitializeComponent();
            presenter = new Presenter(this);
        }
        
        void LoadUsersDataClick(object sender, EventArgs e)
        {
            presenter.PresentAllUsersInDataView();
            UsersDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        void AddUserClick(object sender, EventArgs e)
        {
            if (!CheckAddUserTextboxesForMinimumValidData())
                return;
            presenter.PresenterAddUser(UserLogin.Text, UserPassword.Text, UserEmail.Text, IsEmailValid.Checked);
        }

        bool CheckAddUserTextboxesForMinimumValidData()
        {
            if (String.IsNullOrWhiteSpace(UserLogin.Text))
            {
                UserLogin.BackColor = Color.OrangeRed;
            }
            else
            {
                UserLogin.BackColor = Color.Empty;
            }
            if (String.IsNullOrWhiteSpace(UserPassword.Text))
            {
                UserPassword.BackColor = Color.OrangeRed;
            }
            else
            {
                UserPassword.BackColor = Color.Empty;
            }
            if (UserLogin.BackColor == Color.OrangeRed || UserPassword.BackColor == Color.OrangeRed)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        void UsersDataViewCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView datagrid = sender as DataGridView;
            if (datagrid == null)
            {
                return;
            }
            if (datagrid.CurrentRow.Selected)
            {
                UserId.Text = datagrid.CurrentRow.Cells["Id"].Value.ToString();
                PlayerId.Text = datagrid.CurrentRow.Cells["Player"].Value.ToString();
                Date.Text = datagrid.CurrentRow.Cells["Date"].Value.ToString();
                UserLogin.Text = datagrid.CurrentRow.Cells["Login"].Value.ToString();
                UserPassword.Text = datagrid.CurrentRow.Cells["Password"].Value.ToString();
                IsEmailValid.Checked = (bool)datagrid.CurrentRow.Cells["IsEMailValid"].Value;
                UserEmail.Text = datagrid.CurrentRow.Cells["EMail"].Value.ToString();
//                MessageBox.Show("OK!");
            }
        }
    }
}
