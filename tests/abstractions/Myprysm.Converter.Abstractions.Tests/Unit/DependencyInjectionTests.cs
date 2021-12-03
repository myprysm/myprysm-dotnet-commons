namespace Myprysm.Converter.Abstractions.Tests.Unit;

using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Myprysm.Converter.Abstractions;
using Myprysm.Testing.NUnit;
using Myprysm.Tracing.Abstractions;
using NUnit.Framework;

[TestFixture]
[Category(Categories.Unit)]
public class DependencyInjectionTests
{
    [Test]
    public void WithTracing()
    {
        // Arrange
        var provider = GetSut(true);

        // Act
        var converter = provider.GetRequiredService<IConverter>();

        // Assert
        converter.Should().BeOfType<TracedConverter>();
    }

    [Test]
    public void WithoutTracing()
    {
        // Arrange
        var provider = GetSut(false);

        // Act
        var converter = provider.GetRequiredService<IConverter>();

        // Assert
        converter.Should().BeOfType<FakeConverter>();
    }

    private static IServiceProvider GetSut(bool withTracing)
    {
        return new ServiceCollection()
            .TryAddDefaultTracer()
            .Configure<ConverterOptions>(options => options.WithTracing = withTracing)
            .AddSingleton(FakeConverter.Builder.Build())
            .AddSingleton(sp => sp.CreateConverter<ConverterOptions>(
                new TracerIdentity("Converter", null),
                sp => sp.GetRequiredService<FakeConverter>()))
            .BuildServiceProvider();
    }
}
