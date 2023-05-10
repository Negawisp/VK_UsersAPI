namespace Application.Service
{
    /// <summary>
    /// An interface for a request handler.
    /// The interface demands its successor to implement an asynchronous handler of a request.
    /// </summary>
    /// <typeparam name="RequestT">Request type to handle</typeparam>
    /// <typeparam name="ResponseT">A type of a return-value of a corresponding response</typeparam>
    internal interface IRequestHandler<RequestT, ResponseT>
        where RequestT : IRequest<ResponseT>
    {
        public Task<ResponseT> Handle(RequestT request, CancellationToken cancellationToken);
    }
}
