/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 28.03.2016
 * Time: 15:51
 */
using System;
using GameData.Entity;

namespace GameData.Interfaces
{
    /// <summary>
    /// Description of IUnitOfWork.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get;}
        IRepository<UserBillingTransaction> UserBillingTransactions { get;}
        IRepository<Player> Players { get;}
        IRepository<Battle> Battles { get;}
        IRepository<BattleLog> BattleLogs { get;}
        void Save();
    }
}
