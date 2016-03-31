/*
 * Created by Mad Nomad
 * User: Sergey Ermolov
 * Date: 22.03.2016
 * Time: 14:11
 */
using System;

namespace GameData.Entity
{
    /// <summary>
    /// Description of UserBillingTransaction.
    /// </summary>
    public class UserBillingTransaction
    {
        public Int64 Id { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Guid TransactionId { get; set; }
        public string Description { get; set; }
        public decimal Sum { get; set; }
    }
}
