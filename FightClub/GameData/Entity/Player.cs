/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 25.03.2016
 * Time: 1:11
 */
using System;

namespace GameData.Entity
{
    /// <summary>
    /// Description of Player.
    /// </summary>
    public class Player
    {
        public Int64 Id { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int MaxHP { get; set; }
        public int Damage { get; set; }
        public int Experience { get; set; }
    }
}
