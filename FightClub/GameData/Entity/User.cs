/*
 * Created by Mad Nomad
 * User: Mad Nomad
 * Date: 24.03.2016
 * Time: 0:06
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameData.Entity
{
    /// <summary>
    /// Description of User.
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }
        [Display(Name = "Validated")]
        public bool IsEMailValid { get; set; }
        [Display(Name = "Character")]
        public Guid Player { get; set; }
        [Display(Name = "Billing Orders")]
        public ICollection<UserBillingTransaction> UserTransactions { get; set; }
    }
}
