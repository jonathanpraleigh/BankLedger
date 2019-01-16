using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankLedgerCodeSample.Models
{
    public class BankAccount
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public float Balance { get; set; }
    }

    public class BankAccountDBContext : DbContext
    {
        public DbSet<BankAccount> BankAccounts { get; set; }
    }
}