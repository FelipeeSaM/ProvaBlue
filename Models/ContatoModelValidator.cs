using FluentValidation;
using ProvaBlue.Db;

namespace ProvaBlue.Models {
    public class ContatoModelValidator : AbstractValidator<ContatoModel> {

        public ContatoModelValidator() {
            RuleFor(c => c.Nome).NotEmpty().Length(3, 50).WithMessage("O nome deve ter mais de três e menos de 50 caracteres");
            RuleFor(c => c.Email).NotEmpty().EmailAddress().WithMessage("Informe um e-mail em um formato válido");
            RuleFor(c => c.Numero).NotEmpty().WithMessage("Informe o seu número");
        }

    }
}
