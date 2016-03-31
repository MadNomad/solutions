/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 30.03.2016
 * Time: 12:08
 */
using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
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
        
        public void PresentAllUsersInDataView()
        {
            UpdateUserDataGrid();
            AutoSizeCols();
        }
        
        public void PresenterAddUser(string login, string password, string email, bool isValidMail)
        {
            var newUser = new User
            {
                Id = Guid.NewGuid(),
                Date = DateTime.Now,
                Login = login,
                Password = password,
                EMail = email,
                IsEMailValid = isValidMail,
                Player = Guid.NewGuid()
            };
            
            database.Users.Create(newUser);
            database.Save();
            UpdateUserDataGrid();
            AutoSizeCols();

        }

        public void UpdateUserDataGrid()
        {
            view.UsersDataView.DataSource = database.Users.GetAll();
        }
        
        void AutoSizeCols()
        {
            for (int i = 0; i < view.UsersDataView.Columns.Count - 1; i++)
            {
                view.UsersDataView.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            }
            view.UsersDataView.Columns[view.UsersDataView.Columns.Count - 1].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            for (int i = 0; i < view.UsersDataView.Columns.Count; i++)
            {
                int colw = view.UsersDataView.Columns[i].Width;
                view.UsersDataView.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
                view.UsersDataView.Columns[i].Width = colw;
            }
        }
    }
}
