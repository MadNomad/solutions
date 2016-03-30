/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 17.03.2016
 * Time: 15:40
 */
using System;
using System.Data.Entity;

namespace GameCore
{
    /// <summary>
    /// Description of DataContext.
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext() :base("DbConnection") {}
        
        public DbSet<GameRating> Rating { get; set; }
    }
}
