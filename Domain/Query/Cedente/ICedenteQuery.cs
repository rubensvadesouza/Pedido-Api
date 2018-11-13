using Domain.ViewModel;
using Infra.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Query.Cedente
{
    public interface ICedenteQuery
    {

        List<CedenteViewModel> Listar();
    }
}
