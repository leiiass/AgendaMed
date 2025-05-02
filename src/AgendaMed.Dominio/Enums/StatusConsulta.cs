using System.ComponentModel;

namespace AgendaMed.Dominio.Enums
{
    public enum StatusConsulta
    {
        [Description ("Agendada")]
        Agendada = 0,
        [Description ("Cancelada")]
        Cancelada = 1,
        [Description ("Realizada")]
        Realizada = 2
    }
}