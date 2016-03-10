/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 09.03.2016
 * Time: 23:13
 */
using System;

namespace GameCore
{
    /// <summary>
    /// Description of Human.
    /// </summary>
    public class Human : Player
    {
        public Human(string name = "Jack", int hp = PlayerDefaultValue.defaultHp, int maxHp = PlayerDefaultValue.defaultMaxHp, int damage = PlayerDefaultValue.defaultDamage)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                Name = "Jack";
                Hp = hp;
                MaxHp = maxHp;
                Damage = damage;
            }
            else
            {
                Name = name;
            }
            IsHumanAttacker = true;
        }
        bool isHumanAttacker;
        public virtual bool IsHumanAttacker
        {
            get { return isHumanAttacker; }
            set { isHumanAttacker = IsHumanAttacker; }
        }
    }
}
