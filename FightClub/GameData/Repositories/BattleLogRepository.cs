/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 29.03.2016
 * Time: 11:30
 */
using System;
using System.Data.Entity;
using System.Linq;
using GameData.Data.EF;
using GameData.Entity;
using GameData.Interfaces;

namespace GameData.Repositories
{
    /// <summary>
    /// Description of BattleLogRepository.
    /// </summary>
    public class BattleLogRepository : IRepository<BattleLog>
    {
        private Context db;
        
        public BattleLogRepository(Context context)
        {
            this.db = context;
        }

        #region IRepository<BattleLog> implementation

        public System.Collections.Generic.IEnumerable<BattleLog> GetAll()
        {
            return db.BattleLogs;
        }

        public BattleLog GetById(int id)
        {
            return db.BattleLogs.Find(id);
        }

        public System.Collections.Generic.IEnumerable<BattleLog> Find(Func<BattleLog, bool> predicate)
        {
            return db.BattleLogs.Where(predicate).ToList();
        }

        public void Create(BattleLog item)
        {
            db.BattleLogs.Add(item);
        }

        public void Update(BattleLog item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            BattleLog log = db.BattleLogs.Find(id);
            if (log != null)
            {
                db.BattleLogs.Remove(log);
            }
        }

        #endregion
    }
}
