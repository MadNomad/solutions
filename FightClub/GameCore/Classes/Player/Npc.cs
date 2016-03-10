/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 09.03.2016
 * Time: 17:34
 */
using System;

namespace GameCore
{
    /// <summary>
    /// Description of Npc.
    /// </summary>
    public class Npc : Player
    {
        Random rnd = new Random();

        public Npc(string name = "Tyler", int hp = PlayerDefaultValue.defaultHp, int maxHp = PlayerDefaultValue.defaultMaxHp, int damage = PlayerDefaultValue.defaultDamage)
        {
            Name = name;
            Hp = hp;
            MaxHp = maxHp;
            Damage = damage;
        }
        
        BodyPart GenRandPart()
        {
            int items = Enum.GetNames(typeof(BodyPart)).Length;
            return (BodyPart)rnd.Next(1, items);
        }

        internal void GenerateBodyPoints()
        {
            AttackPoint = GenRandPart();
            BlockPoint = GenRandPart();
        }
    }
}
