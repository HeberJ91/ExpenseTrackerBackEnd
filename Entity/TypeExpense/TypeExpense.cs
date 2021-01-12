using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.TypeExpense
{
   public class TypeExpense
    {
        public int Id { get; set; }
        [Required]

        public string  Description { get; set; }

        public string Type { get; set; }

        public Boolean Status { get; set; }

        public decimal Default_value { get; set; }

    }
}
