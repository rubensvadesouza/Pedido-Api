using Domain.Pedido;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace item_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CedenteController : ControllerBase
    {
        private readonly ICedenteDomain _domain;

        public CedenteController()
        {
            _domain = new CedenteDomain();
        }

        [HttpGet]
        public ActionResult<List<CedenteViewModel>> Get()
        {
            return Ok(_domain.Listar());
        }
    }
}