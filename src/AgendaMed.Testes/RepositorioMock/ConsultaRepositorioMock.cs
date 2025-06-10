using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;

namespace AgendaMed.Testes.RepositorioMock
{
    public class ConsultaRepositorioMock : IConsultaRepositorio
    {
        private readonly List<Consulta> _consultas = new();
        public void Atualizar(int id, Consulta consulta)
        {
            var consultaAhSerAtualizada = DadosMock.ListaConsultas().FirstOrDefault(x => x.Id == id);
            if (consultaAhSerAtualizada != null)
            {
                consultaAhSerAtualizada.DataHora = consulta.DataHora;
                consultaAhSerAtualizada.Status = consulta.Status;
                consultaAhSerAtualizada.Observacoes = consulta.Observacoes;
                consultaAhSerAtualizada.MedicoId = consulta.MedicoId;
                consultaAhSerAtualizada.PacienteId = consulta.PacienteId;
                consultaAhSerAtualizada.EstabelecimentoId = consulta.EstabelecimentoId;
            }
        }

        public void Criar(Consulta consulta) => DadosMock.ListaConsultas().Add(consulta);

        public Consulta ObterPorId(int id) => DadosMock.ListaConsultas().FirstOrDefault(x => x.Id == id);

        public List<Consulta> ObterTodos() => DadosMock.ListaConsultas();

        public void Remover(int id)
        {
            var consulta = DadosMock.ListaConsultas().FirstOrDefault(x => x.Id == id);
            if (consulta != null)
            {
                _consultas.Remove(consulta);
            }
        }
    }
}
