/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 29.03.2016
 * Time: 11:19
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
    /// Description of PlayerRepository.
    /// </summary>
    public class PlayerRepository : IRepository<Player>
    {
        private Context db;
        public PlayerRepository(Context context)
        {
            this.db = context;
        }

        #region IRepository<Player> implementation

        public IEnumerable<Player> GetAll()
        {
            return db.Players;
        }

        public Player GetById(Int64 id)
        {
            return db.Players.Find(id);
        }

        public IEnumerable<Player> Find(Func<Player, bool> predicate)
        {
            return db.Players.Where(predicate).ToList();
        }

        public void Create(Player item)
        {
            db.Players.Add(item);
        }

        public void Update(Player item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(Int64 id)
        {
            Player player = db.Players.Find(id);
            if (player != null)
            {
                db.Players.Remove(player);
            }
        }

        #endregion
    }
}
