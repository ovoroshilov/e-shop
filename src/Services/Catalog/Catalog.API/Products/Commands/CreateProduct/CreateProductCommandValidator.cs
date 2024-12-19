using FluentValidation;

namespace Catalog.API.Products.Commands.CreateProduct;

public sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is required");

        RuleFor(x => x.Categories)
            .NotEmpty()
            .WithMessage("Category is required");

        RuleFor(x => x.ImageFile)
            .NotEmpty()
            .WithMessage("ImagePath is required");

        RuleFor(x => x.Price)
            .GreaterThan(0)
            .WithMessage("Price must be greater then 0");
    }
}