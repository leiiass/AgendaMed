using AgendaMed.Dominio.Enums;

namespace AgendaMed.Dominio.Modelos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string SenhaHash { get; set; }
        public TipoUsuario Tipo { get; set; }
    }
}
