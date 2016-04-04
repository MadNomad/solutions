/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 30.03.2016
 * Time: 12:08
 */
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Drawing;
using System.Windows.Forms;
using GameData.Data.EF;
using GameData.Entity;
using GameData.Interfaces;
using GameData.Repositories;

namespace GameData.UI
{
    /// <summary>
    /// Description of Presenter.
    /// </summary>
    public class Presenter
    {
        MainForm view;
        IUnitOfWork database;
        
        public Presenter(MainForm view)
        {
            this.view = view;
            database = new UnitOfWork(new Context());
        }
        
        public void LoadAllUsersInDataGrid(DataGridView datagrid)
        {
            UpdateDataGrid(datagrid);
            AutoSizeCols(datagrid);
        }
        
        public void AddUser(string login, string password, string email, bool isValidMail)
        {
            var newUser = new User
            {
                UserId = Guid.NewGuid(),
                Date = DateTime.Now,
                Login = login,
                Password = password,
                EMail = email,
                IsEMailValid = isValidMail,
                Player = Guid.NewGuid()
            };
            
            database.Users.Create(newUser);
            Save();
        }
        
        public void EditUser (Int64 id, Guid userId, Guid playerId, DateTime date, string login, string password, string userEmail, bool isValidEmail)
        {
            User user = database.Users.GetById(id);
            user.Login = login;
            user.Password = password;
            user.EMail = userEmail;
            user.IsEMailValid = isValidEmail;
            database.Users.Update(user);
            Save();
        }

        public void DeleteUser(Int64 id)
        {
            database.Users.Delete(id);
            Save();
        }
        
        void Save()
        {
            database.Save();
            ClearEditForm(view.UserForm);
            UpdateDataGrid(view.UsersDataView);
            AutoSizeCols(view.UsersDataView);
        }
        public void UpdateDataGrid(DataGridView datagrid)
        {
            datagrid.DataSource = database.Users.GetAll();
        }
        
        public void FilterUserlistByValidetedEmail()
        {
//            view.UsersDataView.DataSource = database.Users
        }
        
        void ClearEditForm(GroupBox group)
        {
            foreach (Control control in group.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = null;
                    control.BackColor = Color.Empty;
                }
            }
        }
        void AutoSizeCols(DataGridView datagrid)
        {
            for (int i = 0; i < datagrid.Columns.Count - 1; i++)
            {
                datagrid.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            }
            datagrid.Columns[datagrid.Columns.Count - 1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 0; i < datagrid.Columns.Count; i++)
            {
                int colw = datagrid.Columns[i].Width;
                datagrid.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                datagrid.Columns[i].Width = colw;
            }
        }
    }
}
