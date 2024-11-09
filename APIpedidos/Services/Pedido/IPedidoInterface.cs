﻿using APIpedidos.Dto.Pedido;
using APIpedidos.Models;

namespace APIpedidos.Services.Pedido
{
    public interface IPedidoInterface
    {
        Task<ResponseModel<List<PedidoModel>>> ListarPedidos();
        Task<ResponseModel<PedidoModel>> BuscarPedidoPorId(int idPedido);
        Task<ResponseModel<List<PedidoModel>>> AdicionarPedido(PedidoCriacaoDto pedidoCriacaoDto);

        Task<ResponseModel<List<PedidoModel>>> EditarPedido(PedidoEdicaoDto pedidoEdicaoDto);
        Task<ResponseModel<List<PedidoModel>>> ExcluirPedido(int idPedido);
    }
}
