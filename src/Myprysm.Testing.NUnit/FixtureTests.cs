namespace Myprysm.Testing.NUnit;

using AutoFixture;
using global::NUnit.Framework;

/// <summary>
/// Base class that provides fixture customization and support
/// with some facilities to generate objects or lists of objects.
///
/// See <see cref="A{T}"/> and <see cref="Many{T}"/>. 
/// </summary>
public abstract class FixtureTests
{
    /// <summary>
    /// The fixture for the entire test suite.
    /// </summary>
    protected Fixture Fixture { get; private set; } = null!;

    /// <summary>
    /// Create and customize a fixture for the test suite.
    /// </summary>
    [OneTimeSetUp]
    public void SetUpAutoFixture()
    {
        var fixture = new Fixture();

        this.CustomizeFixture(fixture);

        this.Fixture = fixture;
    }

    /// <summary>
    /// Create a single object of the requested type.
    /// </summary>
    /// <typeparam name="T">The type of the object to create.</typeparam>
    /// <returns>An object of the requested type.</returns>
    protected T A<T>()
    {
        return this.Fixture.Create<T>();
    }

    /// <summary>
    /// Create a list of objects of the requested type.
    /// </summary>
    /// <typeparam name="T">The type of the object to create.</typeparam>
    /// <returns>A list of objects of the requested type.</returns>
    protected List<T> Many<T>(int count = 3)
    {
        return this.Fixture.CreateMany<T>(count).ToList();
    }

    /// <summary>
    /// Customize the fixture for the entire test suite.
    /// </summary>
    /// <param name="fixture">The fixture to customize.</param>
    protected virtual void CustomizeFixture(Fixture fixture)
    {
        // Do nothing.
    }
}
