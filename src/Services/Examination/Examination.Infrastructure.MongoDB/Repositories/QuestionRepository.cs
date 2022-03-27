using Examination.Domain.AggregateModels.QuestionAggregate;
using Examination.Infrastructure.SeedWork;
using Examination.Shared.SeedWork;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examination.Infrastructure.Repositories
{
    public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
        public QuestionRepository(IMongoClient mongoClient, IOptions<ExamSettings> settings) 
        : base(mongoClient, settings, Constants.Question)
        {
        }

        public async Task<Question> GetQuestionsByIdAsync(string id)
        {
            FilterDefinition<Question> filter = Builders<Question>.Filter.Eq(s => s.Content, id);
            return await Collection.Find(filter).FirstOrDefaultAsync();
        }


        public async Task<PagedList<Question>> GetQuestionsPagingAsync(string categoryId, string searchKeyword, int pageIndex, int pageSize)
        {
            FilterDefinition<Question> filter = Builders<Question>.Filter.Empty;
            if (!string.IsNullOrEmpty(searchKeyword))
                filter = Builders<Question>.Filter.Where(q => q.Content.Contains(searchKeyword));

            if (!string.IsNullOrEmpty(searchKeyword))
                filter = Builders<Question>.Filter.Eq(s => s.CategoryId, categoryId);

            var totalRow = await Collection.Find(filter).CountDocumentsAsync();
            var items = await Collection.Find(filter)
                .Skip((pageIndex - 1) * pageSize)
                .Limit(pageSize)
                .ToListAsync();

            return new PagedList<Question>(items, totalRow, pageIndex, pageSize);
        }
    }
}