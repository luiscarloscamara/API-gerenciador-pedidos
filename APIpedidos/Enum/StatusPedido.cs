using System.Text.Json.Serialization;

namespace APIpedidos.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StatusPedido
    {
        Pendente = 1,
        Processando = 2,
        Enviado = 3,
        Concluido = 4,
        Cancelado = 5
    }
}
