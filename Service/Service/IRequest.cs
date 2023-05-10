namespace Application.Service
{
    /// <summary>
    /// A marker-interface for service requests
    /// </summary>
    /// <typeparam name="ResponseT">A type of a return-value of a corresponding response</typeparam>
    public interface IRequest<ResponseT> {}
}
