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
using GameCore;

namespace GameUI
{
    /// <summary>
    /// Description of BattlePresenter.
    /// </summary>
    public enum RoundAction
    {
        none,
        attacked,
        blocked,
        dead,
        draw,
        win
            
    }

    public class BattlePresenter
    {
        GameMaster Game;
        BattleUserControl View;
        
        public BattlePresenter(BattleUserControl view)
        {
            View = view;
            Game = new GameMaster(ProgramData.PlayerName);
            View.BattleFirstPlayerName = Game.Human.Name;
            View.BattleFirstPlayerHpMax = Game.Human.MaxHp;
            View.BattleSecondPlayerName = Game.Npc.Name;
            View.BattleSecondPlayerHpMax = Game.Npc.MaxHp;
            RefreshHealthProgressBars();
            View.CreateRadioButtons();
            Game.Human.Blocked += Player_Blocked;
            Game.Human.Wounded += Player_Wounded;
            Game.Npc.Blocked += Player_Blocked;
            Game.Npc.Wounded += Player_Wounded;
            Game.Battle.Dead += Player_Dead;
            Game.Battle.Lose += Game_Battle_Lose;
            Game.Battle.Win += Game_Battle_Win;
            Game.Battle.Draw += Game_Battle_Draw;
        }

        public void NextRound(BodyPart attackPoint, BodyPart blockPoint)
        {
            AddToLog("---==================---");
            Game.Battle.MakeRound((BodyPart)attackPoint, (BodyPart)blockPoint);
            RefreshHealthProgressBars();
        }

        void Player_Blocked(GameCore.IPlayer player, string name)
        {
            AddToLog(String.Format("{0} : {2} старался, но {1} заблокировал удар.", DateTime.Now.ToString("HH:mm:ss"), player.Name, name));
        }

        void Player_Wounded(GameCore.IPlayer player, string name)
        {
            AddToLog(String.Format("{0} : Точным ударом {2} нанес {1} урон {3} HP!", DateTime.Now.ToString("HH:mm:ss"), player.Name, name, Game.Battle.Damage));
        }

        void Player_Dead(GameCore.IPlayer player, string name)
        {
            AddToLog(String.Format("{0} : {1} пошатнулся и упал... Скорая в документах зафиксировала время {0}...", DateTime.Now.ToString("HH:mm:ss"), player.Name));
        }

        void Game_Battle_Lose(GameCore.IPlayer player, string name)
        {
            AddToLog(String.Format("{0} : И-и-и-и... победил {1}!!!", DateTime.Now.ToString("HH:mm:ss"), name));
            IncreaseWinsInTable(name);
            ChangeButtonsVisibility();
            View.BattleResultMessage = player.Name + " Lose!";
        }

        void Game_Battle_Win(GameCore.IPlayer player, string name)
        {
            AddToLog(String.Format("{0} : Победил {1}!!!", DateTime.Now.ToString("HH:mm:ss"), player.Name));
            IncreaseWinsInTable(player.Name);
            ChangeButtonsVisibility();
            View.BattleResultMessage = player.Name + " Win!";
        }

        void Game_Battle_Draw(GameCore.IPlayer player, string name)
        {
            AddToLog(String.Format("{0} : {1} и {2} попадали в разные стороны!", DateTime.Now.ToString("HH:mm:ss"), player.Name, name));
            AddToLog(String.Format("{0} : Редкий случай! Ничья!!!", DateTime.Now.ToString("HH:mm:ss")));
            ChangeButtonsVisibility();
            View.BattleResultMessage = "All Dead!";
        }
        
        public void AddToLog(string text)
        {
            View.AddBattleLog = text + Environment.NewLine;
        }
        
        void ChangeButtonsVisibility ()
        {
            View.RadioButtonsVisible = false;
            View.NewBattleButtonVisible = true;
        }
        void IncreaseWinsInTable(string name)
        {
            if (CheckFileExist(ProgramData.RatingFileFullPath))
            {
                bool newPlayer = false;
                foreach (var record in ProgramData.Rating)
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
                    ProgramData.Rating[name] += 1;
                }
                else
                {
                    ProgramData.Rating.Add(name, 1);
                }
            }
            else
            {
                if (!Directory.Exists(ProgramData.RatingFilePath))
                {
                    Directory.CreateDirectory(ProgramData.RatingFilePath);
                }
                using (File.Create(ProgramData.RatingFileFullPath))
                {
                }
                ProgramData.Rating = new Dictionary<string, int>();
                ProgramData.Rating.Add(name, 1);
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
            using (StreamWriter sw = new StreamWriter(ProgramData.RatingFileFullPath))
            {
                foreach (var line in ProgramData.Rating)
                {
                    sw.WriteLine("{0};{1}", line.Key, line.Value);
                }
            }
        }
        
        public void RefreshHealthProgressBars()
        {
            if (Game.Human.Hp >= 0)
            {
                View.BattleFirstPlayerHP = Game.Human.Hp;
            }
            else
            {
                View.BattleFirstPlayerHP = 0;
            }
            
            if (Game.Npc.Hp >= 0)
            {
                View.BattleSecondPlayerHP = Game.Npc.Hp;
            }
            else
            {
                View.BattleSecondPlayerHP = 0;
            }
        }

    }
}
