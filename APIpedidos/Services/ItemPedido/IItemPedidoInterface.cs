using APIpedidos.Dto.ItemPedido;
using APIpedidos.Models;

namespace APIpedidos.Services.ItemPedido
{
    public interface IItemPedidoInterface
    {
        Task<ResponseModel<List<ItemPedidoModel>>> ListarItemPedido();
        Task<ResponseModel<List<ItemPedidoModel>>> AdicionarItemPedido(ItemPedidoDto itemPedidoCriacaoDto);
        Task<ResponseModel<List<ItemPedidoModel>>> EditarItemPedido(ItemPedidoDto itemPedidoEdicaoDto);
        Task<ResponseModel<List<ItemPedidoModel>>> ExcluirItemPedido(int produtoId, int pedidoId);
    }
}
