﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using APIpedidos.Enum;

namespace APIpedidos.Models
{
    public class StatusPedidoModel
    {
        [Key]
        public int Id { get; set; }
        public StatusPedido Status { get; set; }


        [JsonIgnore]
        public ICollection<PedidoModel> Pedidos { get; set; } = new List<PedidoModel>();
    }
}
