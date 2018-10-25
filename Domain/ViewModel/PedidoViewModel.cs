using infra.Model;
using Infra.Enum;

namespace Domain.ViewModel
{
    public class PedidoViewModel
    {
        public string ID { get; set; }

        public string Description { get; set; }

        public decimal Valor { get; set; }

        public PedidoStatus Status { get; set; }

        public static implicit operator PedidoViewModel(PedidoModel d)
        {
            var viewModel = new PedidoViewModel()
            {
                Description = d.Description,
                ID = d.ID,
                Status = d.Status,
                Valor = d.Valor
            };

            return viewModel;
        }
    }
}