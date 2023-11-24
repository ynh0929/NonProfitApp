using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NonProfitLibrary
{
    public class BaseEntity
    {
         public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string ? CreatedBy { get; set; }
        public string ? ModifiedBy { get; set; }
    }
}