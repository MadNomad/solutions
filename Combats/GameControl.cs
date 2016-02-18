/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:57
 */
using System;
using Combats.Classes;
using System.Windows.Forms;

namespace Combats
{
    /// <summary>
    /// Description of GameControl.
    /// </summary>
    public enum BodyPart {None, Head, Body, Legs}
    
    public class GameControl
    {
        public delegate void PlayerStatus (string name, int xp, int damage);

        public IPlayer human;
        public IPlayer npc;

        public GameControl(string name)
        {
            human = new Human(name);
            npc = new Npc();
//			human

        }
        
        public void ChangeName (string name)
        {
            human.Name = name;
        }
        
        public void MakeRound (BodyPart attackPoint, BodyPart blockPoint)
        {
//		TODO: Реализовать раунд
            if (human.IsHumanAttacker)
            {
                if ( !attackPoint.Equals(npc.SetBlock) )
                {
                    npc.Hp -= human.Damage;
                }
                if (!blockPoint.Equals(npc.GetHit))
                {
                    human.Hp -= npc.Damage;
                }
                human.IsHumanAttacker = false;
            }
            else
            {
                if (!blockPoint.Equals(npc.GetHit))
                {
                    human.Hp -= npc.Damage;
                }
                if (!attackPoint.Equals(npc.SetBlock))
                {
                    npc.Hp -= human.Damage;
                }
                human.IsHumanAttacker = true;
            }
            //            human.Hp = human.Hp - 5;
            //            npc.Hp = npc.Hp - 7;
        }
    }
}
