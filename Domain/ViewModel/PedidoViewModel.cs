using Infra.Entity;
using Infra.Enum;

namespace Domain.ViewModel
{
    public class PedidoViewModel
    {
        public string ID { get; set; }
        public string Descricao { get; set; }
        public string CNPJ { get; set; }
        public string Empresa { get; set; }
        public decimal Valor { get; set; }

        public PedidoStatus Status { get; set; }

        public static implicit operator PedidoViewModel(PedidoEntity entity)
        {
            var viewModel = new PedidoViewModel()
            {
                Descricao = entity.Descricao,
                ID = entity._id.ToString(),
                CNPJ = entity.CNPJ,
                Empresa = entity.Empresa,
                Status = entity.Status,
                Valor = entity.Valor
            };

            return viewModel;
        }
    }
}