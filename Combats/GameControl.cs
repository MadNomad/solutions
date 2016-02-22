/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:57
 */
using System;
using System.Collections.Generic;
using Combats.Classes;
using System.Windows.Forms;
using System.Collections;

namespace Combats
{
    /// <summary>
    /// Description of GameControl.
    /// </summary>
    public enum BodyPart
    {
        None,
        Head,
        Body,
        Legs
    }
    
    public partial class GameControl
    {
        public delegate void PlayerStatus(string name, int hp, int damage);

        public IPlayer Human;
        public IPlayer Npc;
        public List<Message> Log = new List<Message>();

        public GameControl(string name)
        {
            Human = new Human(name);
            Npc = new Npc();
//			human

        }
        
        protected void GetPrize(IPlayer player)
        {
            //            TODO Реализовать получение опыта/уровня.
        }
        
        public void ChangeName(string name)
        {
            Human.Name = name;
        }
    }
}
