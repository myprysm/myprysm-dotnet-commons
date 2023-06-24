namespace Myprysm.SharedKernel.ExecutionResults;

using Myprysm.SharedKernel.Extensions;

/// <summary>
/// Represents a failed execution because the current user is forbidden to access a resource.
///
/// Can carry errors associated with the failure.
/// </summary>
public class ForbiddenExecutionResult : FailedExecutionResult
{ 
    /// <summary>
    /// The default error message.
    /// </summary>
    internal new const string DefaultMessage = "Forbidden access";

    /// <summary>
    /// The error message template.
    /// </summary>
    internal new const string MessageTemplate = "Resource access is forbidden: {0}";

    internal ForbiddenExecutionResult(IEnumerable<string> errors) : base(errors)
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
