/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 09.02.2016
 * Time: 22:27
 */
namespace Combats
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox startWindow;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.PictureBox startLogo;
		private System.Windows.Forms.GroupBox groupBoxGenStats;
		private System.Windows.Forms.NumericUpDown numericUpDownStrength;
		private System.Windows.Forms.Label labelFreeStats;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelTextStrength;
		private System.Windows.Forms.Label labelTextConstitution;
		private System.Windows.Forms.Label labelTextIntuition;
		private System.Windows.Forms.Label labelTextAgility;
		private System.Windows.Forms.NumericUpDown numericUpDownConstitution;
		private System.Windows.Forms.NumericUpDown numericUpDownIntuition;
		private System.Windows.Forms.NumericUpDown numericUpDownAgility;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.GroupBox groupFight;
		private System.Windows.Forms.Label label2;
		
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
			this.startWindow = new System.Windows.Forms.GroupBox();
			this.groupBoxGenStats = new System.Windows.Forms.GroupBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.labelTextConstitution = new System.Windows.Forms.Label();
			this.labelTextIntuition = new System.Windows.Forms.Label();
			this.labelTextAgility = new System.Windows.Forms.Label();
			this.labelTextStrength = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDownConstitution = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownIntuition = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownAgility = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownStrength = new System.Windows.Forms.NumericUpDown();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelFreeStats = new System.Windows.Forms.Label();
			this.groupFight = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.startLogo = new System.Windows.Forms.PictureBox();
			this.startWindow.SuspendLayout();
			this.groupBoxGenStats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownConstitution)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntuition)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgility)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrength)).BeginInit();
			this.groupFight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.startLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// startWindow
			// 
			this.startWindow.Controls.Add(this.groupBoxGenStats);
			this.startWindow.Controls.Add(this.groupFight);
			this.startWindow.Controls.Add(this.startLogo);
			this.startWindow.Location = new System.Drawing.Point(2, 0);
			this.startWindow.Name = "startWindow";
			this.startWindow.Size = new System.Drawing.Size(780, 558);
			this.startWindow.TabIndex = 0;
			this.startWindow.TabStop = false;
			// 
			// groupBoxGenStats
			// 
			this.groupBoxGenStats.Controls.Add(this.buttonStart);
			this.groupBoxGenStats.Controls.Add(this.labelTextConstitution);
			this.groupBoxGenStats.Controls.Add(this.labelTextIntuition);
			this.groupBoxGenStats.Controls.Add(this.labelTextAgility);
			this.groupBoxGenStats.Controls.Add(this.labelTextStrength);
			this.groupBoxGenStats.Controls.Add(this.label1);
			this.groupBoxGenStats.Controls.Add(this.numericUpDownConstitution);
			this.groupBoxGenStats.Controls.Add(this.numericUpDownIntuition);
			this.groupBoxGenStats.Controls.Add(this.numericUpDownAgility);
			this.groupBoxGenStats.Controls.Add(this.numericUpDownStrength);
			this.groupBoxGenStats.Controls.Add(this.textBoxName);
			this.groupBoxGenStats.Controls.Add(this.labelFreeStats);
			this.groupBoxGenStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBoxGenStats.Location = new System.Drawing.Point(298, 171);
			this.groupBoxGenStats.Name = "groupBoxGenStats";
			this.groupBoxGenStats.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBoxGenStats.Size = new System.Drawing.Size(224, 251);
			this.groupBoxGenStats.TabIndex = 1;
			this.groupBoxGenStats.TabStop = false;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(66, 200);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(94, 23);
			this.buttonStart.TabIndex = 3;
			this.buttonStart.Tag = "";
			this.buttonStart.Text = "В бой!";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.ButtonStartClick);
			// 
			// labelTextConstitution
			// 
			this.labelTextConstitution.Location = new System.Drawing.Point(50, 123);
			this.labelTextConstitution.Name = "labelTextConstitution";
			this.labelTextConstitution.Size = new System.Drawing.Size(70, 20);
			this.labelTextConstitution.TabIndex = 2;
			this.labelTextConstitution.Text = "Сложение";
			this.labelTextConstitution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelTextIntuition
			// 
			this.labelTextIntuition.Location = new System.Drawing.Point(50, 97);
			this.labelTextIntuition.Name = "labelTextIntuition";
			this.labelTextIntuition.Size = new System.Drawing.Size(70, 20);
			this.labelTextIntuition.TabIndex = 2;
			this.labelTextIntuition.Text = "Интуиция";
			this.labelTextIntuition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelTextAgility
			// 
			this.labelTextAgility.Location = new System.Drawing.Point(50, 71);
			this.labelTextAgility.Name = "labelTextAgility";
			this.labelTextAgility.Size = new System.Drawing.Size(70, 20);
			this.labelTextAgility.TabIndex = 2;
			this.labelTextAgility.Text = "Ловкость";
			this.labelTextAgility.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelTextStrength
			// 
			this.labelTextStrength.Location = new System.Drawing.Point(50, 45);
			this.labelTextStrength.Name = "labelTextStrength";
			this.labelTextStrength.Size = new System.Drawing.Size(70, 20);
			this.labelTextStrength.TabIndex = 2;
			this.labelTextStrength.Text = "Сила";
			this.labelTextStrength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Имя бойца";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// numericUpDownConstitution
			// 
			this.numericUpDownConstitution.Location = new System.Drawing.Point(126, 123);
			this.numericUpDownConstitution.Maximum = new decimal(new int[] {
			8,
			0,
			0,
			0});
			this.numericUpDownConstitution.Minimum = new decimal(new int[] {
			3,
			0,
			0,
			0});
			this.numericUpDownConstitution.Name = "numericUpDownConstitution";
			this.numericUpDownConstitution.Size = new System.Drawing.Size(34, 20);
			this.numericUpDownConstitution.TabIndex = 1;
			this.numericUpDownConstitution.Value = new decimal(new int[] {
			3,
			0,
			0,
			0});
			// 
			// numericUpDownIntuition
			// 
			this.numericUpDownIntuition.Location = new System.Drawing.Point(126, 97);
			this.numericUpDownIntuition.Maximum = new decimal(new int[] {
			8,
			0,
			0,
			0});
			this.numericUpDownIntuition.Minimum = new decimal(new int[] {
			3,
			0,
			0,
			0});
			this.numericUpDownIntuition.Name = "numericUpDownIntuition";
			this.numericUpDownIntuition.Size = new System.Drawing.Size(34, 20);
			this.numericUpDownIntuition.TabIndex = 1;
			this.numericUpDownIntuition.Value = new decimal(new int[] {
			3,
			0,
			0,
			0});
			// 
			// numericUpDownAgility
			// 
			this.numericUpDownAgility.Location = new System.Drawing.Point(126, 71);
			this.numericUpDownAgility.Maximum = new decimal(new int[] {
			8,
			0,
			0,
			0});
			this.numericUpDownAgility.Minimum = new decimal(new int[] {
			3,
			0,
			0,
			0});
			this.numericUpDownAgility.Name = "numericUpDownAgility";
			this.numericUpDownAgility.Size = new System.Drawing.Size(34, 20);
			this.numericUpDownAgility.TabIndex = 1;
			this.numericUpDownAgility.Value = new decimal(new int[] {
			3,
			0,
			0,
			0});
			// 
			// numericUpDownStrength
			// 
			this.numericUpDownStrength.Location = new System.Drawing.Point(126, 45);
			this.numericUpDownStrength.Maximum = new decimal(new int[] {
			8,
			0,
			0,
			0});
			this.numericUpDownStrength.Minimum = new decimal(new int[] {
			3,
			0,
			0,
			0});
			this.numericUpDownStrength.Name = "numericUpDownStrength";
			this.numericUpDownStrength.Size = new System.Drawing.Size(34, 20);
			this.numericUpDownStrength.TabIndex = 1;
			this.numericUpDownStrength.Value = new decimal(new int[] {
			3,
			0,
			0,
			0});
			this.numericUpDownStrength.ValueChanged += new System.EventHandler(this.NumericUpDownStrengthValueChanged);
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(72, 19);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(142, 20);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.Text = "Jack";
			// 
			// labelFreeStats
			// 
			this.labelFreeStats.Location = new System.Drawing.Point(6, 166);
			this.labelFreeStats.Name = "labelFreeStats";
			this.labelFreeStats.Size = new System.Drawing.Size(212, 21);
			this.labelFreeStats.TabIndex = 0;
			this.labelFreeStats.Text = "Осталось {0} свободных пунктов";
			this.labelFreeStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupFight
			// 
			this.groupFight.Controls.Add(this.label2);
			this.groupFight.Location = new System.Drawing.Point(555, 268);
			this.groupFight.Name = "groupFight";
			this.groupFight.Size = new System.Drawing.Size(225, 290);
			this.groupFight.TabIndex = 4;
			this.groupFight.TabStop = false;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(56, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Test";
			// 
			// startLogo
			// 
			this.startLogo.Image = ((System.Drawing.Image)(resources.GetObject("startLogo.Image")));
			this.startLogo.Location = new System.Drawing.Point(336, 19);
			this.startLogo.Name = "startLogo";
			this.startLogo.Size = new System.Drawing.Size(128, 128);
			this.startLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.startLogo.TabIndex = 0;
			this.startLogo.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.startWindow);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Бойцовский клуб";
			this.startWindow.ResumeLayout(false);
			this.startWindow.PerformLayout();
			this.groupBoxGenStats.ResumeLayout(false);
			this.groupBoxGenStats.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownConstitution)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntuition)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgility)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStrength)).EndInit();
			this.groupFight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.startLogo)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
