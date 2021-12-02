namespace Myprysm.PubSub.Abstractions;

using Myprysm.SharedKernel.ValueObjects;

/// <summary>
/// Represents a topic to send a <see cref="Publication"/>.
/// </summary>
/// <remarks>
/// The validity of the topic name may vary depending on the implementation.
/// </remarks>
public class Topic : SingleValueObject<string>
{
    /// <summary>
    /// Creates a new <see cref="Topic"/>.
    /// </summary>
    /// <param name="value">The value of the topic</param>
    public Topic(string value) : base(value)
    {
    }
}
