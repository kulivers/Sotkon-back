using Entities;

namespace Repository
{
    public class RecordsRepository : RepositoryBase<Record>, IRecordsRepository
    {
        public RecordsRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}