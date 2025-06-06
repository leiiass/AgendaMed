using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Dominio.Validadores;

namespace AgendaMed.Servicos.Servicos
{
    public class ConsultaServico
    {
        private readonly IConsultaRepositorio _consultaRepositorio;
        private readonly ConsultaValidador _consultaValidador;
        public ConsultaServico(IConsultaRepositorio consultaRepositorio, ConsultaValidador consultaValidador)
        {
            _consultaRepositorio = consultaRepositorio;
            _consultaValidador = consultaValidador;
        }

        public List<Consulta> ObterTodos()
        {
            return _consultaRepositorio.ObterTodos();
        }

        public Consulta ObterPorId(int id)
        {
            return _consultaRepositorio.ObterPorId(id);
        }

        public void Criar(Consulta consulta) 
        {
            _consultaValidador.Validate(consulta);
            _consultaRepositorio.Criar(consulta);
        }

        public void Atualizar(int id, Consulta consulta)
        {
            _consultaValidador.Validate(consulta);
            _consultaRepositorio.Atualizar(id, consulta);
        }

        public void Remover(int id)
        {
            _consultaRepositorio.Remover(id);
        }
    }
}
