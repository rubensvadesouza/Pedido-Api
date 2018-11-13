using Infra.Entity;

namespace Infra.Repository
{
    public class CedenteRepository : BaseRepository<CedenteEntity>
    {
        public CedenteRepository(string connectionString, string dataBase) 
            : base(connectionString, dataBase)
        {
        }
    }
}