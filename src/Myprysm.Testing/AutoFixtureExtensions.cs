namespace Myprysm.Testing;

using System.Collections.Concurrent;
using System.Reflection;
using AutoFixture;

public static class AutoFixtureExtensions
{
    private static readonly ConcurrentDictionary<string, IEnumerable<ICustomization>> CustomizationsPerAssembly = new();

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
