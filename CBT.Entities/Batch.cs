using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBT.Entities
{
    public class Batch : Abstracts.NamedAuditableEntity<int>
    {
        public string UniqueNumber { get; set; }

        public ICollection<SQuestion> SQuestions { get; set; }
    }
}
