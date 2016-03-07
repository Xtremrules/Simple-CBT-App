using CBT.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBT.Domain.Entities
{
    public class Batch : NamedAuditableEntity<int>
    {
        public string UniqueNumber { get; set; }

        public ICollection<SQuestion> SQuestions { get; set; }
    }
}
