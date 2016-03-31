/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 28.03.2016
 * Time: 23:27
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
    /// Description of UserRepository.
    /// </summary>
    public class UserRepository : IRepository<User>
    {
        private Context db;
        
        public UserRepository(Context context)
        {
            this.db = context;
        }

        #region IRepository<User> implementation
        
        public IEnumerable<User> GetAll()
        {
            return db.Users.ToList();
        }
        
        public User GetById(int id)
        {
            return db.Users.Find(id);
        }
        
        public IEnumerable<User> Find(Func<User, bool> predicate)
        {
            return db.Users.Where(predicate).ToList();
        }
        
        public void Create(User item)
        {
            db.Users.Add(item);
        }
        
        public void Update(User item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
        
        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
            }
        }
        
        #endregion
    }
}
