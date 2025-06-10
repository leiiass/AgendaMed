using AgendaMed.Dominio.Interfaces;
using AgendaMed.Dominio.Validadores;
using AgendaMed.Servicos.Servicos;
using AgendaMed.Testes.RepositorioMock;
using Microsoft.Extensions.DependencyInjection;

namespace AgendaMed.Testes.ConfiguracaoTestes
{
    public class InjecaoFixture : IDisposable
    {
        public IServiceProvider ServiceProvider { get; private set; }
        public InjecaoFixture()
        {
            var services = new ServiceCollection();

            services.AddScoped<ConsultaServico>();
            services.AddScoped<IConsultaRepositorio, ConsultaRepositorioMock>();
            services.AddScoped<ConsultaValidador>();
            services.AddScoped<EnderecoServico>();
            services.AddScoped<EstabelecimentoServico>();
            services.AddScoped<MedicoServico>();
            services.AddScoped<PacienteServico>();
            services.AddScoped<UsuarioServico>();

            ServiceProvider = services.BuildServiceProvider();
        }

        public T ObterServico<T>() => ServiceProvider.GetRequiredService<T>();

        public void Dispose()
        {
            if(ServiceProvider is IDisposable disposable) disposable.Dispose();
        }
    }
}
