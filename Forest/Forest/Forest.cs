/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 14.03.2016
 * Time: 12:47
 */
using System;
using System.Collections.Generic;
using Forest;

namespace Forest
{
    /// <summary>
    /// Description of MyClass.
    /// </summary>
    
    enum season
    {
        None,
        Winter,
        Spring,
        Summer,
        Autumn
    }
    
    public class Forest
    {
        season CurrentSeason;
        List<ITree> TreesInForest = new List<ITree>();
        
        Forest()
        {
            CurrentSeason = GetSeason(DateTime.Now);
        }
        
        public void Born(ITree tree)
        {
            TreesInForest.Add(tree);
        }
        
        season GetSeason(DateTime time)
        {
            switch (time.Month)
            {
                case 1:
                case 2:
                case 12:
                    return season.Winter;
                case 3:
                case 4:
                case 5:
                    return season.Spring;
                case 6:
                case 7:
                case 8:
                    return season.Summer;
                case 9:
                case 10:
                case 11:
                    return season.Autumn;
                default:
                    return season.Winter;
            }
        }
    }
}