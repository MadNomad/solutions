/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 17.03.2016
 * Time: 14:39
 */
using System;

namespace GameCore
{
    /// <summary>
    /// Description of GameRating.
    /// </summary>
    public class GameRating
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerWins { get; set; }
    }
}
