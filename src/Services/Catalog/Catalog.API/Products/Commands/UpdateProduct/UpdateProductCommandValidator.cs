using FluentValidation;

namespace Catalog.API.Products.Commands.UpdateProduct;

public sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(c => c.UpdateProductId)
            .NotEmpty()
            .WithMessage("Product Id is required");

        RuleFor(c => c.Name)
            .NotEmpty()
            .WithMessage("Name is required")
            .Length(2, 150)
            .WithMessage("Name must be between 2 and 150 characters");

        RuleFor(c => c.Price)
            .GreaterThan(0)
            .WithMessage("Price must be greater then 0");
    }
}