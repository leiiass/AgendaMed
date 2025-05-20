using AgendaMed.Dominio.Modelos;
using FluentValidation;

namespace AgendaMed.Dominio.Validadores
{
    public class PacienteValidador : AbstractValidator<Paciente>
    {
        public PacienteValidador()
        {
            RuleFor(nome => nome.Nome).NotEmpty().NotNull().WithMessage("O nome é obrigatório.");
            RuleFor(sobrenome =>  sobrenome.Sobrenome).NotEmpty().NotNull().WithMessage("O sobrenome é obrigatório.");
            RuleFor(email => email.Email).NotEmpty().NotNull().WithMessage("O email é obrigatório.");
            RuleFor(data => data.DataNascimento).NotEmpty().NotNull().WithMessage("A data de nascimento é obrigatória.");
            RuleFor(telefone => telefone.Telefone).NotEmpty().NotNull().WithMessage("O telefone é obrigatório.");
        }
    }
}
