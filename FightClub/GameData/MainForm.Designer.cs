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
        protected internal System.Windows.Forms.DataGridView UsersDataView;
        private System.Windows.Forms.GroupBox UserForm;
        private System.Windows.Forms.Label UserEmailText;
        private System.Windows.Forms.TextBox UserEmail;
        private System.Windows.Forms.Label UserPasswordText;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Label UserLoginText;
        private System.Windows.Forms.TextBox UserLogin;
        private System.Windows.Forms.CheckBox IsEmailValid;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Label UserIdText;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.Label DateText;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label PlayerIdText;
        private System.Windows.Forms.TextBox PlayerId;
        
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
            this.UserForm = new System.Windows.Forms.GroupBox();
            this.DateText = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.PlayerIdText = new System.Windows.Forms.Label();
            this.PlayerId = new System.Windows.Forms.TextBox();
            this.UserIdText = new System.Windows.Forms.Label();
            this.UserId = new System.Windows.Forms.TextBox();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.EditUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.IsEmailValid = new System.Windows.Forms.CheckBox();
            this.UserEmailText = new System.Windows.Forms.Label();
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.UserPasswordText = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.UserLoginText = new System.Windows.Forms.Label();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.LoadUsersData = new System.Windows.Forms.Button();
            this.UsersDataView = new System.Windows.Forms.DataGridView();
            this.PlayersTab = new System.Windows.Forms.TabPage();
            this.TransactionsView = new System.Windows.Forms.TabPage();
            this.BattlesView = new System.Windows.Forms.TabPage();
            this.BattleLogsView = new System.Windows.Forms.TabPage();
            this.DataTabs.SuspendLayout();
            this.UsersTab.SuspendLayout();
            this.UserForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataView)).BeginInit();
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
            this.UsersTab.Controls.Add(this.UserForm);
            this.UsersTab.Controls.Add(this.LoadUsersData);
            this.UsersTab.Controls.Add(this.UsersDataView);
            this.UsersTab.Location = new System.Drawing.Point(4, 22);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(772, 531);
            this.UsersTab.TabIndex = 2;
            this.UsersTab.Text = "Users";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.UserForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserForm.Controls.Add(this.DateText);
            this.UserForm.Controls.Add(this.Date);
            this.UserForm.Controls.Add(this.PlayerIdText);
            this.UserForm.Controls.Add(this.PlayerId);
            this.UserForm.Controls.Add(this.UserIdText);
            this.UserForm.Controls.Add(this.UserId);
            this.UserForm.Controls.Add(this.DeleteUser);
            this.UserForm.Controls.Add(this.EditUser);
            this.UserForm.Controls.Add(this.AddUser);
            this.UserForm.Controls.Add(this.IsEmailValid);
            this.UserForm.Controls.Add(this.UserEmailText);
            this.UserForm.Controls.Add(this.UserEmail);
            this.UserForm.Controls.Add(this.UserPasswordText);
            this.UserForm.Controls.Add(this.UserPassword);
            this.UserForm.Controls.Add(this.UserLoginText);
            this.UserForm.Controls.Add(this.UserLogin);
            this.UserForm.Location = new System.Drawing.Point(513, 229);
            this.UserForm.Name = "UserForm";
            this.UserForm.Size = new System.Drawing.Size(252, 296);
            this.UserForm.TabIndex = 2;
            this.UserForm.TabStop = false;
            this.UserForm.Text = "User";
            // 
            // DateText
            // 
            this.DateText.Location = new System.Drawing.Point(7, 71);
            this.DateText.Name = "DateText";
            this.DateText.Size = new System.Drawing.Size(79, 20);
            this.DateText.TabIndex = 15;
            this.DateText.Text = "Date";
            this.DateText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(92, 71);
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Size = new System.Drawing.Size(154, 20);
            this.Date.TabIndex = 14;
            // 
            // PlayerIdText
            // 
            this.PlayerIdText.Location = new System.Drawing.Point(7, 45);
            this.PlayerIdText.Name = "PlayerIdText";
            this.PlayerIdText.Size = new System.Drawing.Size(79, 20);
            this.PlayerIdText.TabIndex = 13;
            this.PlayerIdText.Text = "Player ID";
            this.PlayerIdText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayerId
            // 
            this.PlayerId.Location = new System.Drawing.Point(92, 45);
            this.PlayerId.Name = "PlayerId";
            this.PlayerId.ReadOnly = true;
            this.PlayerId.Size = new System.Drawing.Size(154, 20);
            this.PlayerId.TabIndex = 12;
            // 
            // UserIdText
            // 
            this.UserIdText.Location = new System.Drawing.Point(7, 19);
            this.UserIdText.Name = "UserIdText";
            this.UserIdText.Size = new System.Drawing.Size(79, 20);
            this.UserIdText.TabIndex = 11;
            this.UserIdText.Text = "ID";
            this.UserIdText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserId
            // 
            this.UserId.Location = new System.Drawing.Point(92, 19);
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Size = new System.Drawing.Size(154, 20);
            this.UserId.TabIndex = 10;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteUser.ForeColor = System.Drawing.Color.OrangeRed;
            this.DeleteUser.Location = new System.Drawing.Point(171, 187);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(75, 23);
            this.DeleteUser.TabIndex = 9;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.UseVisualStyleBackColor = true;
            // 
            // EditUser
            // 
            this.EditUser.Location = new System.Drawing.Point(90, 187);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(75, 23);
            this.EditUser.TabIndex = 8;
            this.EditUser.Text = "Edit";
            this.EditUser.UseVisualStyleBackColor = true;
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(9, 187);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(75, 23);
            this.AddUser.TabIndex = 7;
            this.AddUser.Text = "Add";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUserClick);
            // 
            // IsEmailValid
            // 
            this.IsEmailValid.Location = new System.Drawing.Point(75, 151);
            this.IsEmailValid.Margin = new System.Windows.Forms.Padding(0);
            this.IsEmailValid.Name = "IsEmailValid";
            this.IsEmailValid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.IsEmailValid.Size = new System.Drawing.Size(14, 19);
            this.IsEmailValid.TabIndex = 6;
            this.IsEmailValid.Text = "Validated?";
            this.IsEmailValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IsEmailValid.UseVisualStyleBackColor = true;
            // 
            // UserEmailText
            // 
            this.UserEmailText.Location = new System.Drawing.Point(7, 149);
            this.UserEmailText.Name = "UserEmailText";
            this.UserEmailText.Size = new System.Drawing.Size(79, 20);
            this.UserEmailText.TabIndex = 5;
            this.UserEmailText.Text = "E-Mail";
            this.UserEmailText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserEmail
            // 
            this.UserEmail.Location = new System.Drawing.Point(92, 149);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(154, 20);
            this.UserEmail.TabIndex = 4;
            // 
            // UserPasswordText
            // 
            this.UserPasswordText.Location = new System.Drawing.Point(7, 123);
            this.UserPasswordText.Name = "UserPasswordText";
            this.UserPasswordText.Size = new System.Drawing.Size(79, 20);
            this.UserPasswordText.TabIndex = 3;
            this.UserPasswordText.Text = "Password";
            this.UserPasswordText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserPassword
            // 
            this.UserPassword.Location = new System.Drawing.Point(92, 123);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.Size = new System.Drawing.Size(154, 20);
            this.UserPassword.TabIndex = 2;
            // 
            // UserLoginText
            // 
            this.UserLoginText.Location = new System.Drawing.Point(7, 97);
            this.UserLoginText.Name = "UserLoginText";
            this.UserLoginText.Size = new System.Drawing.Size(79, 20);
            this.UserLoginText.TabIndex = 1;
            this.UserLoginText.Text = "Login";
            this.UserLoginText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserLogin
            // 
            this.UserLogin.Location = new System.Drawing.Point(92, 97);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(154, 20);
            this.UserLogin.TabIndex = 0;
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
            // UsersDataView
            // 
            this.UsersDataView.AllowUserToAddRows = false;
            this.UsersDataView.AllowUserToDeleteRows = false;
            this.UsersDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataView.Location = new System.Drawing.Point(6, 4);
            this.UsersDataView.Name = "UsersDataView";
            this.UsersDataView.ReadOnly = true;
            this.UsersDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.UsersDataView.Size = new System.Drawing.Size(500, 524);
            this.UsersDataView.TabIndex = 0;
            this.UsersDataView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UsersDataViewCellMouseDoubleClick);
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
            this.UserForm.ResumeLayout(false);
            this.UserForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
