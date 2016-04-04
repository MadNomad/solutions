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
using GameData.Interfaces;
using GameData.UI;

namespace GameData
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form, IMainForm
    {
        Presenter presenter;
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            this.DoubleBuffered = true;
            InitializeComponent();
            EditUser.Enabled = false;
            DeleteUser.Enabled = false;
            presenter = new Presenter(this);
            
        }
        
        bool CheckAddUserTextboxesForMinimumValidData()
        {
            if (String.IsNullOrWhiteSpace(userLogin.Text))
            {
                userLogin.BackColor = Color.OrangeRed;
            }
            else
            {
                userLogin.BackColor = Color.Empty;
            }
            if (String.IsNullOrWhiteSpace(userPassword.Text))
            {
                userPassword.BackColor = Color.OrangeRed;
            }
            else
            {
                userPassword.BackColor = Color.Empty;
            }
            if (userLogin.BackColor == Color.OrangeRed || userPassword.BackColor == Color.OrangeRed)
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
                id.Text = datagrid.CurrentRow.Cells["Id"].Value.ToString();
                userId.Text = datagrid.CurrentRow.Cells["UserId"].Value.ToString();
                playerId.Text = datagrid.CurrentRow.Cells["Player"].Value.ToString();
                date.Text = datagrid.CurrentRow.Cells["Date"].Value.ToString();
                userLogin.Text = datagrid.CurrentRow.Cells["Login"].Value.ToString();
                userPassword.Text = datagrid.CurrentRow.Cells["Password"].Value.ToString();
                isEmailValid.Checked = (bool)datagrid.CurrentRow.Cells["IsEMailValid"].Value;
                userEmail.Text = datagrid.CurrentRow.Cells["EMail"].Value.ToString();
                EditUser.Enabled = true;
                DeleteUser.Enabled = true;
            }
        }
        void LoadUsersDataClick(object sender, EventArgs e)
        {
            presenter.LoadAllUsersInDataGrid(UsersDataView);
            usersDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        
        void AddUserClick(object sender, EventArgs e)
        {
            if (!CheckAddUserTextboxesForMinimumValidData())
                return;
            presenter.AddUser(userLogin.Text, userPassword.Text, userEmail.Text, isEmailValid.Checked);
        }

        void DeleteUserClick(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(id.Text))
                return;
            presenter.DeleteUser(Convert.ToInt64(id.Text));
            EditUser.Enabled = false;
            DeleteUser.Enabled = false;
        }

        void EditUserClick(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(id.Text))
                return;
            presenter.EditUser(Convert.ToInt64(id.Text),
                               Guid.Parse(userId.Text),
                               Guid.Parse(playerId.Text),
                               Convert.ToDateTime(date.Text),
                               userLogin.Text,
                               userPassword.Text,
                               userEmail.Text,
                               isEmailValid.Checked
                              );
            EditUser.Enabled = false;
            DeleteUser.Enabled = false;
        }

        void FilterUsersByValidatedEmailClick(object sender, EventArgs e)
        {
          
        }

        #region IMainForm implementation

        public DataGridView UsersDataView
        {
            get
            {
                return usersDataView;
            }
            set
            {
                usersDataView = value;
            }
        }

        public GroupBox UserForm
        {
            get
            {
                return userForm;
            }
            set
            {
                userForm = value;
            }
        }
        
        #endregion

    }
}
