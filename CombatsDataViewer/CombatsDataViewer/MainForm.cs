/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 08.04.2016
 * Time: 9:32
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LogicLayer.DataObject;
using LogicLayer.Services;

namespace CombatsDataViewer
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        string Server;
        List<UserDTO> Users;
        List<UserTransactionDTO> UsersTransactions;
        List<PlayerDTO> Player;
        List<BattleDTO> Battles;
        
        public MainForm()
        {
            InitializeComponent();
        }
        
        void AddUserClick(object sender, EventArgs e)
        {
            UserDTO user = new UserDTO
            {
                Login = userLogin.Text,
                Password = userPassword.Text,
                EMail = userEmail.Text,
                IsEMailValidated = isEmailValid.Checked,
                CharacterName = playerName.Text,
                RegistrationDate = DateTime.Now
                    
            };
            Users = new UserService(Server).GetAllUsers().ToList();
            Users.Add(user);
            
        }

        void DeleteUserClick(object sender, EventArgs e)
        {

        }

        void EditUserClick(object sender, EventArgs e)
        {

        }
        void MainFormLoad(object sender, EventArgs e)
        {
            setLocalDB.AutoCheck = true;
            setExternalDB.AutoCheck = true;
        }
        void ConnectButtonClick(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            Server = selectDbSever.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();
            Users = new UserService(Server).GetAllUsers();
        }
        void SetLocalDBCheckedChanged(object sender, EventArgs e)
        {
            connectButton.Enabled = true;
        }
        void SetExternalDBCheckedChanged(object sender, EventArgs e)
        {
            connectButton.Enabled = true;
        }

    }
}
