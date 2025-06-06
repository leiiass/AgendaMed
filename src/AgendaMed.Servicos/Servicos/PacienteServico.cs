using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Dominio.Validadores;

namespace AgendaMed.Servicos.Servicos
{
    public class PacienteServico
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;
        private readonly PacienteValidador _pacienteValidador;
        public PacienteServico(IPacienteRepositorio pacienteRepositorio, PacienteValidador pacienteValidador)
        {
            _pacienteRepositorio = pacienteRepositorio;
            _pacienteValidador = pacienteValidador;
        }

        public List<Paciente> ObterTodos()
        {
            return _pacienteRepositorio.ObterTodos();
        }

        public Paciente ObterPorId(int id)
        {
            return _pacienteRepositorio.ObterPorId(id);
        }

        public void Criar(Paciente paciente)
        {
            _pacienteValidador.Validate(paciente);
            _pacienteRepositorio.Criar(paciente);
        }

        public void Atualizar(int id, Paciente paciente)
        {
            _pacienteValidador.Validate(paciente);
            _pacienteRepositorio.Atualizar(id, paciente);
        }

        public void Remover(int id)
        {
            _pacienteRepositorio.Remover(id);
        }
    }
}
