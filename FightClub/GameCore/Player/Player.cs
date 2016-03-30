/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 09.03.2016
 * Time: 22:11
 */
using System;

namespace GameCore
{
    public class Player : IPlayer
    {
        #region IPlayer implementation
        public virtual event PlayerEvent Wounded;
        public virtual event PlayerEvent Blocked;
        public virtual event PlayerEvent Dead;
        
        //        public virtual void GetHit(Player enemy)
        //        {
        //            if (BlockPoint != enemy.AttackPoint)
        //            {
        //                Hp -= enemy.Damage;
        //                if (Wounded != null)
        //                {
        //                    Wounded(this, enemy);
        //                }
        //            }
        //            else
        //            {
        //                if (Blocked != null)
        //                {
        //                    Blocked(this, enemy);
        //                }
        //            }
        //        }

        public virtual void GetHit(BodyPart part, string name)
        {
            if (BlockPoint != part)
            {
                Hp -= Damage;
                if (Wounded != null)
                {
                    Wounded(this, name);
                }
            }
            else
            {
                if (Blocked != null)
                {
                    Blocked(this, name);
                }
            }
        }
        public virtual void SetBlock(BodyPart part, string name)
        {
            if (AttackPoint == part)
            {
                if (Wounded != null)
                {
                    Wounded(this, name);
                }
            }
            else
            {
                if (Blocked != null)
                {
                    Blocked(this, name);
                }
            }
        }
        string name;
        public virtual string Name
        {
            get { return name; }
            protected  set { name = value; }
        }
        int maxHp = PlayerDefaultValue.defaultMaxHp;
        public virtual int MaxHp
        {
            get { return maxHp; }
            protected set { maxHp = value; }
        }
        int hp = PlayerDefaultValue.defaultHp;
        public virtual int Hp
        {
            get { return hp; }
            protected set { hp = value; }
        }
        int damage = PlayerDefaultValue.defaultDamage;
        public virtual int Damage
        {
            get { return damage; }
            protected set { damage = value; }
        }
        public virtual BodyPart AttackPoint { get; set; }
        public virtual BodyPart BlockPoint { get; set; }
        #endregion
    }
}
