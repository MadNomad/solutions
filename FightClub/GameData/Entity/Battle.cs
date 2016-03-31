/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 22.03.2016
 * Time: 14:29
 */
using System;

namespace GameData.Entity
{
    /// <summary>
    /// Description of Battle.
    /// </summary>
    public enum BattleResult
    {
        Draw,
        FirstPlayerWin,
        SecondPlayerWin
    }
    
    public enum BattleType
    {
        None,
        PvM,
        PvP
    }
    
    public class Battle
    {
        public Int64 Id { get; set; }
        public DateTime Date { get; set; }
        public BattleType Type { get; set; }
        public Player FirstPlayer { get; set; }
        public Player SecondPlayer { get; set; }
        public Int64 LogId { get; set; }
        public BattleResult Result { get; set; }
        public int ExpGained { get; set; }
    }
}
