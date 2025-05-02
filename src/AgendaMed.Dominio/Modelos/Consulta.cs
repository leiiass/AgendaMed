using AgendaMed.Dominio.Enums;

namespace AgendaMed.Dominio.Modelos
{
    public class Consulta
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public int EstabelecimentoId { get; set; }
        public StatusConsulta Status { get; set; }
        public string Observacoes { get; set; }
    }
}
