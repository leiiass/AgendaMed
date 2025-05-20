using AgendaMed.Dominio.Modelos;
using FluentValidation;

namespace AgendaMed.Dominio.Validadores
{
    public class EnderecoValidador : AbstractValidator<Endereco>
    {
        public EnderecoValidador()
        {
            RuleFor(rua => rua.Rua).NotEmpty().NotNull().WithMessage("O nome da rua é obrigatório.");
            RuleFor(numero => numero.Numero).NotEmpty().NotNull().WithMessage("O número é obrigatório.");
            RuleFor(cidade => cidade.Cidade).NotEmpty().NotNull().WithMessage("A cidade é obrigatório.");
            RuleFor(cep => cep.CEP).NotEmpty().NotNull().WithMessage("O CEP é obrigatório.");
            RuleFor(estado => estado.Estado).NotEmpty().NotNull().WithMessage("O Estado é obrigatório.");
        }
    }
}
