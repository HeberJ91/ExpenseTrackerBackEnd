using Data.Mapping.TypeExpenses;
using Entities.TypeExpense;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class DBContextSystem: DbContext 
    {
     
        public DBContextSystem(DbContextOptions<DBContextSystem> options ): base(options)
        {

        }



        public DbSet<TypeExpense> TypesExpense { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TypeExpenseMap());
        }
    }
}
