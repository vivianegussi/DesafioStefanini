using DesafioStefanini.Models;
using DesafioStefanini.Models.Request;
using DesafioStefanini.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioStefanini.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService= pedidoService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pedidoService.GetAll());
        } 
        
        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(_pedidoService.GetById(id));
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] PedidoRequest pedido)
        {
            if (pedido is null)
            {
                return BadRequest();
            }
            return Ok(_pedidoService.Create(pedido));
        }
        
        [HttpPut]
        public IActionResult Put([FromBody] Pedido pedido)
        {
            if (pedido is null)
            {
                return BadRequest();
            }
            return Ok(_pedidoService.Update(pedido));
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok(_pedidoService.Delete(id));
        }
    }
}
