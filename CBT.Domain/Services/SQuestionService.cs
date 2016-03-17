using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CBT.Domain.Services
{
    class SQuestionService : EntityService<SQuestion>, ISQuestionService
    {
        public SQuestionService(CBTDbContext context) : base(context) { }

        public override IEnumerable<SQuestion> GetAll()
        {
            var d = _dbset.Include(x => x.Questions)
                .Include(x => x.Setting).ToList();
            return d;
        }
    }
}