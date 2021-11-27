namespace Myprysm.Testing.NUnit;

using AutoFixture;
using global::NUnit.Framework;

public abstract class FixtureTests
{
    protected Fixture Fixture { get; private set; } = null!;

    [OneTimeSetUp]
    public void SetUpAutoFixture()
    {
        var fixture = new Fixture();

        this.CustomizeFixture(fixture);

        this.Fixture = fixture;
    }

    protected T A<T>()
    {
        return this.Fixture.Create<T>();
    }

    protected List<T> Many<T>(int count = 3)
    {
        return this.Fixture.CreateMany<T>(count).ToList();
    }


    protected virtual void CustomizeFixture(Fixture fixture)
    {
        // Do nothing.
    }
}
