namespace Myprysm.SharedKernel.ExecutionResults;

using Myprysm.SharedKernel.Extensions;

/// <summary>
/// Represents a failed execution because a resource could not be found.
///
/// Can carry errors associated with the failure.
/// </summary>
public class NotFoundExecutionResult : FailedExecutionResult
{
    /// <summary>
    /// The default error message.
    /// </summary>
    internal new const string DefaultMessage = "Resource not found";

    /// <summary>
    /// The error message template.
    /// </summary>
    internal new const string MessageTemplate = "Resource could not be found: {0}";

    internal NotFoundExecutionResult(IEnumerable<string> errors) : base(errors)
    {
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return this.Errors.Any()
            ? MessageTemplate.Fmt(string.Join(", ", this.Errors))
            : DefaultMessage;
    }
}
