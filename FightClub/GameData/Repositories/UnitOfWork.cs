/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 29.03.2016
 * Time: 21:35
 */
using System;
using GameData.Data.EF;
using GameData.Interfaces;

namespace GameData.Repositories
{
    /// <summary>
    /// Description of UnitOfWork.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private Context db;
        private UserRepository userRepository;
        private UserBillingTransactionRepository userBillingTransactionRepository;
        private PlayerRepository playerRepository;
        private BattleRepository battleRepository;
        private BattleLogRepository battleLogRepository;
        
        public UnitOfWork(Context db)
        {
            this.db = db;
        }

        #region IUnitOfWork implementation

        public void Save()
        {
            throw new NotImplementedException();
        }

        public IRepository<GameData.Entity.User> Users
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(db);
                }
                return userRepository;
            }
        }

        public IRepository<GameData.Entity.UserBillingTransaction> UserBillingTransactions
        {
            get
            {
                if(userBillingTransactionRepository == null)
                {
                    userBillingTransactionRepository = new UserBillingTransactionRepository(db);
                }
                return userBillingTransactionRepository;
            }
        }

        public IRepository<GameData.Entity.Player> Players
        {
            get
            {
                if (playerRepository == null)
                {
                    playerRepository = new PlayerRepository(db);
                }
                return playerRepository;
            }
        }

        public IRepository<GameData.Entity.Battle> Battles
        {
            get
            {
                if (battleRepository == null)
                {
                    battleRepository = new BattleRepository(db);
                }
                return battleRepository;
            }
        }

        public IRepository<GameData.Entity.BattleLog> BattleLogs
        {
            get
            {
                if (battleLogRepository == null)
                {
                    battleLogRepository = new BattleLogRepository(db);
                }
                return battleLogRepository;
            }
        }

        #endregion

        #region IDisposable implementation

        private bool disposed;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
