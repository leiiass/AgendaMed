using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Dominio.Validadores;

namespace AgendaMed.Servicos.Servicos
{
    public class MedicoServico
    {
        private readonly IMedicoRepositorio _medicoRepositorio;
        private readonly MedicoValidador _medicoValidador;
        public MedicoServico(IMedicoRepositorio medicoRepositorio, MedicoValidador medicoValidador)
        {
            _medicoRepositorio = medicoRepositorio;
            _medicoValidador = medicoValidador;
        }

        public List<Medico> ObterTodos()
        {
            return _medicoRepositorio.ObterTodos();
        }

        public Medico ObterPorId(int id)
        {
            return _medicoRepositorio.ObterPorId(id);
        }

        public void Criar(Medico medico)
        {
            _medicoValidador.Validate(medico);
            _medicoRepositorio.Criar(medico);
        }

        public void Atualizar(int id, Medico medico)
        {
            _medicoValidador.Validate(medico);
            _medicoRepositorio.Atualizar(id, medico);
        }

        public void Remover(int id)
        {
            _medicoRepositorio.Remover(id);
        }
    }
}
