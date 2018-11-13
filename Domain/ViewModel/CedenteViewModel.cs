using Infra.Entity;
using Infra.Enum;
using System.Collections.Generic;

namespace Domain.ViewModel
{
    public class CedenteViewModel
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public IEnumerable<RemessaViewModel> Remessas { get; set; }

        public static implicit operator CedenteViewModel(CedenteEntity e)
        {
            var viewModel = new CedenteViewModel()
            {
                Id = e._id.ToString(),
                Nome = e.Nome.ToString(),
                Remessas = MapRemessas(e.Remessas)
            };

            return viewModel;
        }

        private static IEnumerable<RemessaViewModel> MapRemessas(IEnumerable<RemessaVO> remessas)
        {
            foreach (var remessa in remessas)
            {
                yield return new RemessaViewModel()
                {
                    Id = remessa.Id.ToString(),
                    Nome = remessa.Nome.ToString(),
                    Sacados = MapSacados(remessa.Sacados)
                };
            }
        }

        private static IEnumerable<SacadoViewModel> MapSacados(IEnumerable<SacadoVO> sacados)
        {
            foreach (var sacado in sacados)
            {
                yield return new SacadoViewModel()
                {
                    Criterio1 = sacado.Criterio1,
                    Criterio2 = sacado.Criterio2,
                    Criterio3 = sacado.Criterio3,
                    Duplicata = sacado.Duplicata,
                    Id = sacado.Id.ToString(),
                    Nome = sacado.Nome,
                    Status = sacado.Status,
                    StatusCriterio = sacado.StatusCriterio,
                    Valor = sacado.Valor,
                    Vencimento = sacado.Vencimento
                };
            }
        }
    }

    public class RemessaViewModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }

        public IEnumerable<SacadoViewModel> Sacados { get; set; }
    }

    public class SacadoViewModel
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Duplicata { get; set; }
        public string Vencimento { get; set; }
        public decimal Valor { get; set; }
        public string Criterio1 { get; set; }
        public string Criterio2 { get; set; }
        public string Criterio3 { get; set; }
        public string StatusCriterio { get; set; }

        public SacadoStatus Status { get; set; }
    }
}