using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Infraestrutura.BancoDeDados;

namespace AgendaMed.Infraestrutura.Repositorios
{
    public class MedicoRepositorio : IMedicoRepositorio
    {
        private readonly Context _context;
        public MedicoRepositorio(Context context)
        {
            _context = context;
        }

        public List<Medico> ObterTodos()
        {
            return _context.Medicos.ToList();
        }

        public Medico ObterPorId(int id)
        {
            return _context.Medicos.FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Medico medico)
        {
            _context.Medicos.Add(medico);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Medico medico)
        {
            var medicoAhSerEditado = _context.Medicos.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"O médico com id {id} não foi encontrado no banco de dados.");

            medicoAhSerEditado.Nome = medico.Nome;
            medicoAhSerEditado.CRM = medico.CRM;
            medicoAhSerEditado.Sobrenome = medico.Sobrenome;
            medicoAhSerEditado.Especialidade = medico.Especialidade;
            medicoAhSerEditado.EstabelecimentoId = medico.EstabelecimentoId;
            medicoAhSerEditado.Email = medico.Email;
            _context.Medicos.Update(medicoAhSerEditado);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var medicoAhSerRemovido = _context.Medicos.FirstOrDefault(x => x.Id == id)
               ?? throw new Exception($"O médico com id {id} não foi encontrado no banco de dados.");
            _context.Medicos.Remove(medicoAhSerRemovido);
            _context.SaveChanges();
        }
    }
}
