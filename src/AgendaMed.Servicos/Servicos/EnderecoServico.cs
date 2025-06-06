using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Dominio.Validadores;

namespace AgendaMed.Servicos.Servicos
{
    public class EnderecoServico
    {
        private readonly IEnderecoRepositorio _enderecoRepositorio;
        private readonly EnderecoValidador _enderecoValidador;
        public EnderecoServico(IEnderecoRepositorio enderecoRepositorio, EnderecoValidador enderecoValidador)
        {
            _enderecoRepositorio = enderecoRepositorio;
            _enderecoValidador = enderecoValidador;
        }

        public List<Endereco> ObterTodos()
        {
            return _enderecoRepositorio.ObterTodos();
        }

        public Endereco ObterPorId(int id)
        {
            return _enderecoRepositorio.ObterPorId(id);
        }

        public void Criar(Endereco endereco)
        {
            _enderecoValidador.Validate(endereco);
            _enderecoRepositorio.Criar(endereco);
        }

        public void Atualizar(int id, Endereco endereco)
        {
            _enderecoValidador.Validate(endereco);
            _enderecoRepositorio.Atualizar(id, endereco);
        }

        public void Remover(int id)
        {
            _enderecoRepositorio.Remover(id);
        }
    }
}
