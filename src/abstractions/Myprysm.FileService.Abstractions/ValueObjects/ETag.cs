namespace Myprysm.FileService.Abstractions.ValueObjects;

using Myprysm.SharedKernel.ValueObjects;

public class ETag : SingleValueObject<string>
{
    public static readonly ETag All = From("*");

    public ETag(string value) : base(value)
    {
    }

    public static ETag From(string etag)
    {
        return new ETag(etag);
    }
}
