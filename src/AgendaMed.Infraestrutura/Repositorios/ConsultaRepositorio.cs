using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Infraestrutura.BancoDeDados;

namespace AgendaMed.Infraestrutura.Repositorios
{
    public class ConsultaRepositorio : IConsultaRepositorio
    {
        private readonly Context _context;
        public ConsultaRepositorio(Context context)
        {
            _context = context;
        }

        public List<Consulta> ObterTodos()
        {
            return _context.Consultas.ToList();
        }

        public Consulta ObterPorId(int id)
        {
            return _context.Consultas.FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Consulta consulta)
        {
            _context.Consultas.Add(consulta);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Consulta consulta)
        {
            var consultaAhSerEditada = _context.Consultas.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"Não foi encontrado consulta com o id {id} no banco de dados.");

            consultaAhSerEditada.DataHora = consulta.DataHora;
            consultaAhSerEditada.Status = consulta.Status;
            consultaAhSerEditada.MedicoId = consulta.MedicoId;
            consultaAhSerEditada.PacienteId = consulta.PacienteId;
            consultaAhSerEditada.Observacoes = consulta.Observacoes;
            consultaAhSerEditada.EstabelecimentoId = consulta.EstabelecimentoId;
            _context.Consultas.Update(consultaAhSerEditada);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var consultaAhSerRemovida = _context.Consultas.FirstOrDefault( x => x.Id == id) 
                ?? throw new Exception($"Não foi encontrado consulta com o id {id} no banco de dados."); ;
            _context.Consultas.Remove(consultaAhSerRemovida);
            _context.SaveChanges();
        }
    }
}
