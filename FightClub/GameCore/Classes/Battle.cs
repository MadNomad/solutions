/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 10.03.2016
 * Time: 9:54
 */
using System;

namespace GameCore
{
    /// <summary>
    /// Description of Battle.
    /// </summary>
    public class Battle : IBattle
    {
        Human human;
        Npc npc;
        
        public delegate void BattleEvent(IPlayer player, IPlayer enemy);
        
        public virtual event BattleEvent Draw;
        public virtual event BattleEvent Win;
        public virtual event BattleEvent Lose;
        public virtual event PlayerEvent Dead;
        
        

        public Battle(Human human, Npc npc)
        {
            this.human = human;
            this.npc = npc;
        }

        #region IBattle implementation

        public void MakeRound(BodyPart attackPoint, BodyPart blockPoint)
        {
            if (human.Hp <= 0 || npc.Hp <= 0)
            {
                return;
            }
            
            human.AttackPoint = attackPoint;
            human.BlockPoint = blockPoint;
            npc.GenerateBodyPoints();

            if (human.IsHumanAttacker)
            {
                human.GetHit(npc);
                npc.GetHit(human);
                human.IsHumanAttacker = false;
            }
            else
            {
                npc.GetHit(human);
                human.GetHit(npc);
                human.IsHumanAttacker = true;
            }

            if (human.Hp <= 0 && npc.Hp <= 0)
            {
                if (Draw != null)
                {
                    Draw(human, npc);
                }
            }
            else if (human.Hp <= 0)
            {
                if (Dead != null)
                {
                    Dead(human, npc);
                }
                if (Lose != null)
                {
                    Lose(human, npc);
                }
            }
            else if (npc.Hp <= 0)
            {
                if (Dead != null)
                {
                    Dead(npc, human);
                }
                if (Win != null)
                {
                    Win(human, npc);
                }
            }

        }

        #endregion
    }
}
