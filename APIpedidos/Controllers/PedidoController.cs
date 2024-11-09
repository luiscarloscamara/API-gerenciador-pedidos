using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIpedidos.Dto.Pedido;
using APIpedidos.Enum;
using APIpedidos.Models;
using APIpedidos.Services.Cliente;
using APIpedidos.Services.Pedido;

namespace APIpedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoInterface _pedidoInterface;
        public PedidoController(IPedidoInterface pedidoInterface)
        {
            _pedidoInterface = pedidoInterface;
        }

        [HttpGet("pedidos")]
        public async Task<ActionResult<ResponseModel<List<PedidoModel>>>> ListarPedidos()
        {
            var pedidos = await _pedidoInterface.ListarPedidos();
            return Ok(pedidos);
        }

        [HttpGet("pedidos/{idPedido}")]
        public async Task<ActionResult<ResponseModel<PedidoModel>>> BuscarPedidoPorId(int idPedido)
        {
            var pedido = await _pedidoInterface.BuscarPedidoPorId(idPedido);
            return Ok(pedido);
        }


        [HttpPost("adicionar/pedidos")]
        public async Task<ActionResult<ResponseModel<List<PedidoModel>>>> AdicionarPedido(PedidoCriacaoDto pedidoCriacaoDto)
        {
            var pedidos = await _pedidoInterface.AdicionarPedido(pedidoCriacaoDto);
            return Ok(pedidos);
        }


        [HttpPut("editar/pedidos")]
        public async Task<ActionResult<ResponseModel<List<PedidoModel>>>> EditarPedido(PedidoEdicaoDto pedidoEdicaoDto)
        {
            var pedidos = await _pedidoInterface.EditarPedido(pedidoEdicaoDto);
            return Ok(pedidos);
        }


        [HttpDelete("excluir/pedidos")]
        public async Task<ActionResult<ResponseModel<List<PedidoModel>>>> ExcluirPedido(int idPedido)
        {
            var pedidos = await _pedidoInterface.ExcluirPedido(idPedido);
            return Ok(pedidos);
        }
    }
}
