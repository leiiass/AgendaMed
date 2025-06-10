using AgendaMed.Dominio.Enums;
using AgendaMed.Dominio.Modelos;

namespace AgendaMed.Testes.RepositorioMock
{
    public static class DadosMock
    {
        public static List<Consulta> ListaConsultas()
        {
            return new List<Consulta>
            {
                new Consulta
                {
                    Id = 1,
                    PacienteId = 1,
                    MedicoId = 1,
                    DataHora = DateTime.Today,
                    Observacoes = "Consulta para olhar exames.",
                    EstabelecimentoId = 1,
                    Status = StatusConsulta.Agendada
                },
                new Consulta
                {
                    Id = 2,
                    PacienteId = 2,
                    MedicoId = 2,
                    DataHora = DateTime.Today.AddDays(1),
                    Observacoes = "Consulta de rotina",
                    EstabelecimentoId = 2,
                    Status = StatusConsulta.Agendada
                }
            };
        }


        public static List<Estabelecimento> ObterEstabelecimentos()
        {
            return new List<Estabelecimento>
            {
                new Estabelecimento
                {
                    Id = 1,
                    Nome = "Clínica Vida Saudável",
                    Tipo = TipoEstabelecimento.Clinica,
                    Endereco = new Endereco
                    {
                        Rua = "Rua das Flores",
                        Numero = "123",
                        Cidade = "Belo Horizonte",
                        Estado = "MG",
                        CEP = "30123-456"
                    },
                    Telefone = "(31) 98765-4321",
                    CNPJ = "12.345.678/0001-90"
                },
                new Estabelecimento
                {
                    Id = 2,
                    Nome = "Hospital São Lucas",
                    Tipo = TipoEstabelecimento.Hospital,
                    Endereco = new Endereco
                    {
                        Rua = "Av. Brasil",
                        Numero = "456",
                        Cidade = "Belo Horizonte",
                        Estado = "MG",
                        CEP = "30140-070"
                    },
                    Telefone = "(31) 99876-5432",
                    CNPJ = "98.765.432/0001-21"
                },
                new Estabelecimento
                {
                    Id = 3,
                    Nome = "Laboratório Exame",
                    Tipo = TipoEstabelecimento.Laboratorio,
                    Endereco = new Endereco
                    {
                        Rua = "Rua da Saúde",
                        Numero = "789",
                        Cidade = "Belo Horizonte",
                        Estado = "MG",
                        CEP = "30130-000"
                    },
                    Telefone = "(31) 91234-5678",
                    CNPJ = "11.222.333/0001-44"
                }
            };
        }

        public static List<Medico> ObterMedicos()
        {
            return new List<Medico>
            {
                new Medico
                {
                    Id = 1,
                    Nome = "Carlos",
                    Sobrenome = "Silva",
                    CRM = "123456-MG",
                    Email = "carlos.silva@clinicavida.com",
                    Especialidade = Especialidade.ClinicaMedica,
                    EstabelecimentoId = 1
                },
                new Medico
                {
                    Id = 2,
                    Nome = "Fernanda",
                    Sobrenome = "Souza",
                    CRM = "654321-MG",
                    Email = "fernanda.souza@hospitalsl.com",
                    Especialidade = Especialidade.Pediatria,
                    EstabelecimentoId = 2
                },
                new Medico
                {
                    Id = 3,
                    Nome = "Ricardo",
                    Sobrenome = "Lima",
                    CRM = "112233-MG",
                    Email = "ricardo.lima@labexame.com",
                    Especialidade = Especialidade.Cardiologia,
                    EstabelecimentoId = 3
                }
            };
        }

        public static List<Paciente> ObterPacientes()
        {
            return new List<Paciente>
            {
                new Paciente
                {
                    Id = 1,
                    Nome = "Ana",
                    Sobrenome = "Martins",
                    Email = "ana.martins@email.com",
                    DataNascimento = new DateTime(1990, 5, 15),
                    Telefone = "(31) 98888-1111",
                    CPF = "123.456.789-00"
                },
                new Paciente
                {
                    Id = 2,
                    Nome = "João",
                    Sobrenome = "Pereira",
                    Email = "joao.pereira@email.com",
                    DataNascimento = new DateTime(1985, 11, 23),
                    Telefone = "(31) 97777-2222",
                    CPF = "987.654.321-00"
                },
                new Paciente
                {
                    Id = 3,
                    Nome = "Mariana",
                    Sobrenome = "Oliveira",
                    Email = "mariana.oliveira@email.com",
                    DataNascimento = new DateTime(2000, 2, 10),
                    Telefone = "(31) 96666-3333",
                    CPF = "456.789.123-00"
                }
            };
        }

        public static List<Endereco> ObterEnderecos()
        {
            return new List<Endereco>
            {
                new Endereco
                {
                    Id = 1,
                    Rua = "Rua das Palmeiras",
                    Numero = "100",
                    Cidade = "Belo Horizonte",
                    Estado = "MG",
                    CEP = "30110-000"
                },
                new Endereco
                {
                    Id = 2,
                    Rua = "Avenida Central",
                    Numero = "2000",
                    Cidade = "Contagem",
                    Estado = "MG",
                    CEP = "32000-000"
                },
                new Endereco
                {
                    Id = 3,
                    Rua = "Rua da Alegria",
                    Numero = "45A",
                    Cidade = "Betim",
                    Estado = "MG",
                    CEP = "32600-100"
                }
            };
        }

        public static List<Usuario> ObterUsuarios()
        {
            return new List<Usuario>
            {
                new Usuario
                {
                    Id = 1,
                    Nome = "Administrador",
                    Email = "admin@sistema.com",
                    SenhaHash = "hashed_admin_123",
                    Tipo = TipoUsuario.Administrador
                },
                new Usuario
                {
                    Id = 2,
                    Nome = "Dr. João Médico",
                    Email = "joao.medico@sistema.com",
                    SenhaHash = "hashed_joao_456",
                    Tipo = TipoUsuario.Medico
                },
                new Usuario
                {
                    Id = 3,
                    Nome = "Maria Paciente",
                    Email = "maria.paciente@sistema.com",
                    SenhaHash = "hashed_maria_789",
                    Tipo = TipoUsuario.Paciente
                }
            };
        }

    }
}
