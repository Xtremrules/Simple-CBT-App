using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBT.Entities.Abstracts
{
    public interface INamedAuditableEntity : IAuditableEntity
    {
        string Name { get; set; }
    }
}