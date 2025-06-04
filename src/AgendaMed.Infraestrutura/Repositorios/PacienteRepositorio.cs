using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Infraestrutura.BancoDeDados;

namespace AgendaMed.Infraestrutura.Repositorios
{
    public class PacienteRepositorio : IPacienteRepositorio
    {
        private readonly Context _context;
        public PacienteRepositorio(Context context)
        {
            _context = context;
        }

        public List<Paciente> ObterTodos()
        {
            return _context.Pacientes.ToList();
        }

        public Paciente ObterPorId(int id)
        {
           return _context.Pacientes.FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Paciente paciente)
        {
            var pacienteAhSerAtualizado = _context.Pacientes.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"Não foi encontrado paciente com esse id {id} no banco de dados.");

            pacienteAhSerAtualizado.Nome = paciente.Nome;
            pacienteAhSerAtualizado.Sobrenome = paciente.Sobrenome;
            pacienteAhSerAtualizado.Telefone = paciente.Telefone;
            pacienteAhSerAtualizado.CPF = paciente.CPF;
            pacienteAhSerAtualizado.DataNascimento = paciente.DataNascimento;
            pacienteAhSerAtualizado.Email = paciente.Email;
            _context.Pacientes.Update(pacienteAhSerAtualizado);
            _context.SaveChanges();
        }
        
        public void Remover(int id)
        {
            var pacienteAhSerRemovido = _context.Pacientes.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"Não foi encontrado paciente com esse id {id} no banco de dados.");
            _context.Pacientes.Remove(pacienteAhSerRemovido);
            _context.SaveChanges();
        }
    }
}
