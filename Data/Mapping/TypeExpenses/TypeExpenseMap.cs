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
            builder.ToTable("TypeExpense")
                .HasKey(t => t.id);
            builder.Property(t => t.description)
                .HasMaxLength(250);
            builder.Property(t => t.default_value)
                .HasPrecision(18, 2);
            builder.Property(t => t.type)
                .HasMaxLength(50);
            builder.Property(t => t.status);
                

        }
    }
}
