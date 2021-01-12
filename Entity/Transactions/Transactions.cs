using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Transactions
{
   public class Transactions
    {
        public int Id { get; set; }
        [Required]

        public int Idtype_expense { get; set; }

        public DateTime Register_date { get; set; }

        public decimal Value { get; set; }

        public bool Status { get; set; }

        public string Comments { get; set; }

    }
}
