namespace Myprysm.SharedKernel.ExecutionResults;

using Myprysm.SharedKernel.Extensions;

/// <summary>
/// Represents a failed execution because the current operation created a conflict between some resource.
///
/// Can carry errors associated with the failure.
/// </summary>
public class ConflictExecutionResult : FailedExecutionResult
{
    /// <summary>
    /// The default error message.
    /// </summary>
    internal new const string DefaultMessage = "Resource conflict";

    /// <summary>
    /// The error message template.
    /// </summary>
    internal new const string MessageTemplate = "Resources conflicted: {0}";

    internal ConflictExecutionResult(IEnumerable<string> errors) : base(errors)
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
