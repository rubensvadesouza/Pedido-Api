using Domain.Pedido;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Pedido.Request;
using System.Collections.Generic;

namespace item_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoDomain _domain;

        public PedidoController()
        {
            _domain = new PedidoDomain();
        }

        [HttpGet]
        public ActionResult<List<PedidoViewModel>> Get()
        {
            return Ok(_domain.Listar());
        }

        [HttpGet("{id}")]
        public ActionResult<PedidoViewModel> Get(string id)
        {
            var ret = _domain.ObterPorId(id);
            return Ok(ret);
        }

        [HttpPost]
        public ActionResult Post([FromBody] PedidoRequest request)
        {
            _domain.AdicionarPedido(request.Descricao, request.Empresa, request.CNPJ, request.Valor, request.Status);
            return Ok();
        }

        [HttpPatch("{id}/valor")]
        public ActionResult Put(string id, [FromBody] decimal valor)
        {
            _domain.AtualizarPreco(id, valor);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _domain.RemoverPedido(id);
            return Ok();
        }
    }
}