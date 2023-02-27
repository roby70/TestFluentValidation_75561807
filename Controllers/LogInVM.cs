using FluentValidation;

namespace TestFluentValidation.Controllers;

public class LogInVM {
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool RememberMe { get; set; } = false;

    public class Validator : FluentValidation.AbstractValidator<LogInVM>
    {
        public Validator() {
            RuleFor(vm => vm.UserName).NotEmpty()
                .WithMessage("Please provide an UserName.");

            RuleFor(vm => vm.Password).NotEmpty()
                .WithMessage("Please provide a Password.");
        }
    }
}
