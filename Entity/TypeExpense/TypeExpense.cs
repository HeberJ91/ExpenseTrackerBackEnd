using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.TypeExpense
{
   public class TypeExpense
    {
        public int id { get; set; }
        [Required]

        public string  description { get; set; }

        public string type { get; set; }

        public Boolean status { get; set; }

        public decimal default_value { get; set; }

    }
}
