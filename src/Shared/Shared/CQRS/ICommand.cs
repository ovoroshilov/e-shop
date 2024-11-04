using MediatR;

namespace Shared.CQRS;

public interface ICommand<out TResponse> : IRequest<TResponse>
    where TResponse : notnull;

public interface ICommand : IRequest<Unit>;
