/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:04
 */
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
		public System.Windows.Forms.ProgressBar pbPlayerHP1;
		public System.Windows.Forms.ProgressBar linePlayerHP2;
		public System.Windows.Forms.RadioButton radioAttack1;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.RadioButton radioAttack3;
		public System.Windows.Forms.RadioButton radioAttack2;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.RadioButton radioBlock3;
		public System.Windows.Forms.RadioButton radioBlock2;
		public System.Windows.Forms.RadioButton radioBlock1;
		public System.Windows.Forms.Label labelAttackPanel;
		public System.Windows.Forms.Label labelBlockPanel;
		public System.Windows.Forms.Button buttonRound;
		public System.Windows.Forms.Button buttonNewGame;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox textPlayerName1;
		private System.Windows.Forms.Button buttonChangeName1;
		
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
			this.richBattleLog = new System.Windows.Forms.RichTextBox();
			this.picturePlayer1 = new System.Windows.Forms.PictureBox();
			this.picturePlayerInfo1 = new System.Windows.Forms.PictureBox();
			this.labelPlayerName2 = new System.Windows.Forms.Label();
			this.picturePlayer2 = new System.Windows.Forms.PictureBox();
			this.picturePlayerInfo2 = new System.Windows.Forms.PictureBox();
			this.pbPlayerHP1 = new System.Windows.Forms.ProgressBar();
			this.linePlayerHP2 = new System.Windows.Forms.ProgressBar();
			this.radioAttack1 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioAttack3 = new System.Windows.Forms.RadioButton();
			this.radioAttack2 = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.radioBlock3 = new System.Windows.Forms.RadioButton();
			this.radioBlock2 = new System.Windows.Forms.RadioButton();
			this.radioBlock1 = new System.Windows.Forms.RadioButton();
			this.labelAttackPanel = new System.Windows.Forms.Label();
			this.labelBlockPanel = new System.Windows.Forms.Label();
			this.buttonRound = new System.Windows.Forms.Button();
			this.buttonNewGame = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textPlayerName1 = new System.Windows.Forms.TextBox();
			this.buttonChangeName1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picturePlayer1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePlayerInfo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePlayer2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePlayerInfo2)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// richBattleLog
			// 
			this.richBattleLog.Location = new System.Drawing.Point(13, 330);
			this.richBattleLog.Name = "richBattleLog";
			this.richBattleLog.Size = new System.Drawing.Size(759, 220);
			this.richBattleLog.TabIndex = 0;
			this.richBattleLog.Text = "";
			// 
			// picturePlayer1
			// 
			this.picturePlayer1.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayer1.Image")));
			this.picturePlayer1.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturePlayer1.InitialImage")));
			this.picturePlayer1.Location = new System.Drawing.Point(45, 59);
			this.picturePlayer1.Name = "picturePlayer1";
			this.picturePlayer1.Size = new System.Drawing.Size(128, 128);
			this.picturePlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picturePlayer1.TabIndex = 2;
			this.picturePlayer1.TabStop = false;
			// 
			// picturePlayerInfo1
			// 
			this.picturePlayerInfo1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picturePlayerInfo1.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayerInfo1.Image")));
			this.picturePlayerInfo1.Location = new System.Drawing.Point(51, 23);
			this.picturePlayerInfo1.Name = "picturePlayerInfo1";
			this.picturePlayerInfo1.Size = new System.Drawing.Size(12, 11);
			this.picturePlayerInfo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picturePlayerInfo1.TabIndex = 3;
			this.picturePlayerInfo1.TabStop = false;
			// 
			// labelPlayerName2
			// 
			this.labelPlayerName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPlayerName2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelPlayerName2.Location = new System.Drawing.Point(628, 21);
			this.labelPlayerName2.Name = "labelPlayerName2";
			this.labelPlayerName2.Size = new System.Drawing.Size(110, 14);
			this.labelPlayerName2.TabIndex = 1;
			this.labelPlayerName2.Text = "Player";
			this.labelPlayerName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picturePlayer2
			// 
			this.picturePlayer2.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayer2.Image")));
			this.picturePlayer2.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturePlayer2.InitialImage")));
			this.picturePlayer2.Location = new System.Drawing.Point(610, 59);
			this.picturePlayer2.Name = "picturePlayer2";
			this.picturePlayer2.Size = new System.Drawing.Size(128, 128);
			this.picturePlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picturePlayer2.TabIndex = 2;
			this.picturePlayer2.TabStop = false;
			// 
			// picturePlayerInfo2
			// 
			this.picturePlayerInfo2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picturePlayerInfo2.Image = ((System.Drawing.Image)(resources.GetObject("picturePlayerInfo2.Image")));
			this.picturePlayerInfo2.Location = new System.Drawing.Point(616, 23);
			this.picturePlayerInfo2.Name = "picturePlayerInfo2";
			this.picturePlayerInfo2.Size = new System.Drawing.Size(12, 11);
			this.picturePlayerInfo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picturePlayerInfo2.TabIndex = 3;
			this.picturePlayerInfo2.TabStop = false;
			// 
			// pbPlayerHP1
			// 
			this.pbPlayerHP1.Location = new System.Drawing.Point(45, 38);
			this.pbPlayerHP1.Name = "pbPlayerHP1";
			this.pbPlayerHP1.Size = new System.Drawing.Size(128, 15);
			this.pbPlayerHP1.TabIndex = 4;
			// 
			// linePlayerHP2
			// 
			this.linePlayerHP2.Location = new System.Drawing.Point(610, 38);
			this.linePlayerHP2.Name = "linePlayerHP2";
			this.linePlayerHP2.Size = new System.Drawing.Size(128, 15);
			this.linePlayerHP2.TabIndex = 4;
			// 
			// radioAttack1
			// 
			this.radioAttack1.Location = new System.Drawing.Point(4, 4);
			this.radioAttack1.Name = "radioAttack1";
			this.radioAttack1.Size = new System.Drawing.Size(107, 24);
			this.radioAttack1.TabIndex = 5;
			this.radioAttack1.TabStop = true;
			this.radioAttack1.Text = "Голова";
			this.radioAttack1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.radioAttack3);
			this.panel1.Controls.Add(this.radioAttack2);
			this.panel1.Controls.Add(this.radioAttack1);
			this.panel1.Location = new System.Drawing.Point(262, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(114, 122);
			this.panel1.TabIndex = 6;
			// 
			// radioAttack3
			// 
			this.radioAttack3.Location = new System.Drawing.Point(4, 64);
			this.radioAttack3.Name = "radioAttack3";
			this.radioAttack3.Size = new System.Drawing.Size(107, 24);
			this.radioAttack3.TabIndex = 7;
			this.radioAttack3.TabStop = true;
			this.radioAttack3.Text = "Ноги";
			this.radioAttack3.UseVisualStyleBackColor = true;
			// 
			// radioAttack2
			// 
			this.radioAttack2.Location = new System.Drawing.Point(4, 34);
			this.radioAttack2.Name = "radioAttack2";
			this.radioAttack2.Size = new System.Drawing.Size(107, 24);
			this.radioAttack2.TabIndex = 6;
			this.radioAttack2.TabStop = true;
			this.radioAttack2.Text = "Корпус";
			this.radioAttack2.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.radioBlock3);
			this.panel2.Controls.Add(this.radioBlock2);
			this.panel2.Controls.Add(this.radioBlock1);
			this.panel2.Location = new System.Drawing.Point(382, 59);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(114, 122);
			this.panel2.TabIndex = 6;
			// 
			// radioBlock3
			// 
			this.radioBlock3.Location = new System.Drawing.Point(4, 64);
			this.radioBlock3.Name = "radioBlock3";
			this.radioBlock3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.radioBlock3.Size = new System.Drawing.Size(107, 24);
			this.radioBlock3.TabIndex = 7;
			this.radioBlock3.TabStop = true;
			this.radioBlock3.Text = "Ноги";
			this.radioBlock3.UseVisualStyleBackColor = true;
			// 
			// radioBlock2
			// 
			this.radioBlock2.Location = new System.Drawing.Point(4, 34);
			this.radioBlock2.Name = "radioBlock2";
			this.radioBlock2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.radioBlock2.Size = new System.Drawing.Size(107, 24);
			this.radioBlock2.TabIndex = 6;
			this.radioBlock2.TabStop = true;
			this.radioBlock2.Text = "Корпус";
			this.radioBlock2.UseVisualStyleBackColor = true;
			// 
			// radioBlock1
			// 
			this.radioBlock1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.radioBlock1.Location = new System.Drawing.Point(4, 4);
			this.radioBlock1.Name = "radioBlock1";
			this.radioBlock1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.radioBlock1.Size = new System.Drawing.Size(107, 24);
			this.radioBlock1.TabIndex = 5;
			this.radioBlock1.TabStop = true;
			this.radioBlock1.Text = "Голова";
			this.radioBlock1.UseVisualStyleBackColor = true;
			// 
			// labelAttackPanel
			// 
			this.labelAttackPanel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelAttackPanel.Location = new System.Drawing.Point(262, 38);
			this.labelAttackPanel.Name = "labelAttackPanel";
			this.labelAttackPanel.Size = new System.Drawing.Size(114, 18);
			this.labelAttackPanel.TabIndex = 7;
			this.labelAttackPanel.Text = "Атака";
			this.labelAttackPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBlockPanel
			// 
			this.labelBlockPanel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBlockPanel.Location = new System.Drawing.Point(382, 38);
			this.labelBlockPanel.Name = "labelBlockPanel";
			this.labelBlockPanel.Size = new System.Drawing.Size(114, 18);
			this.labelBlockPanel.TabIndex = 7;
			this.labelBlockPanel.Text = "Блок";
			this.labelBlockPanel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buttonRound
			// 
			this.buttonRound.Location = new System.Drawing.Point(327, 187);
			this.buttonRound.Name = "buttonRound";
			this.buttonRound.Size = new System.Drawing.Size(107, 23);
			this.buttonRound.TabIndex = 8;
			this.buttonRound.Text = "Следующий раунд";
			this.buttonRound.UseVisualStyleBackColor = true;
			// 
			// buttonNewGame
			// 
			this.buttonNewGame.Location = new System.Drawing.Point(327, 256);
			this.buttonNewGame.Name = "buttonNewGame";
			this.buttonNewGame.Size = new System.Drawing.Size(107, 23);
			this.buttonNewGame.TabIndex = 9;
			this.buttonNewGame.Text = "Новый бой";
			this.buttonNewGame.UseVisualStyleBackColor = true;
			this.buttonNewGame.Visible = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(262, 213);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(234, 40);
			this.label1.TabIndex = 10;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textPlayerName1
			// 
			this.textPlayerName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textPlayerName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textPlayerName1.Location = new System.Drawing.Point(69, 22);
			this.textPlayerName1.Name = "textPlayerName1";
			this.textPlayerName1.Size = new System.Drawing.Size(80, 13);
			this.textPlayerName1.TabIndex = 11;
			this.textPlayerName1.Text = "Player";
			// 
			// buttonChangeName1
			// 
			this.buttonChangeName1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonChangeName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonChangeName1.Location = new System.Drawing.Point(153, 21);
			this.buttonChangeName1.Margin = new System.Windows.Forms.Padding(0);
			this.buttonChangeName1.Name = "buttonChangeName1";
			this.buttonChangeName1.Size = new System.Drawing.Size(18, 15);
			this.buttonChangeName1.TabIndex = 12;
			this.buttonChangeName1.Text = "OK";
			this.buttonChangeName1.UseVisualStyleBackColor = true;
			this.buttonChangeName1.Click += new System.EventHandler(this.ButtonChangeName1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.buttonChangeName1);
			this.Controls.Add(this.textPlayerName1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonNewGame);
			this.Controls.Add(this.buttonRound);
			this.Controls.Add(this.labelBlockPanel);
			this.Controls.Add(this.labelAttackPanel);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.linePlayerHP2);
			this.Controls.Add(this.pbPlayerHP1);
			this.Controls.Add(this.picturePlayerInfo2);
			this.Controls.Add(this.picturePlayerInfo1);
			this.Controls.Add(this.picturePlayer2);
			this.Controls.Add(this.labelPlayerName2);
			this.Controls.Add(this.picturePlayer1);
			this.Controls.Add(this.richBattleLog);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Бойцовский клуб";
			((System.ComponentModel.ISupportInitialize)(this.picturePlayer1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePlayerInfo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePlayer2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picturePlayerInfo2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
