namespace Myprysm.SharedKernel.Exceptions;

using System.Collections.Immutable;
using Myprysm.SharedKernel.Extensions;

public class ValidationException : DomainException
{
    private ValidationException(IDictionary<string, IEnumerable<string>> errors)
    {
        this.Errors = errors.ToImmutableDictionary();
    }

    public IDictionary<string, IEnumerable<string>> Errors { get; }


    public static ValidationException With(IDictionary<string, IEnumerable<string>> errors)
    {
        return new ValidationException(errors);
    }

    public static ValidationException For(string key, string message)
    {
        return WithError(key, message).Build();
    }

    public static ValidationExceptionBuilder Builder()
    {
        return new ValidationExceptionBuilder();
    }

    public static ValidationExceptionBuilder WithError(string key, string message)
    {
        return Builder().WithError(key, message);
    }

    public class ValidationExceptionBuilder
    {
        private readonly Dictionary<string, IEnumerable<string>> errors = new();

        internal ValidationExceptionBuilder()
        {
        }

        public ValidationException Build()
        {
            return new ValidationException(this.errors);
        }

        // ReSharper disable once MemberHidesStaticFromOuterClass On purpose for fluent chaining
        public ValidationExceptionBuilder WithError(string key, string message)
        {
            var errorList = (List<string>)this.errors.GetOrAdd(key, () => new List<string>());
            errorList.Add(message);
            return this;
        }
    }
}
