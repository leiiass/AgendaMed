using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Infraestrutura.BancoDeDados;

namespace AgendaMed.Infraestrutura.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Context _context;
        public UsuarioRepositorio(Context context)
        {
            _context = context;
        }

        public List<Usuario> ObterTodos()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario ObterPorId(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public void Criar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Usuario usuario)
        {
            var usuarioAhSerAtualizado = _context.Usuarios.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"Não foi encontrado usuario com id {id} no banco de dados.");

            usuarioAhSerAtualizado.SenhaHash = usuario.SenhaHash;
            usuarioAhSerAtualizado.Nome = usuario.Nome;
            usuarioAhSerAtualizado.Tipo = usuario.Tipo;
            usuarioAhSerAtualizado.Email = usuario.Email;
            _context.Usuarios.Update(usuarioAhSerAtualizado);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var usuarioAhSerRemovido = _context.Usuarios.FirstOrDefault(x => x.Id == id)
                ?? throw new Exception($"Não foi encontrado usuario com id {id} no banco de dados.");
            _context.Usuarios.Remove(usuarioAhSerRemovido);
            _context.SaveChanges();
        }
    }
}
