namespace Myprysm.ImageService.ImageSharp;

/// <summary>
/// The memory pool kind.
/// </summary>
public enum MemoryPoolKind
{
    /// <summary>
    /// This is the default memory pool from ImageSharp and should fit most usages.
    /// </summary>
    Default,
    
    /// <summary>
    /// This is a minimal memory pool from ImageSharp for environments with hard resource constraints.
    /// </summary>
    Minimal,
    
    /// <summary>
    /// This is a minimal memory pool from ImageSharp for environments with some resource constraints.
    /// </summary>
    Medium,
    
    /// <summary>
    /// This is a large memory pool from ImageSharp for environments without constraints.
    /// </summary>
    Large,
}
