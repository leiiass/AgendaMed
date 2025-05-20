using AgendaMed.Dominio.Modelos;
using FluentValidation;

namespace AgendaMed.Dominio.Validadores
{
    public class UsuarioValidador : AbstractValidator<Usuario>
    {
        public UsuarioValidador()
        {
            RuleFor(nome => nome.Nome).NotNull().NotEmpty().WithMessage("O nome é obrigatório.");
            RuleFor(email => email.Email).NotNull().NotEmpty().WithMessage("O email é obrigatório.");
            RuleFor(senha => senha.SenhaHash).NotNull().NotEmpty().WithMessage("A senha é obrigatória.");
            RuleFor(tipo => tipo.Tipo).NotNull().NotEmpty().WithMessage("O tipo de usuário é obrigatório.");
        }
    }
}
