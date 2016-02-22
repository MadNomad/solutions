﻿/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 16.02.2016
 * Time: 12:29
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Text;
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
        protected string ratingFilePath = (Directory.GetCurrentDirectory() + @"\data\records\top.csv");
        GameControl game;
        MainForm app;
        protected Dictionary<string, int> rating;
        
        public event EventHandler Dead;
        
        
        public Presenter(MainForm app)
        {
            this.app = app;
            ShowRecordsInTable();
        }
        
        public void StartNewGame(string name)
        {
            app.groupStartPage.Visible = false;
            this.game = new GameControl(name);
            app.labelPlayerName1.Text = game.Human.Name;
            app.labelPlayerName2.Text = game.Npc.Name;
            app.linePlayerHP1.Maximum = game.Human.Hp;
            app.linePlayerHP2.Maximum = game.Npc.Hp;
            app.buttonNewGame.Visible = false;
            app.groupBattlePage.Visible = true;
            RefreshHealthProgressBars();
            CreateRadioButtons();
        }
        
        public void NextRound(string attackPoint, string blockPoint)
        {
            ParseInputLog(
                game.MakeRound(
                    (BodyPart)Enum.Parse(typeof(BodyPart), attackPoint),
                    (BodyPart)Enum.Parse(typeof(BodyPart), blockPoint)
                   )
               );
            RefreshHealthProgressBars();
        }
        
        public void ChangeName(string name)
        {
            game.ChangeName(name);
            AddToLog("Изменено имя персонажа на " + game.Human.Name);
        }
        
        /// <summary>
        /// Обновление прогрессбара с раскраской, но что бы работало нужно убрать
        /// или закомментировать в файле Program.cs строку:
        ///  Application.EnableVisualStyles();
        /// А так только стандартного для винды цвета...
        /// </summary>
        public void RefreshHealthProgressBars()
        {
            if (game.Human.Hp >= 0)
            {
                app.linePlayerHP1.Value = game.Human.Hp;
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
            
            if (game.Npc.Hp >= 0)
            {
                app.linePlayerHP2.Value = game.Npc.Hp;
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
        
        protected void ParseInputLog(List<Message> Log)
        {
            foreach (Message nextLine in Log)
            {
                Message temp = nextLine;
                switch (temp.Action)
                {
                    case GameControl.RoundAction.attacked:
                        AddToLog(String.Format("{0} : {1} влепил удар и нанес {2} урон {3} HP!", DateTime.Now.ToString("HH:mm:ss"), temp.Attacker, temp.Defender, temp.Damage));
                        break;
                    case GameControl.RoundAction.blocked:
                        AddToLog(String.Format("{0} : {1} старался, но {2} заблокировал удар.", DateTime.Now.ToString("HH:mm:ss"), temp.Attacker, temp.Defender, temp.Damage));
                        break;
                    case GameControl.RoundAction.dead:
                        AddToLog(String.Format("{0} : {1} пошатнулся и упал... Скорая в документах зафиксировала время {0}...", DateTime.Now.ToString("HH:mm:ss"), temp.Name));
                        break;
                    case GameControl.RoundAction.draw:
                        AddToLog(String.Format("{0} : Редкий случай! Ничья!!!", DateTime.Now.ToString("HH:mm:ss")));
                        app.panelRadioButtons.Visible = false;
                        app.buttonNewGame.Visible = true;
                        app.labelRoundResult.Text = "All Dead!";
                        break;
                    case GameControl.RoundAction.win:
                        AddToLog(String.Format("{0} : И-и-и-и... победил {1}!!!", DateTime.Now.ToString("HH:mm:ss"), temp.Name));
                        IncreaseWinsInTable(temp.Name);
                        app.panelRadioButtons.Visible = false;
                        app.buttonNewGame.Visible = true;
                        app.labelRoundResult.Text = temp.Name + " Win!";
                        break;
                    default:
                        AddToLog(String.Format("{0} : Это что-то новенькое! Комментатор не в курсе об этом действии...", DateTime.Now.ToString("HH:mm:ss"), temp.Name));
                        break;
                        
                }
            }
        }
        
        public void AddToLog(string text)
        {
            app.richBattleLog.Text += text + Environment.NewLine;
        }
        
        void IncreaseWinsInTable(string name)
        {
            bool newPlayer = false;
            foreach (var record in rating)
            {
                if (record.Key == name)
                {
                    newPlayer = false;
                }
                else
                {
                    newPlayer = true;
                }
            }
            if (newPlayer)
            {
                rating.Add(name, 1);
            }
            else
            {
                rating[name] += 1;
            }
            SaveRecordsTableToFile();
        }
        
        void ShowRecordsInTable()
        {
            if (File.Exists(ratingFilePath))
            {
                rating = new Dictionary<string, int>();
                var file = File.ReadAllLines(ratingFilePath, Encoding.UTF8);
                for (int i = 0; i < file.Length; i++)
                {
                    string[] temp = file[i].Split(';');
                    rating.Add(temp[0], Convert.ToInt16(temp[1]));
                }
                int n = 0;
                foreach (var line in rating.OrderByDescending(kvp => kvp.Value))
                {
                    app.dataTopPlayesTable.Rows.Add(n, line.Key, line.Value);
                }
                app.dataTopPlayesTable.AllowUserToResizeRows = false;
                app.dataTopPlayesTable.AllowUserToAddRows = false;
                app.dataTopPlayesTable.RowCount = 10;
            }
        }
        
        void SaveRecordsTableToFile()
        {
            using (StreamWriter sw = new StreamWriter(ratingFilePath))
            {
                foreach (var line in rating)
                {
                    sw.WriteLine("{0};{1}", line.Key, line.Value);
                }
            }
        }
        
        void CreateRadioButtons()
        {
            int items = Enum.GetNames(typeof(BodyPart)).Length;
            
            RadioButton[] panelAttackChoise = new RadioButton[items];
            for (int i = 1, point = 4; i < panelAttackChoise.Length; point += 30, i++)
            {
                panelAttackChoise[i] = new System.Windows.Forms.RadioButton();
                panelAttackChoise[i].Location = new System.Drawing.Point(4, point);
                panelAttackChoise[i].Name = "radioAttack" + i;
                panelAttackChoise[i].Size = new System.Drawing.Size(107, 24);
                panelAttackChoise[i].TabIndex = 0;
                panelAttackChoise[i].TabStop = true;
                panelAttackChoise[i].Text = Enum.GetName(typeof(BodyPart), i);
                panelAttackChoise[i].UseVisualStyleBackColor = true;
                app.panelAttack.Controls.Add(panelAttackChoise[i]);
            }

            RadioButton[] panelBlockChoise = new RadioButton[items];
            for (int i = 1, point = 4; i < panelBlockChoise.Length; point += 30, i++)
            {
                panelBlockChoise[i] = new System.Windows.Forms.RadioButton();
                panelBlockChoise[i].Location = new System.Drawing.Point(4, point);
                panelBlockChoise[i].Name = "radioAttack" + i;
                panelBlockChoise[i].Size = new System.Drawing.Size(107, 24);
                panelBlockChoise[i].TabIndex = 0;
                panelBlockChoise[i].TabStop = true;
                panelBlockChoise[i].Text = Enum.GetName(typeof(BodyPart), i);
                panelBlockChoise[i].UseVisualStyleBackColor = true;
                app.panelBlock.Controls.Add(panelBlockChoise[i]);
            }
        }
    }
}
