using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankLedgerCodeSample.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime TransDate { get; set; }
        public Decimal TransAmount { get; set; }
        public string Source { get; set; }
        public string Memo { get; set; }
    }

    public class TransactionDbContext : DbContext
    {
        public DbSet<Transaction> History { get; set; }
    }
}