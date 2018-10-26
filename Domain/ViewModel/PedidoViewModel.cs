using infra.Model;
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

        public static implicit operator PedidoViewModel(PedidoModel d)
        {
            var viewModel = new PedidoViewModel()
            {
                Descricao = d.Descricao,
                CNPJ = d.CNPJ,
                Empresa = d.Empresa,
                ID = d.ID,
                Status = d.Status,
                Valor = d.Valor
            };

            return viewModel;
        }
    }
}