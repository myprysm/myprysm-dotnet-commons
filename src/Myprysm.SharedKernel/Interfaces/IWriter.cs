namespace Myprysm.SharedKernel.Interfaces;

using Myprysm.SharedKernel.ExecutionResults;

/// <summary>
/// <see cref="IWriter{TRequest}"/> output marker interface.
/// </summary>
public interface IWriterRequest
{
    // Empty
}

/// <summary>
/// Writer that writes the provided output to any medium.
/// </summary>
/// <typeparam name="TRequest"></typeparam>
public interface IWriter<in TRequest>
    where TRequest : IWriterRequest
{
    /// <summary>
    /// Writes the provided output asynchronously.
    /// </summary>
    /// <param name="output">The output to write.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>An <see cref="IExecutionResult"/> indicating whether the operation succeeded.</returns>
    Task<IExecutionResult> WriteAsync(TRequest output, CancellationToken cancellation = default);
}
