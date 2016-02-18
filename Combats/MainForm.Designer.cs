/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:04
 */
using System.Drawing;
namespace Combats
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        public System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.RichTextBox richBattleLog;
        public System.Windows.Forms.PictureBox picturePlayer1;
        public System.Windows.Forms.PictureBox picturePlayerInfo1;
        public System.Windows.Forms.Label labelPlayerName2;
        public System.Windows.Forms.PictureBox picturePlayer2;
        public System.Windows.Forms.PictureBox picturePlayerInfo2;
        public System.Windows.Forms.ProgressBar linePlayerHP2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label labelAttackPanel;
        public System.Windows.Forms.Label labelBlockPanel;
        public System.Windows.Forms.Button buttonRound;
        public System.Windows.Forms.Button buttonNewGame;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textPlayerName1;
        public System.Windows.Forms.GroupBox groupStartPage;
        public System.Windows.Forms.GroupBox groupBattlePage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        public System.Windows.Forms.Label labelPlayerName1;
        public System.Windows.Forms.ProgressBar linePlayerHP1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label labelTopPlayers;
        public System.Windows.Forms.DataGridView dataTopPlayesTable;
        public System.Windows.Forms.Panel panelRadioButtons;
        
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textPlayerName1 = new System.Windows.Forms.TextBox();
            this.groupStartPage = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.dataTopPlayesTable = new System.Windows.Forms.DataGridView();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTopPlayers = new System.Windows.Forms.Label();
            this.groupBattlePage = new System.Windows.Forms.GroupBox();
            this.panelRadioButtons = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelAttackPanel = new System.Windows.Forms.Label();
            this.buttonRound = new System.Windows.Forms.Button();
            this.labelBlockPanel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.linePlayerHP1 = new System.Windows.Forms.ProgressBar();
            this.picturePlayerInfo1 = new System.Windows.Forms.PictureBox();
            this.linePlayerHP2 = new System.Windows.Forms.ProgressBar();
            this.picturePlayerInfo2 = new System.Windows.Forms.PictureBox();
            this.labelPlayerName1 = new System.Windows.Forms.Label();
            this.picturePlayer2 = new System.Windows.Forms.PictureBox();
            this.labelPlayerName2 = new System.Windows.Forms.Label();
            this.picturePlayer1 = new System.Windows.Forms.PictureBox();
            this.richBattleLog = new System.Windows.Forms.RichTextBox();
            this.groupStartPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTopPlayesTable)).BeginInit();
            this.groupBattlePage.SuspendLayout();
            this.panelRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerInfo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // textPlayerName1
            // 
            this.textPlayerName1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textPlayerName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textPlayerName1.Location = new System.Drawing.Point(299, 504);
            this.textPlayerName1.Name = "textPlayerName1";
            this.textPlayerName1.Size = new System.Drawing.Size(181, 22);
            this.textPlayerName1.TabIndex = 11;
            this.textPlayerName1.Text = "Player";
            this.textPlayerName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupStartPage
            // 
            this.groupStartPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupStartPage.Controls.Add(this.pictureBox1);
            this.groupStartPage.Controls.Add(this.buttonStartGame);
            this.groupStartPage.Controls.Add(this.dataTopPlayesTable);
            this.groupStartPage.Controls.Add(this.textPlayerName1);
            this.groupStartPage.Controls.Add(this.labelTopPlayers);
            this.groupStartPage.Location = new System.Drawing.Point(1, 0);
            this.groupStartPage.Margin = new System.Windows.Forms.Padding(0);
            this.groupStartPage.Name = "groupStartPage";
            this.groupStartPage.Padding = new System.Windows.Forms.Padding(0);
            this.groupStartPage.Size = new System.Drawing.Size(780, 559);
            this.groupStartPage.TabIndex = 13;
            this.groupStartPage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonStartGame.Location = new System.Drawing.Point(299, 532);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(181, 23);
            this.buttonStartGame.TabIndex = 3;
            this.buttonStartGame.Text = "В бой!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.ButtonStartGameClick);
            // 
            // dataTopPlayesTable
            // 
            this.dataTopPlayesTable.AllowUserToAddRows = false;
            this.dataTopPlayesTable.AllowUserToDeleteRows = false;
            this.dataTopPlayesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataTopPlayesTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTopPlayesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTopPlayesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTopPlayesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Place,
            this.PlayerName});
            this.dataTopPlayesTable.Location = new System.Drawing.Point(89, 257);
            this.dataTopPlayesTable.Name = "dataTopPlayesTable";
            this.dataTopPlayesTable.ReadOnly = true;
            this.dataTopPlayesTable.RowHeadersVisible = false;
            this.dataTopPlayesTable.Size = new System.Drawing.Size(600, 241);
            this.dataTopPlayesTable.TabIndex = 2;
            // 
            // Place
            // 
            this.Place.FillWeight = 12.51555F;
            this.Place.HeaderText = "Место";
            this.Place.MinimumWidth = 20;
            this.Place.Name = "Place";
            this.Place.ReadOnly = true;
            this.Place.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Place.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PlayerName
            // 
            this.PlayerName.FillWeight = 110.7626F;
            this.PlayerName.HeaderText = "Имя игрока";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // labelTopPlayers
            // 
            this.labelTopPlayers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTopPlayers.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTopPlayers.Location = new System.Drawing.Point(89, 231);
            this.labelTopPlayers.Name = "labelTopPlayers";
            this.labelTopPlayers.Size = new System.Drawing.Size(600, 23);
            this.labelTopPlayers.TabIndex = 1;
            this.labelTopPlayers.Text = "Таблица рекордов";
            this.labelTopPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBattlePage
            // 
            this.groupBattlePage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBattlePage.Controls.Add(this.panelRadioButtons);
            this.groupBattlePage.Controls.Add(this.label1);
            this.groupBattlePage.Controls.Add(this.buttonNewGame);
            this.groupBattlePage.Controls.Add(this.linePlayerHP1);
            this.groupBattlePage.Controls.Add(this.picturePlayerInfo1);
            this.groupBattlePage.Controls.Add(this.linePlayerHP2);
            this.groupBattlePage.Controls.Add(this.picturePlayerInfo2);
            this.groupBattlePage.Controls.Add(this.labelPlayerName1);
            this.groupBattlePage.Controls.Add(this.picturePlayer2);
            this.groupBattlePage.Controls.Add(this.labelPlayerName2);
            this.groupBattlePage.Controls.Add(this.picturePlayer1);
            this.groupBattlePage.Controls.Add(this.richBattleLog);
            this.groupBattlePage.Location = new System.Drawing.Point(1, 0);
            this.groupBattlePage.Margin = new System.Windows.Forms.Padding(0);
            this.groupBattlePage.Name = "groupBattlePage";
            this.groupBattlePage.Padding = new System.Windows.Forms.Padding(0);
            this.groupBattlePage.Size = new System.Drawing.Size(780, 559);
            this.groupBattlePage.TabIndex = 13;
            this.groupBattlePage.TabStop = false;
            this.groupBattlePage.Visible = false;
            // 
            // panelRadioButtons
            // 
            this.panelRadioButtons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelRadioButtons.AutoSize = true;
            this.panelRadioButtons.Controls.Add(this.panel1);
            this.panelRadioButtons.Controls.Add(this.panel2);
            this.panelRadioButtons.Controls.Add(this.labelAttackPanel);
            this.panelRadioButtons.Controls.Add(this.buttonRound);
            this.panelRadioButtons.Controls.Add(this.labelBlockPanel);
            this.panelRadioButtons.Location = new System.Drawing.Point(270, 34);
            this.panelRadioButtons.MinimumSize = new System.Drawing.Size(240, 180);
            this.panelRadioButtons.Name = "panelRadioButtons";
            this.panelRadioButtons.Size = new System.Drawing.Size(240, 180);
            this.panelRadioButtons.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.MinimumSize = new System.Drawing.Size(114, 122);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(114, 122);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(123, 53);
            this.panel2.MinimumSize = new System.Drawing.Size(114, 122);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(114, 122);
            this.panel2.TabIndex = 20;
            // 
            // labelAttackPanel
            // 
            this.labelAttackPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAttackPanel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttackPanel.Location = new System.Drawing.Point(3, 32);
            this.labelAttackPanel.Name = "labelAttackPanel";
            this.labelAttackPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelAttackPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAttackPanel.Size = new System.Drawing.Size(114, 18);
            this.labelAttackPanel.TabIndex = 23;
            this.labelAttackPanel.Text = "Атака";
            this.labelAttackPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRound
            // 
            this.buttonRound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRound.Location = new System.Drawing.Point(67, 6);
            this.buttonRound.Name = "buttonRound";
            this.buttonRound.Size = new System.Drawing.Size(107, 23);
            this.buttonRound.TabIndex = 24;
            this.buttonRound.Text = "Атаковать";
            this.buttonRound.UseVisualStyleBackColor = false;
            this.buttonRound.Click += new System.EventHandler(this.ButtonRoundClick);
            // 
            // labelBlockPanel
            // 
            this.labelBlockPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelBlockPanel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBlockPanel.Location = new System.Drawing.Point(123, 32);
            this.labelBlockPanel.Name = "labelBlockPanel";
            this.labelBlockPanel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.labelBlockPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelBlockPanel.Size = new System.Drawing.Size(114, 18);
            this.labelBlockPanel.TabIndex = 22;
            this.labelBlockPanel.Text = "Блок";
            this.labelBlockPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 260);
            this.label1.MaximumSize = new System.Drawing.Size(234, 40);
            this.label1.MinimumSize = new System.Drawing.Size(234, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 40);
            this.label1.TabIndex = 26;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNewGame.Location = new System.Drawing.Point(337, 303);
            this.buttonNewGame.MaximumSize = new System.Drawing.Size(107, 23);
            this.buttonNewGame.MinimumSize = new System.Drawing.Size(107, 23);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(107, 23);
            this.buttonNewGame.TabIndex = 25;
            this.buttonNewGame.Text = "Новый бой";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Visible = false;
            // 
            // linePlayerHP1
            // 
            this.linePlayerHP1.ForeColor = System.Drawing.Color.Green;
            this.linePlayerHP1.Location = new System.Drawing.Point(59, 34);
            this.linePlayerHP1.Name = "linePlayerHP1";
            this.linePlayerHP1.Size = new System.Drawing.Size(128, 15);
            this.linePlayerHP1.Step = 1;
            this.linePlayerHP1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.linePlayerHP1.TabIndex = 18;
            // 
            // picturePlayerInfo1
            // 
            this.picturePlayerInfo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePlayerInfo1.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayerInfo1.Image")));
            this.picturePlayerInfo1.Location = new System.Drawing.Point(65, 19);
            this.picturePlayerInfo1.Name = "picturePlayerInfo1";
            this.picturePlayerInfo1.Size = new System.Drawing.Size(12, 11);
            this.picturePlayerInfo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePlayerInfo1.TabIndex = 16;
            this.picturePlayerInfo1.TabStop = false;
            // 
            // linePlayerHP2
            // 
            this.linePlayerHP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linePlayerHP2.ForeColor = System.Drawing.Color.Green;
            this.linePlayerHP2.Location = new System.Drawing.Point(592, 34);
            this.linePlayerHP2.Name = "linePlayerHP2";
            this.linePlayerHP2.Size = new System.Drawing.Size(128, 15);
            this.linePlayerHP2.Step = 1;
            this.linePlayerHP2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.linePlayerHP2.TabIndex = 19;
            // 
            // picturePlayerInfo2
            // 
            this.picturePlayerInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePlayerInfo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturePlayerInfo2.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayerInfo2.Image")));
            this.picturePlayerInfo2.Location = new System.Drawing.Point(598, 19);
            this.picturePlayerInfo2.Name = "picturePlayerInfo2";
            this.picturePlayerInfo2.Size = new System.Drawing.Size(12, 11);
            this.picturePlayerInfo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePlayerInfo2.TabIndex = 17;
            this.picturePlayerInfo2.TabStop = false;
            // 
            // labelPlayerName1
            // 
            this.labelPlayerName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerName1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPlayerName1.Location = new System.Drawing.Point(77, 17);
            this.labelPlayerName1.Name = "labelPlayerName1";
            this.labelPlayerName1.Size = new System.Drawing.Size(110, 14);
            this.labelPlayerName1.TabIndex = 12;
            this.labelPlayerName1.Text = "Player";
            this.labelPlayerName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picturePlayer2
            // 
            this.picturePlayer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePlayer2.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayer2.Image")));
            this.picturePlayer2.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturePlayer2.InitialImage")));
            this.picturePlayer2.Location = new System.Drawing.Point(592, 55);
            this.picturePlayer2.Name = "picturePlayer2";
            this.picturePlayer2.Size = new System.Drawing.Size(128, 128);
            this.picturePlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePlayer2.TabIndex = 14;
            this.picturePlayer2.TabStop = false;
            // 
            // labelPlayerName2
            // 
            this.labelPlayerName2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayerName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerName2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPlayerName2.Location = new System.Drawing.Point(610, 17);
            this.labelPlayerName2.Name = "labelPlayerName2";
            this.labelPlayerName2.Size = new System.Drawing.Size(110, 14);
            this.labelPlayerName2.TabIndex = 13;
            this.labelPlayerName2.Text = "Player";
            this.labelPlayerName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picturePlayer1
            // 
            this.picturePlayer1.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayer1.Image")));
            this.picturePlayer1.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturePlayer1.InitialImage")));
            this.picturePlayer1.Location = new System.Drawing.Point(59, 60);
            this.picturePlayer1.Name = "picturePlayer1";
            this.picturePlayer1.Size = new System.Drawing.Size(128, 128);
            this.picturePlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePlayer1.TabIndex = 15;
            this.picturePlayer1.TabStop = false;
            // 
            // richBattleLog
            // 
            this.richBattleLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richBattleLog.Location = new System.Drawing.Point(11, 341);
            this.richBattleLog.Name = "richBattleLog";
            this.richBattleLog.Size = new System.Drawing.Size(759, 200);
            this.richBattleLog.TabIndex = 11;
            this.richBattleLog.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBattlePage);
            this.Controls.Add(this.groupStartPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бойцовский клуб";
            this.groupStartPage.ResumeLayout(false);
            this.groupStartPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTopPlayesTable)).EndInit();
            this.groupBattlePage.ResumeLayout(false);
            this.groupBattlePage.PerformLayout();
            this.panelRadioButtons.ResumeLayout(false);
            this.panelRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayerInfo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
