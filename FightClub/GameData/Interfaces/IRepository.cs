/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 28.03.2016
 * Time: 15:46
 */
using System;
using System.Collections.Generic;
using GameData.Entity;

namespace GameData.Interfaces
{
    /// <summary>
    /// Description of IRepository.
    /// </summary>
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> Find(Func<T, Boolean> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
