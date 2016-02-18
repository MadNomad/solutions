/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 12.02.2016
 * Time: 11:38
 */
using System;

namespace Combats.Classes
{
    /// <summary>
    /// Description of Player.
    /// </summary>
    public class Player : IPlayer
    {
        public event GameControl.PlayerStatus Wound;

        public event GameControl.PlayerStatus Block;

        public event GameControl.PlayerStatus Death;

        
//		public Player()
//		{
//		}

        #region IPlayer implementation

        string name;
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        bool isHumanAttacker;
        public bool IsHumanAttacker {
            get {
                return isHumanAttacker;
            }
            set {
                isHumanAttacker = value;
            }
        }
        
        int hp;
        public int Hp {
            get {
                return hp;
            }
            set {
                hp = value;
            }
        }

        int maxHp;
        public int MaxHp {
            get {
                return maxHp;
            }
            set {
                maxHp = value;
            }
        }

        int damage;
        public int Damage {
            get {
                return damage;
            }
            set {
                damage = value;
            }
        }

        public virtual int GetHit(BodyPart arg = 0)
        {
            return 1;
            throw new NotImplementedException();
        }
        public virtual int SetBlock(BodyPart arg = 0)
        {
            return 1;
            throw new NotImplementedException();
        }
        #endregion

    }
}
