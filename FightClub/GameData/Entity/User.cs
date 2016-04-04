/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 24.03.2016
 * Time: 0:06
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameData.Entity
{
    /// <summary>
    /// Description of User.
    /// </summary>
    public class User
    {
        [DisplayName("ID")]
        public Int64 Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [DisplayName("E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }
        [DisplayName("Validated")]
        public bool IsEMailValid { get; set; }
        [DisplayName("Character")]
        public Guid Player { get; set; }
        [DisplayName("Billing Orders")]
        public ICollection<UserBillingTransaction> UserTransactions { get; set; }
    }
}
