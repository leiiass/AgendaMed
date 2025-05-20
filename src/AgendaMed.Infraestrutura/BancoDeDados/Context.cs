using AgendaMed.Dominio.Modelos;
using Microsoft.EntityFrameworkCore;

namespace AgendaMed.Infraestrutura.BancoDeDados
{
    public class Context : DbContext
    {
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Estabelecimento> Estabelecimentos { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
