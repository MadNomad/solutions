/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 29.03.2016
 * Time: 11:25
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
    /// Description of BattleRepository.
    /// </summary>
    public class BattleRepository : IRepository<Battle>
    {
        private Context db;
        
        public BattleRepository(Context context)
        {
            this.db = context;
        }

        #region IRepository<Battle> implementation

        public IEnumerable<Battle> GetAll()
        {
            return db.Battles;
        }

        public Battle GetById(int id)
        {
            return db.Battles.Find(id);
        }

        public IEnumerable<Battle> Find(Func<Battle, bool> predicate)
        {
            return db.Battles.Where(predicate).ToList();
        }

        public void Create(Battle item)
        {
            db.Battles.Add(item);
        }

        public void Update(Battle item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            Battle battle = db.Battles.Find(id);
            if (battle != null)
            {
                db.Battles.Remove(battle);
            }
        }

        #endregion
    }
}
