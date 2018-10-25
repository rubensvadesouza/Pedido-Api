using Domain.Handler;
using Domain.Read.Pedido;
using Domain.ViewModel;
using infra.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace item_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoReader _reader;
        private readonly PedidoDomain _handler;

        public PedidoController()
        {
            _handler = new PedidoDomain();
            _reader = new PedidoReader();
        }

        [HttpGet]
        public ActionResult<List<PedidoViewModel>> Get()
        {
            return _reader.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<PedidoViewModel> Get(string id)
        {
            return _reader.GetById(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] PedidoModel value)
        {
            _handler.AdicionarPedido(value.Description, value.Valor, value.Status);
            return Ok();
        }

        [HttpPatch("{id}/valor")]
        public ActionResult Put(string id, [FromBody] decimal valor)
        {
            _handler.AtualizarPreco(id, valor);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _handler.RemoverPedido(id);
            return Ok();
        }
    }
}