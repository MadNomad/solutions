/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 16.02.2016
 * Time: 12:29
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Combats
{
    /// <summary>
    /// Description of Presenter.
    /// </summary>
    public class Presenter
    {
        
        GameControl game;
        MainForm app;
        
        
        public Presenter(MainForm app)
        {
            this.app = app;
        }
        
        public void StartNewGame (string name)
        {
            app.groupStartPage.Visible = false;
            this.game = new GameControl(name);
            app.labelPlayerName1.Text = game.human.Name;
            app.labelPlayerName2.Text = game.npc.Name;
            app.linePlayerHP1.Maximum = game.human.Hp;
            app.linePlayerHP2.Maximum = game.npc.Hp;
            RefreshHealthProgressBars();
            CreateRadioButtons();
            app.groupBattlePage.Visible = true;
            app.buttonNewGame.Visible = false;
        }
        
        public void NextRound (BodyPart attackPoint, BodyPart blockPoint)
        {
            game.MakeRound (attackPoint, blockPoint);
            RefreshHealthProgressBars();
        }
        
        public void ChangeName(string name)
        {
            game.ChangeName(name);
            AddToLog("Изменено имя персонажа на "+ game.human.Name);
        }
        
        /// <summary>
        /// Обновление прогрессбара с раскраской, но что бы работало нужно убрать
        /// или закомментировать в файле Program.cs строку:
        ///  Application.EnableVisualStyles();
        /// А так только стандартного для винды цвета...
        /// </summary>
        public void RefreshHealthProgressBars()
        {
            if (game.human.Hp >= 0)
            {
                app.linePlayerHP1.Value = game.human.Hp;
            }
            else
            {
                app.linePlayerHP1.Value = 0;
            }
            Int32 currentHumanLifePercent = app.linePlayerHP1.Value / app.linePlayerHP1.Maximum * 100;
            if (currentHumanLifePercent < 30)
            {
                app.linePlayerHP1.ForeColor = Color.Red;
            }
            else if (currentHumanLifePercent < 60)
            {
                app.linePlayerHP1.ForeColor = Color.Yellow;
            }
            
            if (game.npc.Hp >= 0)
            {
                app.linePlayerHP2.Value = game.npc.Hp;
            }
            else
            {
                app.linePlayerHP2.Value = 0;
            }
            Int32 currentNpcLifePercent = app.linePlayerHP2.Value / app.linePlayerHP2.Maximum * 100;
            if (currentNpcLifePercent < 30)
            {
                app.linePlayerHP2.ForeColor = Color.Red;
            }
            else if (currentNpcLifePercent < 60)
            {
                app.linePlayerHP2.ForeColor = Color.Yellow;
            }
        }
        
        public void AddToLog(string text)
        {
            app.richBattleLog.Text += text + Environment.NewLine;
        }
        
        void CreateRadioButtons()
        {
            int items = Enum.GetNames(typeof(BodyPart)).Length;
            
            RadioButton[] panelAttackChoise = new RadioButton[items];
            for (int i = 1, point = 4; i < panelAttackChoise.Length; point += 30, i++) {
                panelAttackChoise[i] = new System.Windows.Forms.RadioButton();
                panelAttackChoise[i].Location = new System.Drawing.Point(4, point);
                panelAttackChoise[i].Name = "radioAttack" + i;
                panelAttackChoise[i].Size = new System.Drawing.Size(107, 24);
                panelAttackChoise[i].TabIndex = 0;
                panelAttackChoise[i].TabStop = true;
                panelAttackChoise[i].Text = Enum.GetName(typeof(BodyPart), i);
                panelAttackChoise[i].UseVisualStyleBackColor = true;
                app.panel1.Controls.Add(panelAttackChoise[i]);
            }

            RadioButton[] panelBlockChoise = new RadioButton[items];
            for (int i = 1, point = 4; i < panelBlockChoise.Length; point += 30, i++) {
                panelBlockChoise[i] = new System.Windows.Forms.RadioButton();
                panelBlockChoise[i].Location = new System.Drawing.Point(4, point);
                panelBlockChoise[i].Name = "radioAttack" + i;
                panelBlockChoise[i].Size = new System.Drawing.Size(107, 24);
                panelBlockChoise[i].TabIndex = 0;
                panelBlockChoise[i].TabStop = true;
                panelBlockChoise[i].Text = Enum.GetName(typeof(BodyPart), i);
                panelBlockChoise[i].UseVisualStyleBackColor = true;
                app.panel2.Controls.Add(panelBlockChoise[i]);
            }
        }
    }
}
