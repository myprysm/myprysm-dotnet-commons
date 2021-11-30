namespace Myprysm.SharedKernel.Exceptions;

using System.Collections.Immutable;
using Myprysm.SharedKernel.Extensions;

/// <summary>
/// Represents an exceptional case
/// when a resource is considered invalid as part of a validation procedure.
/// </summary>
/// <remarks>
/// You can use this exception as a flow control exception.
/// </remarks>
public class ValidationException : DomainException
{
    private ValidationException(IDictionary<string, IEnumerable<string>> errors)
    {
        this.Errors = errors.ToImmutableDictionary();
    }

    /// <summary>
    /// The errors reporting during the validation procedure.
    /// </summary>
    public IDictionary<string, IEnumerable<string>> Errors { get; }

    /// <summary>
    /// Creates a <see cref="ValidationException"/> with the provided errors dictionary.
    ///
    /// Exceptional values should be reported as an enumeration of failures to validate against a given property.
    /// </summary>
    /// <param name="errors">The errors incurring the <see cref="ValidationException"/>.</param>
    /// <returns>The validation exception.</returns>
    public static ValidationException With(IDictionary<string, IEnumerable<string>> errors)
    {
        return new ValidationException(errors);
    }

    /// <summary>
    /// Creates a <see cref="ValidationException"/> with the provided error message for the provide key.
    /// </summary>
    /// <param name="key">The key of the error incurring the <see cref="ValidationException"/>.</param>
    /// <param name="message">The reason why the error has been thrown.</param>
    /// <returns>The validation exception.</returns>
    public static ValidationException For(string key, string message)
    {
        return WithError(key, message).Build();
    }

    /// <summary>
    /// Creates a new <see cref="ValidationExceptionBuilder"/>
    /// that allows to configure multiple errors for multiple keys.
    /// </summary>
    /// <returns>The <see cref="ValidationException"/> builder.</returns>
    public static ValidationExceptionBuilder Builder() => new();

    /// <summary>
    /// Creates a new <see cref="ValidationExceptionBuilder"/> initialized with the provided key and message
    /// that allows to configure multiple errors for multiple keys.
    /// </summary>
    /// <returns>The <see cref="ValidationException"/> builder.</returns>
    public static ValidationExceptionBuilder WithError(string key, string message)
    {
        return Builder().WithError(key, message);
    }

    /// <summary>
    /// A builder for a <see cref="ValidationException"/>
    /// that allows to configure fluently an exceptional validation case.
    /// </summary>
    public class ValidationExceptionBuilder
    {
        private readonly Dictionary<string, IEnumerable<string>> errors = new();

        internal ValidationExceptionBuilder()
        {
        }

        /// <summary>
        /// Build the <see cref="ValidationException"/> represented by this builder.
        /// </summary>
        /// <returns>The exception represented by this builder.</returns>
        public ValidationException Build()
        {
            return new ValidationException(this.errors);
        }

        /// <summary>
        /// Adds the error message to the provided key. 
        /// </summary>
        /// <param name="key">The key of the error.</param>
        /// <param name="message">The reason of the error.</param>
        /// <returns>This builder.</returns>
        // ReSharper disable once MemberHidesStaticFromOuterClass On purpose for fluent chaining
        public ValidationExceptionBuilder WithError(string key, string message)
        {
            var errorList = (List<string>)this.errors.GetOrAdd(key, () => new List<string>());
            errorList.Add(message);
            return this;
        }
    }
}
