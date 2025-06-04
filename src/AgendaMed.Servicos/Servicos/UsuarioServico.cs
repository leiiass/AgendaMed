using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Modelos;
using AgendaMed.Dominio.Validadores;

namespace AgendaMed.Servicos.Servicos
{
    public class UsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly UsuarioValidador _usuarioValidador;
        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio, UsuarioValidador usuarioValidador)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _usuarioValidador = usuarioValidador;
        }

        public List<Usuario> ObterTodos()
        {
            return _usuarioRepositorio.ObterTodos();
        }

        public Usuario ObterPorId(int id)
        {
            return _usuarioRepositorio.ObterPorId(id);
        }

        public void Criar(Usuario usuario)
        {
            _usuarioValidador.Validate(usuario);
            _usuarioRepositorio.Criar(usuario);
        }

        public void Atualizar(int id, Usuario usuario)
        {
            _usuarioValidador.Validate(usuario);
            _usuarioRepositorio.Atualizar(id, usuario);
        }

        public void Remover(int id)
        {
            _usuarioRepositorio.Remover(id);
        }
    }
}
