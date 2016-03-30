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
        IPlayer human;
        IPlayer npc;
        public int Damage = PlayerDefaultValue.defaultDamage;
        
        public delegate void BattleEvent(IPlayer player, string name);
        
        public virtual event BattleEvent Draw;
        public virtual event BattleEvent Win;
        public virtual event BattleEvent Lose;
        public virtual event PlayerEvent Dead;
        
        

        public Battle(IPlayer human, IPlayer npc)
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
            npc.AttackPoint = GenRandPart();
            npc.BlockPoint = GenRandPart();

            human.GetHit(npc.AttackPoint, npc.Name);
            npc.GetHit(human.AttackPoint, human.Name);

            if (human.Hp <= 0 && npc.Hp <= 0)
            {
                if (Draw != null)
                {
                    Draw(human, npc.Name);
                }
            }
            else if (human.Hp <= 0)
            {
                if (Dead != null)
                {
                    Dead(human, npc.Name);
                }
                if (Lose != null)
                {
                    Lose(human, npc.Name);
                }
            }
            else if (npc.Hp <= 0)
            {
                if (Dead != null)
                {
                    Dead(npc, human.Name);
                }
                if (Win != null)
                {
                    Win(human, npc.Name);
                }
            }

        }

        Random rnd = new Random();

        BodyPart GenRandPart()
        {
            int items = Enum.GetNames(typeof(BodyPart)).Length;
            return (BodyPart)rnd.Next(1, items);
        }
        #endregion
    }
}
