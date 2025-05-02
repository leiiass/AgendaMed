using AgendaMed.Dominio.Modelos;

namespace AgendaMed.Dominio.Interfaces
{
    public interface IEnderecoRepositorio
    {
        public List<Endereco> ObterTodos();
        public Endereco ObterPorId(int id);
        public void Criar(Endereco endereco);
        public void Atualizar(int id, Endereco endereco);
        public void Remover(int id);
    }
}
