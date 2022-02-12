using FluentValidation;
using People.API.Application.InputModels;

namespace People.API.Application.Validators
{
    public class AddPersonInputModelValidator : AbstractValidator<AddPersonInputModel>
    {
        public AddPersonInputModelValidator()
        {
            RuleFor(im => im.Name)
                .Length(3, 50)
                .WithMessage("Name length should be between 3 and 50.");
        }
    }
}
