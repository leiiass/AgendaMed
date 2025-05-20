using AgendaMed.Dominio.Modelos;
using FluentValidation;

namespace AgendaMed.Dominio.Validadores
{
    public class MedicoValidador : AbstractValidator<Medico>
    {
        public MedicoValidador()
        {
            RuleFor(nome => nome.Nome).NotNull().NotEmpty().WithMessage("O nome é obrigatório.");
            RuleFor(sobrenome => sobrenome.Sobrenome).NotNull().NotEmpty().WithMessage("O sobrenome é obrigatório.");
            RuleFor(email => email.Email).NotNull().NotEmpty().WithMessage("O email é obrigatório.");
            RuleFor(especialidade => especialidade.Especialidade).NotNull().NotEmpty().WithMessage("A especialidade é obrigatória.");
        }
    }
}
