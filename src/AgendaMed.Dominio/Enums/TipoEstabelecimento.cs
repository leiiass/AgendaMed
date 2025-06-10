using System.ComponentModel;

namespace AgendaMed.Dominio.Enums
{
    public enum TipoEstabelecimento
    {
        [Description ("Clínica")]
        Clinica = 0,
        [Description ("Hospital")]
        Hospital = 1,
        [Description("Laboratório")]
        Laboratorio = 2,
    }
}
