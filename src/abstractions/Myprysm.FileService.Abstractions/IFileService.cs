namespace Myprysm.FileService.Abstractions;

using Myprysm.FileService.Abstractions.Exceptions;
using Myprysm.SharedKernel.Exceptions;

/// <summary>
/// Handle file uploads and downloads in a given container.
/// </summary>
public interface IFileService
{
    /// <summary>
    /// Upload the file in the given container at the given path.
    /// </summary>
    /// <param name="container">The storage container.</param>
    /// <param name="path">The path to store the file in the container.</param>
    /// <param name="content">The file stream.</param>
    /// <param name="contentType">The content type of the file.</param>
    /// <param name="contentLength">The size of the file.</param>
    /// <param name="overwriteExistingFile">Indicates whether an exception should be thrown if a file already exists at the requested path in the container.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>Completes when the file is uploaded.</returns>
    /// <exception cref="FileAlreadyExistsException">When a file already exists at the requested path in the container.</exception>
    Task UploadFile(
        string container,
        string path,
        Stream content,
        string contentType,
        long contentLength,
        bool overwriteExistingFile = false,
        CancellationToken cancellation = default);

    /// <summary>
    /// Download the file in the given container at the given path.
    /// </summary>
    /// <param name="container">The storage container.</param>
    /// <param name="path">The path of the file to download.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>The <see cref="FileDownload"/>.</returns>
    /// <exception cref="NotFoundException">When the requested path cannot be found in the container.</exception>
    Task<FileDownload> DownloadFile(
        string container,
        string path,
        CancellationToken cancellation = default);

    /// <summary>
    /// Remove the file in the given container at the given path.
    /// </summary>
    /// <param name="container">The storage container.</param>
    /// <param name="path">The path of the file to remove.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>When the file is deleted (even if it did not exist).</returns>
    Task RemoveFile(string container, string path, CancellationToken cancellation = default);

    /// <summary>
    /// Create a new storage container if it does not exist already.
    /// </summary>
    /// <param name="container">The storage container.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>When the container is created.</returns>
    Task CreateContainer(string container, CancellationToken cancellation = default);

    /// <summary>
    /// Remove an existing storage container if it exists.
    /// </summary>
    /// <param name="container">The storage container.</param>
    /// <param name="cancellation">The cancellation token.</param>
    /// <returns>When the container is removed.</returns>
    Task RemoveContainer(string container, CancellationToken cancellation = default);
}
