/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 14.03.2016
 * Time: 12:47
 */
using System;
using System.Collections.Generic;

namespace Forest
{
    /// <summary>
    /// Description of MyClass.
    /// </summary>
    
    public enum Season
    {
        None,
        Winter,
        Spring,
        Summer,
        Autumn
    }
    
    public class Forest
    {
        public List<Tree> TreesInForest = new List<Tree>();
        
        public Forest()
        {
            CurrentSeason = GetSeason(DateTime.Now);
        }

        public Season CurrentSeason;

        protected void changeCurrentSeason(DateTime date)
        {
            CurrentSeason = GetSeason(date);
        }

        public void Add(TypeOfTree tree)
        {
            TreesInForest.Add(new TreeCreator().Born(tree));
        }


        Season GetSeason(DateTime time)
        {
            switch (time.Month)
            {
                case 1:
                case 2:
                case 12:
                    return Season.Winter;
                case 3:
                case 4:
                case 5:
                    return Season.Spring;
                case 6:
                case 7:
                case 8:
                    return Season.Summer;
                case 9:
                case 10:
                case 11:
                    return Season.Autumn;
                default:
                    return Season.Winter;
            }
        }
    }
}