using AgendaMed.Dominio.Enums;

namespace AgendaMed.Dominio.Modelos
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CRM { get; set; }
        public string Email { get; set; }
        public Especialidade Especialidade { get; set; }
        public int EstabelecimentoId { get; set; }

    }
}
