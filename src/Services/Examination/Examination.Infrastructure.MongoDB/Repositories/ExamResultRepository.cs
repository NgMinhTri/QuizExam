using System.Threading.Tasks;
using Examination.Domain.AggregateModels.ExamResultAggregate;
using Examination.Infrastructure.SeedWork;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Examination.Infrastructure.Repositories
{
     public class ExamResultRepository : BaseRepository<ExamResult>, IExamResultRepository
    {
        public ExamResultRepository(IMongoClient mongoClient, IOptions<ExamSettings> settings) 
            : base(mongoClient, settings, Constants.ExamResult)
        {
        }

        public async Task<ExamResult> GetDetails(string userId, string examId)
        {
            var filter = Builders<ExamResult>.Filter.Where(s => s.ExamId == examId && s.UserId == userId);
            return await Collection.Find(filter).FirstOrDefaultAsync();
        }
    }
}