using Entities;

namespace Repository
{

    public class BackeryRepository : RepositoryBase<Ban>, IBackeryRepository
    {
        public BackeryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}