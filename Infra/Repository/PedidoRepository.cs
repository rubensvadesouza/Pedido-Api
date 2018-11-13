using Infra.Entity;

namespace Infra.Repository
{
    public class PedidoRepository : BaseRepository<PedidoEntity>
    {
        public PedidoRepository(string connectionString, string dataBase) : base(connectionString, dataBase)
        {
        }
    }
}