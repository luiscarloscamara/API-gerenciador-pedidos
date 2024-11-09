using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using APIpedidos.Dto.ItemPedido;
using APIpedidos.Models;
using APIpedidos.Services.ItemPedido;

namespace APIpedidos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemPedidoController : ControllerBase
    {
        private readonly IItemPedidoInterface _itemPedidoInterface;
        public ItemPedidoController(IItemPedidoInterface itemPedidoInterface)
        {
            _itemPedidoInterface = itemPedidoInterface;
        }

        [HttpGet("itens-pedidos")]
        public async Task<ActionResult<ResponseModel<List<ItemPedidoModel>>>> ListarItemPedido()
        {
            var itemPedido = await _itemPedidoInterface.ListarItemPedido();
            return Ok(itemPedido);
        }

        [HttpPost("adicionar/itens-pedidos")]
        public async Task<ActionResult<ResponseModel<List<ItemPedidoModel>>>> AdicionarItemPedido(ItemPedidoDto itemPedidoCriacaoDto)
        {
            var itemPedido = await _itemPedidoInterface.AdicionarItemPedido(itemPedidoCriacaoDto);
            return Ok(itemPedido);
        }


        [HttpPut("editar/itens-pedidos")]
        public async Task<ActionResult<ResponseModel<List<ItemPedidoModel>>>> EditarItemPedido(ItemPedidoDto itemPedidoEdicaoDto)
        {
            var itemPedido = await _itemPedidoInterface.EditarItemPedido(itemPedidoEdicaoDto);
            return Ok(itemPedido);
        }

        [HttpDelete("deletar/itens-pedidos")]
        public async Task<ActionResult<ResponseModel<List<PedidoModel>>>> ExcluirItemPedido(int produtoId, int pedidoId)
        {
            var itemPedido = await _itemPedidoInterface.ExcluirItemPedido(produtoId, pedidoId);
            return Ok(itemPedido);
        }
    }
}
