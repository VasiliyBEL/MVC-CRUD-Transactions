﻿using Microsoft.EntityFrameworkCore;

namespace MVC_CRUD_Transactions.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
