using System.Text.Json.Serialization;

namespace Funcionarios.API.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum TurnoEnum
    {
        Manha,
        Tarde,
        Noite
    }
}
