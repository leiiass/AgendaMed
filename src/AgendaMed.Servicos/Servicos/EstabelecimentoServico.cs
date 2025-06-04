using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Dominio.Validadores;

namespace AgendaMed.Servicos.Servicos
{
    public class EstabelecimentoServico
    {
        private readonly IEstabelecimentoRepositorio _estabelecimentoRepositorio;
        private readonly EstabelecimentoValidador _estabelecimentoValidador;
        public EstabelecimentoServico(IEstabelecimentoRepositorio estabelecimentoRepositorio, EstabelecimentoValidador estabelecimentoValidador)
        {
            _estabelecimentoRepositorio = estabelecimentoRepositorio;
            _estabelecimentoValidador = estabelecimentoValidador;
        }

        public List<Estabelecimento> ObterTodos()
        {
            return _estabelecimentoRepositorio.ObterTodos();
        }

        public Estabelecimento ObterPorId(int id)
        {
            return _estabelecimentoRepositorio.ObterPorId(id);
        }

        public void Criar(Estabelecimento estabelecimento)
        {
            _estabelecimentoValidador.Validate(estabelecimento);
            _estabelecimentoRepositorio.Criar(estabelecimento);
        }

        public void Atualizar(int id, Estabelecimento estabelecimento)
        {
            _estabelecimentoValidador.Validate(estabelecimento);
            _estabelecimentoRepositorio.Atualizar(id, estabelecimento);
        }

        public void Remover(int id)
        {
            _estabelecimentoRepositorio.Remover(id);
        }
    }
}
