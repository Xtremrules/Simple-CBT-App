using CBT.Domain.Abstracts.Services;
using CBT.Domain.Concrete;
using CBT.Domain.Entities;
using System.Data.Entity;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;
using CBT.Domain.Extensions;
using CBT.Domain.Models;

namespace CBT.Domain.Services
{
    class BatchService : EntityService<Batch>, IBatchService
    {
        public BatchService(CBTDbContext context) : base(context) { }

        public IEnumerable<BatchModel> GetAllBatches()
        {
            var all = base.GetAll();
            var allBatches = new List<BatchModel>();
            all.ToList().ForEach(x => allBatches.Add(new BatchModel(x)));
            return allBatches;
        }

        public async Task<BatchModel> GetBatchbyId(int Id)
        {
            var batch = await base.GetByIdAsync(Id);
            if (batch == null)
                return default(BatchModel);
            else
                return new BatchModel(batch);
        }

        public async Task<Batch> GetByUniqueNumberAsync(string UniqueNumber)
        {
            return await _dbset.SingleOrDefaultAsync(x => x.UniqueNumber == UniqueNumber);
        }

        public async Task<Batch> ReturnBatchQuestions(string UniqueNumber)
        {
            _context.Configuration.LazyLoadingEnabled = false;
            _context.Configuration.AutoDetectChangesEnabled = false;
            var batch = await GetByUniqueNumberAsync(UniqueNumber);
            if (batch == null)
                throw new NullReferenceException("Batch Not found");

            batch.SQuestions = new List<SQuestion>();

            using (var context = _context)
            {
                var squestions = await context.SQuestions.AsQueryable().Where(x => x.BatchID == batch.ID).ToListAsync();
                if (squestions.Count == 0)
                    throw new NullReferenceException("Batch has no question");
                for (int i = 0; i < squestions.Count; i++)
                {
                    squestions[i].Questions = new List<Question>();
                    var Setting = await context.Settings.FindAsync(squestions[i].SettingID);
                    var questions = await context.Questions
                        .Where(x => x.SQuestionID == squestions[i].ID)
                        .Take(squestions[i].NumberofQuestions).ToListAsync();
                    if (Setting == null ? Setting.SortQuestion : false)
                        questions.Shuffle();
                    for (int z = 0; z < questions.Count; z++)
                    {
                        questions[z].Options = new List<Option>();
                        var options = await context.Options.Where(x => x.QuestionID == questions[z].ID).ToListAsync();
                        if (Setting == null ? Setting.SortOptions : false)
                            options.Shuffle();
                        questions[z].Options = new List<Option>(options);
                    }
                    squestions[i].Questions = new List<Question>(questions);
                }

                batch.SQuestions = new List<SQuestion>(squestions);
            }

            _context.Configuration.LazyLoadingEnabled = true;
            _context.Configuration.AutoDetectChangesEnabled = true;

            return batch;
        }
    }
}