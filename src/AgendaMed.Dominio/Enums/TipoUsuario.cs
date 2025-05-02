using System.ComponentModel;

namespace AgendaMed.Dominio.Enums
{
    public enum TipoUsuario
    {
        [Description ("Administrador")]
        Administrador = 0,
        [Description("Medico")]
        Medico = 1,
        [Description("Paciente")]
        Paciente = 2,
        [Description("Estabelecimento")]
        Estabelecimento = 3
    }
}
