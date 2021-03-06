﻿/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 04.03.2016
 * Time: 12:19
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GameCore
{
    /// <summary>
    /// Description of MyClass.
    /// </summary>
    
    public class GameMaster
    {
        public IPlayer Human;
        public IPlayer Npc;
        public Battle Battle;
        
        public GameMaster(string name)
        {
            if (IsSavedGame(name))
            {
                LoadBattlePlayer(name);
            }
            else
            {
                Human = new Human(name);
                Npc = new Npc();
            }
            Battle = new Battle(Human, Npc);
            Battle.Win += Battle_Win;
            
        }

        internal bool IsSavedGame(string playerName)
        {
            //            TODO Проверка на наличие файла сохранения игрока playerName
            return false;
        }
        
        internal void LoadBattlePlayer(string playerName)
        {
            //            TODO Загрузка игры персонажа playerName из файла
        }
        
        internal bool CheckExistingPlayer(string playerName)
        {
            using (DataContext db = new DataContext())
            {
                return true;
            }
        }

        internal void GetPrize(IPlayer player)
        {
            //            TODO Реализовать получение опыта/уровня.
        }

        void Battle_Win(IPlayer player, string name)
        {
            //            TODO Обработка ивента выигрыша
            
        }
    }
    
}