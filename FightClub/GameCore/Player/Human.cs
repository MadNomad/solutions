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
        public Human(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                Name = "Jack";
            }
            else
            {
                Name = name;
            }
            IsHumanAttacker = true;
        }
        bool isHumanAttacker;
        public bool IsHumanAttacker
        {
            get { return isHumanAttacker; }
            set { isHumanAttacker = IsHumanAttacker; }
        }
    }
}
