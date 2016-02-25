/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 25.02.2016
 * Time: 23:13
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Combats
{
    /// <summary>
    /// Description of BattlePresenter.
    /// </summary>
    public class BattlePresenter : BattleUserControl
    {
        GameControl Battle;
        BattleUserControl View;
        public BattlePresenter(BattleUserControl view)
        {
            View = view;
            Battle = new GameControl(MainForm.PlayerName);
            FirstPlayerName.Text = Battle.Human.Name;
            FirstPlayerHP.Maximum = Battle.Human.Hp;
            SecondPlayerName.Text = Battle.Npc.Name;
            SecondPlayerHP.Maximum = Battle.Npc.Hp;
            RefreshHealthProgressBars();
            CreateRadioButtons();
        }

        public void NextRound(string attackPoint, string blockPoint)
        {
            AddToLog("---==================---");
                Battle.MakeRound(
                    (BodyPart)Enum.Parse(typeof(BodyPart), attackPoint),
                    (BodyPart)Enum.Parse(typeof(BodyPart), blockPoint)
               );
            RefreshHealthProgressBars();
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
                        RadioButtons.Visible = false;
                        NewBattle.Visible = true;
                        BattleResult.Text = "All Dead!";
                        break;
                    case GameControl.RoundAction.win:
                        AddToLog(String.Format("{0} : И-и-и-и... победил {1}!!!", DateTime.Now.ToString("HH:mm:ss"), temp.Name));
                        IncreaseWinsInTable(temp.Name);
                        RadioButtons.Visible = false;
                        NewBattle.Visible = true;
                        BattleResult.Text = temp.Name + " Win!";
                        break;
                    default:
                        AddToLog(String.Format("{0} : Это что-то новенькое! Комментатор не в курсе об этом действии...", DateTime.Now.ToString("HH:mm:ss"), temp.Name));
                        break;
                        
                }
            }
        }
        
        public void AddToLog(string text)
        {
            BattleLog.Text += text + Environment.NewLine;
        }
        
        void IncreaseWinsInTable(string name)
        {
            if (CheckFileExist(MainForm.RatingFilePath))
            {
                bool newPlayer = false;
                foreach (var record in MainForm.Rating)
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
                if (!newPlayer)
                {
                    MainForm.Rating[name] += 1;
                }
                else
                {
                    MainForm.Rating.Add(name, 1);
                }
            }
            else
            {
                using (File.Create(MainForm.RatingFilePath))
                {
                }
                MainForm.Rating = new Dictionary<string, int>();
                MainForm.Rating.Add(name, 1);
            }
            SaveRecordsTableToFile();
        }
        
        
        bool CheckFileExist(string file)
        {
            if (!File.Exists(file))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        void SaveRecordsTableToFile()
        {
            using (StreamWriter sw = new StreamWriter(MainForm.RatingFilePath))
            {
                foreach (var line in MainForm.Rating)
                {
                    sw.WriteLine("{0};{1}", line.Key, line.Value);
                }
            }
        }
        
        void CreateRadioButtons()
        {
            NewRadioButtonPanel("Attack");
            NewRadioButtonPanel("Block");
        }

        public void RefreshHealthProgressBars()
        {
            if (Battle.Human.Hp >= 0)
            {
                FirstPlayerHP.Value = Battle.Human.Hp;
            }
            else
            {
                FirstPlayerHP.Value = 0;
            }
            Int32 currentHumanLifePercent = FirstPlayerHP.Value / FirstPlayerHP.Maximum * 100;
            if (currentHumanLifePercent < 30)
            {
                FirstPlayerHP.ForeColor = Color.Red;
            }
            else if (currentHumanLifePercent < 60)
            {
                FirstPlayerHP.ForeColor = Color.Yellow;
            }
            
            if (Battle.Npc.Hp >= 0)
            {
                SecondPlayerHP.Value = Battle.Npc.Hp;
            }
            else
            {
                SecondPlayerHP.Value = 0;
            }
            Int32 currentNpcLifePercent = SecondPlayerHP.Value / SecondPlayerHP.Maximum * 100;
            if (currentNpcLifePercent < 30)
            {
                SecondPlayerHP.ForeColor = Color.Red;
            }
            else if (currentNpcLifePercent < 60)
            {
                SecondPlayerHP.ForeColor = Color.Yellow;
            }
        }

        void NewRadioButtonPanel(string type)
        {
            int items = Enum.GetNames(typeof(BodyPart)).Length;
            RadioButton[] newPanel = new RadioButton[items];
            for (int i = 1, point = 4; i < newPanel.Length; point += 30, i++)
            {
                newPanel[i] = new System.Windows.Forms.RadioButton();
                newPanel[i].Location = new System.Drawing.Point(4, point);
                newPanel[i].Name = "radio" + type + i;
                newPanel[i].Size = new System.Drawing.Size(107, 24);
                newPanel[i].TabIndex = 0;
                newPanel[i].TabStop = true;
                newPanel[i].Text = GetEnumDescription((BodyPart)i);
                newPanel[i].Tag = Enum.GetName(typeof(BodyPart), i);
                newPanel[i].UseVisualStyleBackColor = true;
                if (type == "Attack")
                {
                    AttackPanel.Controls.Add(newPanel[i]);
                }
                else if (type == "Block")
                {
                    BlockPanel.Controls.Add(newPanel[i]);
                }
            }
        }
        
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(
                    typeof(DescriptionAttribute),
                    false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
        
    }
}
