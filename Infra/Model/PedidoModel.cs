using Infra.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace infra.Model
{
    public class PedidoModel
    {
        public string ID { get; set; }

        public string Description { get; set; }

        public decimal Valor { get; set; }

        public PedidoStatus Status { get; set; }
    }
}
