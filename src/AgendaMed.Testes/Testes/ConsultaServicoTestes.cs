using AgendaMed.Dominio.Modelos;
using AgendaMed.Dominio.Enums;
using AgendaMed.Servicos.Servicos;
using AgendaMed.Testes.ConfiguracaoTestes;

namespace AgendaMed.Testes.Testes
{
    public class ConsultaServicoTestes : IClassFixture<InjecaoFixture>
    {
        private readonly ConsultaServico _consultaServico;
        public ConsultaServicoTestes(InjecaoFixture injecaoFixture)
        {
            _consultaServico = injecaoFixture.ObterServico<ConsultaServico>();
        }

        [Fact]
        public void ao_criar_consulta() 
        {
            var novaConsulta = new Consulta 
            { 
                DataHora = DateTime.Now, 
                MedicoId = 1, 
                EstabelecimentoId = 2, 
                Observacoes = "Teste 1", 
                PacienteId = 2, 
                Status = StatusConsulta.Agendada 
            };

            _consultaServico.Criar(novaConsulta);

            var consultaCriada = _consultaServico.ObterPorId(novaConsulta.Id);

            Assert.NotNull(consultaCriada);
            Assert.Equal(novaConsulta, consultaCriada);
        }

        [Fact]
        public void ao_obter_todas_as_consultas()
        {
            var consultas = _consultaServico.ObterTodos();
            Assert.NotNull(consultas);
            Assert.NotEmpty(consultas);
        }

        [Fact]
        public void ao_obter_consulta_por_id()
        {
            const int id = 1;
            var consulta = _consultaServico.ObterPorId(id);

            Assert.NotNull(consulta);
            Assert.Equal(id, consulta.Id);
        }

        [Fact]
        public void ao_atualizar_consulta()
        {
            const int id = 2;
            var consultaAhSerAtualizada = new Consulta
            {
                PacienteId = 2,
                MedicoId = 2,
                DataHora = DateTime.Today.AddDays(1),
                Observacoes = "Consulta atualizada",
                EstabelecimentoId = 2,
                Status = StatusConsulta.Realizada
            };

             _consultaServico.Atualizar(id, consultaAhSerAtualizada);

            var consulta = _consultaServico.ObterPorId(id);

            Assert.NotNull(consulta);
            Assert.Equal(consultaAhSerAtualizada.Status, StatusConsulta.Realizada);
        }

        [Fact]
        public void ao_remover_consulta()
        {
            const int id = 1;
            _consultaServico.Remover(id);

            var consulta = _consultaServico.ObterPorId(id);

            Assert.Null(consulta);
        }
    }
}
