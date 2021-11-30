namespace Myprysm.Testing.NUnit;

using System.Collections.Concurrent;
using System.Reflection;
using AutoFixture;

/// <summary>
/// Extensions to make AutoFixture configuration easier.
/// </summary>
public static class AutoFixtureExtensions
{
    private static readonly ConcurrentDictionary<string, IEnumerable<ICustomization>> CustomizationsPerAssembly = new();

    /// <summary>
    /// Load the <see cref="ICustomization"/> available in the provided assembly.
    /// </summary>
    /// <param name="fixture">The fixture.</param>
    /// <param name="customizationAssembly">The assembly to load customizations from.</param>
    /// <returns>The fixture for fluent APIs.</returns>
    public static IFixture LoadCustomizations(this IFixture fixture, Assembly customizationAssembly)
    {
        foreach (var customization in GetCustomizations(customizationAssembly))
        {
            fixture.Customize(customization);
        }

        return fixture;
    }

    private static IEnumerable<ICustomization> GetCustomizations(Assembly customizationAssembly)
    {
        var assemblyFullname = customizationAssembly.FullName;
        return CustomizationsPerAssembly.GetOrAdd(
            assemblyFullname ?? string.Empty,
            static (_, assembly) => LoadCustomizations(assembly),
            customizationAssembly
        );
    }

    private static IEnumerable<ICustomization> LoadCustomizations(Assembly customizationAssembly)
    {
        return customizationAssembly
            .GetTypes()
            .Where(type =>
                type.IsPublic && type.IsClass && !type.IsAbstract
                && typeof(ICustomization).IsAssignableFrom(type)
            )
            .Select(type => (ICustomization?)Activator.CreateInstance(type))
            .Where(c => c is not null)
            .Select(c => c!)
            .ToList();
    }
}
