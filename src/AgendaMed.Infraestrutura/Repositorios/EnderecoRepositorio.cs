using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Infraestrutura.BancoDeDados;

namespace AgendaMed.Infraestrutura.Repositorios
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private readonly Context _context;
        public EnderecoRepositorio(Context context)
        {
            _context = context;
        }

        public List<Endereco> ObterTodos()
        {
            return _context.Enderecos.ToList();
        }

        public Endereco ObterPorId(int id)
        {
            return _context.Enderecos.FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Endereco endereco)
        {
            var enderecoAhSerEditado = _context.Enderecos.FirstOrDefault(x =>x.Id == id)
                ?? throw new Exception($"Não foi encontrado endereço com id {id} no banco de dados.");

            enderecoAhSerEditado.Numero = endereco.Numero;
            enderecoAhSerEditado.CEP = endereco.CEP;
            enderecoAhSerEditado.Cidade = endereco.Cidade;
            enderecoAhSerEditado.Rua = endereco.Rua;
            enderecoAhSerEditado.Estado = endereco.Estado;
            _context.Enderecos.Update(enderecoAhSerEditado);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var enderecoAhSerRemovido = _context.Enderecos.FirstOrDefault(x => x.Id == id)
               ?? throw new Exception($"Não foi encontrado endereço com id {id} no banco de dados.");
            _context.Enderecos.Remove(enderecoAhSerRemovido);
            _context.SaveChanges();
        }
    }
}
