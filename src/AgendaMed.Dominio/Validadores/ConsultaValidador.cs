using AgendaMed.Dominio.Modelos;
using FluentValidation;

namespace AgendaMed.Dominio.Validadores
{
    public class ConsultaValidador : AbstractValidator<Consulta>
    {
        public ConsultaValidador()
        {
            RuleFor(dataHora => dataHora.DataHora).NotEmpty().NotNull().WithMessage("A data e hora da consulta não pode estar vazia.");
            RuleFor(medico => medico.MedicoId).NotEmpty().NotNull().WithMessage("O médico é obrigatótio.");
            RuleFor(paciente => paciente.PacienteId).NotEmpty().NotNull().WithMessage("O paciente é obrigatótio.");
            RuleFor(estabelecimento => estabelecimento.EstabelecimentoId).NotEmpty().NotNull().WithMessage("O estabelecimento é obrigatótio.");
        }
    }
}
