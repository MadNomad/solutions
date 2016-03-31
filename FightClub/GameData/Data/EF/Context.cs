/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 25.03.2016
 * Time: 15:41
 */
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using GameData.Entity;

namespace GameData.Data.EF
{
    /// <summary>
    /// Description of Context.
    /// </summary>
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<UserBillingTransaction> UserBillingTransactions { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<BattleLog> BattleLogs { get; set; }
        
        public Context()
            : base ("name=Context")
        {
        }
        
        public Context(string connectionString)
            : base(connectionString)
        {
        }
    }
}
