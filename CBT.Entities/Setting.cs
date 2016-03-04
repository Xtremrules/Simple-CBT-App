using CBT.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBT.Entities
{
    public class Setting : NamedAuditableEntity<int>
    {
        public bool SortQuestion { get; set; }
        public bool SortOptions { get; set; }
    }
}
