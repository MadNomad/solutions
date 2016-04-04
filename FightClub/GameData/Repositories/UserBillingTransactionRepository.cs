/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 29.03.2016
 * Time: 11:09
 */
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using GameData.Data.EF;
using GameData.Entity;
using GameData.Interfaces;

namespace GameData.Repositories
{
    /// <summary>
    /// Description of UserBillingTransactionRepository.
    /// </summary>
    public class UserBillingTransactionRepository : IRepository<UserBillingTransaction>
    {
        private Context db;
        
        public UserBillingTransactionRepository(Context context)
        {
            this.db = context;
        }

        #region IRepository<UserBillingTransaction> implementation

        public IEnumerable<UserBillingTransaction> GetAll()
        {
            return db.UserBillingTransactions;
        }

        public UserBillingTransaction GetById(Int64 id)
        {
            return db.UserBillingTransactions.Find(id);
        }

        public IEnumerable<UserBillingTransaction> Find(Func<UserBillingTransaction, bool> predicate)
        {
            return db.UserBillingTransactions.Where(predicate).ToList();
        }

        public void Create(UserBillingTransaction item)
        {
            db.UserBillingTransactions.Add(item);
        }

        public void Update(UserBillingTransaction item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(Int64 id)
        {
            UserBillingTransaction transaction = db.UserBillingTransactions.Find(id);
            if (transaction != null)
            {
                db.UserBillingTransactions.Remove(transaction);
            }
        }

        #endregion
    }
}
