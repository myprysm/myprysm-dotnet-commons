namespace Myprysm.SharedKernel.Interfaces;

/// <summary>
/// <see cref="IWriter{TRequest}"/> output marker interface.
/// </summary>
public interface IWriterRequest
{
    // Empty
}

/// <summary>
///     Writer that writes the provided output to any medium.
/// </summary>
/// <typeparam name="TRequest"></typeparam>
public interface IWriter<in TRequest>
    where TRequest : IWriterRequest
{
    /// <summary>
    ///     Writes the provided output asynchronously.
    /// </summary>
    /// <param name="output">The output to write.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>Completes when the output is written.</returns>
    Task WriteAsync(TRequest output, CancellationToken cancellation = default);
}
