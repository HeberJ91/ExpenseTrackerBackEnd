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


        DbSet<TypeExpense> TypeExpense { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
