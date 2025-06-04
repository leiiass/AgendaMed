using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Infraestrutura.BancoDeDados;

namespace AgendaMed.Infraestrutura.Repositorios
{
    public class EstabelecimentoRepositorio : IEstabelecimentoRepositorio
    {
        private readonly Context _context;
        public EstabelecimentoRepositorio(Context context)
        {
            _context = context;
        }

        public List<Estabelecimento> ObterTodos()
        {
            return _context.Estabelecimentos.ToList();
        }

        public Estabelecimento ObterPorId(int id)
        {
            return _context.Estabelecimentos.FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Estabelecimento estabelecimento)
        {
            _context.Estabelecimentos.Add(estabelecimento);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Estabelecimento estabelecimento)
        {
            var estabelecimentoAhSerEditado = _context.Estabelecimentos.FirstOrDefault(x=>x.Id == id)
                ?? throw new Exception($"Não foi encontrado id {id} no banco de dados.");

            estabelecimentoAhSerEditado.CNPJ = estabelecimento.CNPJ;
            estabelecimentoAhSerEditado.Telefone = estabelecimento.Telefone;
            estabelecimentoAhSerEditado.Tipo = estabelecimento.Tipo;
            estabelecimentoAhSerEditado.Endereco = estabelecimento.Endereco;
            estabelecimentoAhSerEditado.Nome = estabelecimento.Nome;

            _context.Estabelecimentos.Update(estabelecimentoAhSerEditado);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var estabelecimentoAhSerRemovido = _context.Estabelecimentos.FirstOrDefault(x => x.Id == id)
               ?? throw new Exception($"Não foi encontrado id {id} no banco de dados.");
            _context.Remove(estabelecimentoAhSerRemovido);
            _context.SaveChanges();
        }
    }
}
