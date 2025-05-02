using AgendaMed.Dominio.Modelos;

namespace AgendaMed.Dominio.Interfaces
{
    public interface IConsultaRepositorio
    {
        public List<Consulta> ObterTodos();
        public Consulta ObterPorId(int id);
        public void Criar(Consulta consulta);
        public void Atualizar(int id, Consulta consulta);
        public void Remover(int id);
    }
}
