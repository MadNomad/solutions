/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 24.03.2016
 * Time: 0:06
 */
using System;
using System.Collections.Generic;

namespace GameData.Entity
{
    /// <summary>
    /// Description of User.
    /// </summary>
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public bool IsEMailValid { get; set; }
        public Guid Player { get; set; }
        public ICollection<UserBillingTransaction> UserTransactions { get; set; }
    }
}
