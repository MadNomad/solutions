/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 28.03.2016
 * Time: 10:31
 */
namespace GameData
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl DataTabs;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.TabPage PlayersTab;
        private System.Windows.Forms.TabPage TransactionsView;
        private System.Windows.Forms.TabPage BattlesView;
        private System.Windows.Forms.TabPage BattleLogsView;
        private System.Windows.Forms.Button LoadUsersData;
        private System.Windows.Forms.DataGridView usersDataView;
        private System.Windows.Forms.GroupBox userForm;
        private System.Windows.Forms.Label UserEmailText;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Label UserPasswordText;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label UserLoginText;
        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.CheckBox isEmailValid;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label UserIdText;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.Label DateText;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label PlayerIdText;
        private System.Windows.Forms.TextBox playerId;
        private System.Windows.Forms.Label IdText;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.GroupBox usersFilter;
        private System.Windows.Forms.Button filterUsersByValidatedEmail;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DataTabs = new System.Windows.Forms.TabControl();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.userForm = new System.Windows.Forms.GroupBox();
            this.IdText = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.DateText = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.PlayerIdText = new System.Windows.Forms.Label();
            this.playerId = new System.Windows.Forms.TextBox();
            this.UserIdText = new System.Windows.Forms.Label();
            this.userId = new System.Windows.Forms.TextBox();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.isEmailValid = new System.Windows.Forms.CheckBox();
            this.UserEmailText = new System.Windows.Forms.Label();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.UserPasswordText = new System.Windows.Forms.Label();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.UserLoginText = new System.Windows.Forms.Label();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.LoadUsersData = new System.Windows.Forms.Button();
            this.usersDataView = new System.Windows.Forms.DataGridView();
            this.PlayersTab = new System.Windows.Forms.TabPage();
            this.TransactionsView = new System.Windows.Forms.TabPage();
            this.BattlesView = new System.Windows.Forms.TabPage();
            this.BattleLogsView = new System.Windows.Forms.TabPage();
            this.usersFilter = new System.Windows.Forms.GroupBox();
            this.filterUsersByValidatedEmail = new System.Windows.Forms.Button();
            this.DataTabs.SuspendLayout();
            this.UsersTab.SuspendLayout();
            this.userForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataView)).BeginInit();
            this.usersFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTabs
            // 
            this.DataTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTabs.Controls.Add(this.UsersTab);
            this.DataTabs.Controls.Add(this.PlayersTab);
            this.DataTabs.Controls.Add(this.TransactionsView);
            this.DataTabs.Controls.Add(this.BattlesView);
            this.DataTabs.Controls.Add(this.BattleLogsView);
            this.DataTabs.Location = new System.Drawing.Point(3, 3);
            this.DataTabs.Name = "DataTabs";
            this.DataTabs.SelectedIndex = 0;
            this.DataTabs.Size = new System.Drawing.Size(780, 557);
            this.DataTabs.TabIndex = 0;
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.usersFilter);
            this.UsersTab.Controls.Add(this.userForm);
            this.UsersTab.Controls.Add(this.LoadUsersData);
            this.UsersTab.Controls.Add(this.usersDataView);
            this.UsersTab.Location = new System.Drawing.Point(4, 22);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(772, 531);
            this.UsersTab.TabIndex = 2;
            this.UsersTab.Text = "Users";
            this.UsersTab.UseVisualStyleBackColor = true;
            this.UsersTab.Enter += new System.EventHandler(this.LoadUsersDataClick);
            // 
            // userForm
            // 
            this.userForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.userForm.Controls.Add(this.IdText);
            this.userForm.Controls.Add(this.id);
            this.userForm.Controls.Add(this.DateText);
            this.userForm.Controls.Add(this.date);
            this.userForm.Controls.Add(this.PlayerIdText);
            this.userForm.Controls.Add(this.playerId);
            this.userForm.Controls.Add(this.UserIdText);
            this.userForm.Controls.Add(this.userId);
            this.userForm.Controls.Add(this.DeleteUser);
            this.userForm.Controls.Add(this.EditUser);
            this.userForm.Controls.Add(this.AddUser);
            this.userForm.Controls.Add(this.isEmailValid);
            this.userForm.Controls.Add(this.UserEmailText);
            this.userForm.Controls.Add(this.userEmail);
            this.userForm.Controls.Add(this.UserPasswordText);
            this.userForm.Controls.Add(this.userPassword);
            this.userForm.Controls.Add(this.UserLoginText);
            this.userForm.Controls.Add(this.userLogin);
            this.userForm.Location = new System.Drawing.Point(513, 281);
            this.userForm.Name = "userForm";
            this.userForm.Size = new System.Drawing.Size(252, 244);
            this.userForm.TabIndex = 2;
            this.userForm.TabStop = false;
            this.userForm.Text = "User";
            // 
            // IdText
            // 
            this.IdText.Location = new System.Drawing.Point(7, 19);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(79, 20);
            this.IdText.TabIndex = 17;
            this.IdText.Text = "DataBase ID";
            this.IdText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(92, 19);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(154, 20);
            this.id.TabIndex = 16;
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(7, 97);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(79, 20);
            this.DateText.TabIndex = 15;
            this.DateText.Text = "Date";
            this.DateText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(92, 97);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(154, 20);
            this.date.TabIndex = 14;
            // 
            // PlayerIdText
            // 
            this.PlayerIdText.Location = new System.Drawing.Point(7, 71);
            this.PlayerIdText.Name = "PlayerIdText";
            this.PlayerIdText.Size = new System.Drawing.Size(79, 20);
            this.PlayerIdText.TabIndex = 13;
            this.PlayerIdText.Text = "Player ID";
            this.PlayerIdText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playerId
            // 
            this.playerId.Location = new System.Drawing.Point(92, 71);
            this.playerId.Name = "playerId";
            this.playerId.ReadOnly = true;
            this.playerId.Size = new System.Drawing.Size(154, 20);
            this.playerId.TabIndex = 12;
            // 
            // UserIdText
            // 
            this.UserIdText.Location = new System.Drawing.Point(7, 45);
            this.UserIdText.Name = "UserIdText";
            this.UserIdText.Size = new System.Drawing.Size(79, 20);
            this.UserIdText.TabIndex = 11;
            this.UserIdText.Text = "UserID";
            this.UserIdText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(92, 45);
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Size = new System.Drawing.Size(154, 20);
            this.userId.TabIndex = 10;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteUser.ForeColor = System.Drawing.Color.OrangeRed;
            this.DeleteUser.Location = new System.Drawing.Point(171, 213);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(75, 23);
            this.DeleteUser.TabIndex = 9;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUserClick);
            // 
            // EditUser
            // 
            this.EditUser.Location = new System.Drawing.Point(90, 213);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(75, 23);
            this.EditUser.TabIndex = 8;
            this.EditUser.Text = "Edit";
            this.EditUser.UseVisualStyleBackColor = true;
            this.EditUser.Click += new System.EventHandler(this.EditUserClick);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(9, 213);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(75, 23);
            this.AddUser.TabIndex = 7;
            this.AddUser.Text = "Add";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUserClick);
            // 
            // isEmailValid
            // 
            this.isEmailValid.Location = new System.Drawing.Point(75, 177);
            this.isEmailValid.Margin = new System.Windows.Forms.Padding(0);
            this.isEmailValid.Name = "isEmailValid";
            this.isEmailValid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.isEmailValid.Size = new System.Drawing.Size(14, 19);
            this.isEmailValid.TabIndex = 6;
            this.isEmailValid.Text = "Validated?";
            this.isEmailValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.isEmailValid.UseVisualStyleBackColor = true;
            // 
            // UserEmailText
            // 
            this.UserEmailText.Location = new System.Drawing.Point(7, 175);
            this.UserEmailText.Name = "UserEmailText";
            this.UserEmailText.Size = new System.Drawing.Size(79, 20);
            this.UserEmailText.TabIndex = 5;
            this.UserEmailText.Text = "E-Mail";
            this.UserEmailText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(92, 175);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(154, 20);
            this.userEmail.TabIndex = 4;
            // 
            // UserPasswordText
            // 
            this.UserPasswordText.Location = new System.Drawing.Point(7, 149);
            this.UserPasswordText.Name = "UserPasswordText";
            this.UserPasswordText.Size = new System.Drawing.Size(79, 20);
            this.UserPasswordText.TabIndex = 3;
            this.UserPasswordText.Text = "Password";
            this.UserPasswordText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(92, 149);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(154, 20);
            this.userPassword.TabIndex = 2;
            // 
            // UserLoginText
            // 
            this.UserLoginText.Location = new System.Drawing.Point(7, 123);
            this.UserLoginText.Name = "UserLoginText";
            this.UserLoginText.Size = new System.Drawing.Size(79, 20);
            this.UserLoginText.TabIndex = 1;
            this.UserLoginText.Text = "Login";
            this.UserLoginText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userLogin
            // 
            this.userLogin.Location = new System.Drawing.Point(92, 123);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(154, 20);
            this.userLogin.TabIndex = 0;
            // 
            // LoadUsersData
            // 
            this.LoadUsersData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadUsersData.Location = new System.Drawing.Point(513, 7);
            this.LoadUsersData.Name = "LoadUsersData";
            this.LoadUsersData.Size = new System.Drawing.Size(75, 23);
            this.LoadUsersData.TabIndex = 1;
            this.LoadUsersData.Text = "Load Data";
            this.LoadUsersData.UseVisualStyleBackColor = true;
            this.LoadUsersData.Click += new System.EventHandler(this.LoadUsersDataClick);
            // 
            // usersDataView
            // 
            this.usersDataView.AllowUserToAddRows = false;
            this.usersDataView.AllowUserToDeleteRows = false;
            this.usersDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usersDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataView.Location = new System.Drawing.Point(6, 4);
            this.usersDataView.Name = "usersDataView";
            this.usersDataView.ReadOnly = true;
            this.usersDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.usersDataView.Size = new System.Drawing.Size(500, 524);
            this.usersDataView.TabIndex = 0;
            this.usersDataView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersDataViewCellMouseDoubleClick);
            // 
            // PlayersTab
            // 
            this.PlayersTab.Location = new System.Drawing.Point(4, 22);
            this.PlayersTab.Name = "PlayersTab";
            this.PlayersTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayersTab.Size = new System.Drawing.Size(772, 531);
            this.PlayersTab.TabIndex = 3;
            this.PlayersTab.Text = "Players";
            this.PlayersTab.UseVisualStyleBackColor = true;
            // 
            // TransactionsView
            // 
            this.TransactionsView.Location = new System.Drawing.Point(4, 22);
            this.TransactionsView.Name = "TransactionsView";
            this.TransactionsView.Padding = new System.Windows.Forms.Padding(3);
            this.TransactionsView.Size = new System.Drawing.Size(772, 531);
            this.TransactionsView.TabIndex = 4;
            this.TransactionsView.Text = "Transactions";
            this.TransactionsView.UseVisualStyleBackColor = true;
            // 
            // BattlesView
            // 
            this.BattlesView.Location = new System.Drawing.Point(4, 22);
            this.BattlesView.Name = "BattlesView";
            this.BattlesView.Padding = new System.Windows.Forms.Padding(3);
            this.BattlesView.Size = new System.Drawing.Size(772, 531);
            this.BattlesView.TabIndex = 5;
            this.BattlesView.Text = "Battles";
            this.BattlesView.UseVisualStyleBackColor = true;
            // 
            // BattleLogsView
            // 
            this.BattleLogsView.Location = new System.Drawing.Point(4, 22);
            this.BattleLogsView.Name = "BattleLogsView";
            this.BattleLogsView.Padding = new System.Windows.Forms.Padding(3);
            this.BattleLogsView.Size = new System.Drawing.Size(772, 531);
            this.BattleLogsView.TabIndex = 6;
            this.BattleLogsView.Text = "Battle Logs";
            this.BattleLogsView.UseVisualStyleBackColor = true;
            // 
            // usersFilter
            // 
            this.usersFilter.Controls.Add(this.filterUsersByValidatedEmail);
            this.usersFilter.Location = new System.Drawing.Point(513, 137);
            this.usersFilter.Name = "usersFilter";
            this.usersFilter.Size = new System.Drawing.Size(252, 138);
            this.usersFilter.TabIndex = 3;
            this.usersFilter.TabStop = false;
            this.usersFilter.Text = "Filters";
            // 
            // filterUsersByValidatedEmail
            // 
            this.filterUsersByValidatedEmail.Location = new System.Drawing.Point(9, 20);
            this.filterUsersByValidatedEmail.Name = "filterUsersByValidatedEmail";
            this.filterUsersByValidatedEmail.Size = new System.Drawing.Size(75, 23);
            this.filterUsersByValidatedEmail.TabIndex = 0;
            this.filterUsersByValidatedEmail.Text = "Validated";
            this.filterUsersByValidatedEmail.UseVisualStyleBackColor = true;
            this.filterUsersByValidatedEmail.Click += new System.EventHandler(this.FilterUsersByValidatedEmailClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.DataTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бойцовский клуб - DataBase Viewer";
            this.DataTabs.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            this.userForm.ResumeLayout(false);
            this.userForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataView)).EndInit();
            this.usersFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
