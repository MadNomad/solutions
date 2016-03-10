/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 09.03.2016
 * Time: 16:58
 */
using System;

namespace GameCore
{
    /// <summary>
    /// Description of PlayerEventArgs.
    /// </summary>
    public class PlayerEventArgs : EventArgs
    {
        public PlayerEventArgs(int damage, int hp, string name)
        {
            Damage = damage;
            Hp = hp;
            Name = name;
        }
        public int Damage { get; private set; }
        public int Hp { get; private set; }
        public string Name { get; private set; }
    }

}
