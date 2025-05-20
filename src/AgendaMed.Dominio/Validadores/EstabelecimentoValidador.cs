using AgendaMed.Dominio.Modelos;
using FluentValidation;

namespace AgendaMed.Dominio.Validadores
{
    public class EstabelecimentoValidador : AbstractValidator<Estabelecimento>
    {
        public EstabelecimentoValidador()
        {
            RuleFor(nome => nome.Nome).NotEmpty().NotNull().WithMessage("O nome é obrigatório");
            RuleFor(tipo => tipo.Tipo).NotEmpty().NotNull().WithMessage("O tipo é obrigatório");
            RuleFor(endereco => endereco.Endereco).NotEmpty().NotNull().WithMessage("O endereço é obrigatório");
            RuleFor(telefone => telefone.Telefone).NotEmpty().NotNull().WithMessage("O telefone é obrigatório");
            RuleFor(cnpj => cnpj.CNPJ).NotEmpty().NotNull().WithMessage("O CNPJ é obrigatório");
        }
    }
}
