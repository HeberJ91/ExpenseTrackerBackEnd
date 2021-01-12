using Entities.TypeExpense;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Mapping.TypeExpenses
{
   public class TypeExpenseMap :IEntityTypeConfiguration<TypeExpense>
    {
        public void Configure(EntityTypeBuilder<TypeExpense> builder)
        {
            builder.ToTable("typeexpense")
                .HasKey(t => t.Id);
            builder.Property(t => t.Description)
                .HasMaxLength(250);
            builder.Property(t => t.Default_value)
                .HasPrecision(18, 2);
            builder.Property(t => t.Type)
                .HasMaxLength(50);
            builder.Property(t => t.Status);
                

        }
    }
}
