/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 22.03.2016
 * Time: 14:35
 */
using System;
using System.ComponentModel;

namespace GameData.Entity
{
    /// <summary>
    /// Description of BattleLog.
    /// </summary>
    
    public enum BodyPart
    {
        None,
        [Description("Голова")]
        Head,
        [Description("Корпус")]
        Body,
        [Description("Ноги")]
        Legs
    }

    public class BattleLog
    {
        public Int64 Id { get; set; }
        public DateTime Date { get; set; }
        public Player FirstPlayer { get; set; }
        public Player SecondPlayer { get; set; }
        public BodyPart Part { get; set; }
        public int Result { get; set; }
        public int HitValue { get; set; }
    }
}
