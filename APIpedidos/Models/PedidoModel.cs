﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using APIpedidos.Enum;

namespace APIpedidos.Models
{
    public class PedidoModel
    {
        [Key]
        public int Id { get; set; }
        public int ClienteId { get; set; } // Chave estrangeira

        [JsonIgnore]
        public ClienteModel Cliente { get; set; } // Propriedade de navegação

        public int StatusPedidoId { get; set; } // Chave estrangeira

        [JsonIgnore]
        public StatusPedidoModel StatusPedido { get; set; } // Propriedade de navegação
        public DateTime DataPedido { get; set; }

        [JsonIgnore]
        public string NomeStatus => ((StatusPedido)StatusPedidoId).ToString();

        [JsonIgnore]
        public ICollection<ItemPedidoModel> ItemsPedido { get; set; }

    }
}
