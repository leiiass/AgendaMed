using AgendaMed.Dominio.Modelos;

namespace AgendaMed.Dominio.Interfaces
{
    public interface IEstabelecimentoRepositorio
    {
        public List<Estabelecimento> ObterTodos();
        public Estabelecimento ObterPorId(int id);
        public void Criar(Estabelecimento estabelecimento);
        public void Atualizar(int id, Estabelecimento estabelecimento);
        public void Remover(int id);
    }
}
