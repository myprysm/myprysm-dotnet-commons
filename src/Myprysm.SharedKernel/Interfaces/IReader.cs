namespace Myprysm.SharedKernel.Interfaces;

/// <summary>
/// <see cref="IReader{TRequest,TResponse}"/> request marker interface.
/// </summary>
public interface IReaderInput
{
    // Empty
}

/// <summary>
/// Reader that reads the requested output from the given request asynchronously.
/// </summary>
/// <typeparam name="TRequest">The request type.</typeparam>
/// <typeparam name="TResponse">The response type.</typeparam>
public interface IReader<in TRequest, TResponse>
    where TRequest : IReaderInput
{
    /// <summary>
    /// Read asynchronously the output for the given request.
    /// </summary>
    /// <param name="request">The request.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>The output corresponding to the request.</returns>
    Task<TResponse> ReadAsync(TRequest request, CancellationToken cancellation = default);
}
