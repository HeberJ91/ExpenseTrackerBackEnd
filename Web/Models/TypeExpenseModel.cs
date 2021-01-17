using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class TypeExpenseModel
    {
        public int id { get; set; }

        public string description { get; set; }

        public string type { get; set; }

        public bool status { get; set; }

        public decimal default_value { get; set; }
    }
}
