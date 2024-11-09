using System.Text.Json.Serialization;
using APIpedidos.Models;

namespace APIpedidos.Dto.Pedido
{
    public class PedidoEdicaoDto
    {
        public int Id { get; set; }
        public int ClienteId { get; set; } 
        public int StatusPedidoId { get; set; } 
        public DateTime DataPedido { get; set; }

    }
}
