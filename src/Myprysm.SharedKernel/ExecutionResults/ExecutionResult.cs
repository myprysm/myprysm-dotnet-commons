// The MIT License (MIT)
// 
// Copyright (c) 2015-2020 Rasmus Mikkelsen
// Copyright (c) 2015-2020 eBay Software Foundation
// https://github.com/eventflow/EventFlow
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Myprysm.SharedKernel.ExecutionResults;

/// <summary>
/// Represents the execution result of a procedure.
/// </summary>
public abstract class ExecutionResult : IExecutionResult
{
    private static readonly IExecutionResult SuccessResult = new SuccessExecutionResult();
    private static readonly IExecutionResult FailedResult = new FailedExecutionResult(Enumerable.Empty<string>());
    private static readonly IExecutionResult NotFoundResult = new NotFoundExecutionResult(Enumerable.Empty<string>());
    private static readonly IExecutionResult ForbiddenResult = new ForbiddenExecutionResult(Enumerable.Empty<string>());
    private static readonly IExecutionResult ConflictResult = new ConflictExecutionResult(Enumerable.Empty<string>());

    internal ExecutionResult()
    {
    }

    /// <inheritdoc />
    public abstract bool IsSuccess { get; }

    /// <summary>
    /// Returns a successful execution result. 
    /// </summary>
    /// <returns>The successful execution result.</returns>
    public static IExecutionResult Success()
    {
        return SuccessResult;
    }

    /// <summary>
    /// Returns a successful execution result holding a value.
    /// </summary>
    /// <param name="result">The value held by the result.</param>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    /// <returns>An object representing the success of a procedure with the provided result as a context.</returns>
    public static ObjectSuccessExecutionResult<TResult> Success<TResult>(TResult result)
    {
        return new ObjectSuccessExecutionResult<TResult>(result);
    }

    /// <summary>
    /// Returns a failed execution result.
    /// </summary>
    /// <returns>The failed execution result.</returns>
    public static IExecutionResult Failed()
    {
        return FailedResult;
    }

    /// <summary>
    /// Returns a failed execution result with the provided errors.
    /// </summary>
    /// <param name="errors">The errors to report.</param>
    /// <returns>A failed execution result containing the provided errors as a reason.</returns>
    public static IExecutionResult Failed(IEnumerable<string> errors)
    {
        return new FailedExecutionResult(errors);
    }

    /// <summary>
    /// Returns a failed execution result with the provided errors.
    /// </summary>
    /// <param name="errors">The errors to report.</param>
    /// <returns>A failed execution result containing the provided errors as a reason.</returns>
    public static IExecutionResult Failed(params string[] errors)
    {
        return Failed((IEnumerable<string>)errors);
    }
    
    /// <summary>
    /// Returns a not found execution result.
    /// </summary>
    /// <returns>The not found execution result.</returns>
    public static IExecutionResult NotFound()
    {
        return NotFoundResult;
    }

    /// <summary>
    /// Returns a not found execution result with the provided errors.
    /// </summary>
    /// <param name="errors">The errors to report.</param>
    /// <returns>A not found execution result containing the provided errors as a reason.</returns>
    public static IExecutionResult NotFound(IEnumerable<string> errors)
    {
        return new NotFoundExecutionResult(errors);
    }

    /// <summary>
    /// Returns a not found execution result with the provided errors.
    /// </summary>
    /// <param name="errors">The errors to report.</param>
    /// <returns>A not found execution result containing the provided errors as a reason.</returns>
    public static IExecutionResult NotFound(params string[] errors)
    {
        return NotFound((IEnumerable<string>)errors);
    }
    
    /// <summary>
    /// Returns a forbidden execution result.
    /// </summary>
    /// <returns>The forbidden execution result.</returns>
    public static IExecutionResult Forbidden()
    {
        return ForbiddenResult;
    }

    /// <summary>
    /// Returns a forbidden execution result with the provided errors.
    /// </summary>
    /// <param name="errors">The errors to report.</param>
    /// <returns>A forbidden execution result containing the provided errors as a reason.</returns>
    public static IExecutionResult Forbidden(IEnumerable<string> errors)
    {
        return new ForbiddenExecutionResult(errors);
    }

    /// <summary>
    /// Returns a forbidden execution result with the provided errors.
    /// </summary>
    /// <param name="errors">The errors to report.</param>
    /// <returns>A forbidden execution result containing the provided errors as a reason.</returns>
    public static IExecutionResult Forbidden(params string[] errors)
    {
        return Forbidden((IEnumerable<string>)errors);
    }
    
    /// <summary>
    /// Returns a conflict execution result.
    /// </summary>
    /// <returns>The conflict execution result.</returns>
    public static IExecutionResult Conflict()
    {
        return ConflictResult;
    }

    /// <summary>
    /// Returns a conflict execution result with the provided errors.
    /// </summary>
    /// <param name="errors">The errors to report.</param>
    /// <returns>A conflict execution result containing the provided errors as a reason.</returns>
    public static IExecutionResult Conflict(IEnumerable<string> errors)
    {
        return new ConflictExecutionResult(errors);
    }

    /// <summary>
    /// Returns a conflict execution result with the provided errors.
    /// </summary>
    /// <param name="errors">The errors to report.</param>
    /// <returns>A conflict execution result containing the provided errors as a reason.</returns>
    public static IExecutionResult Conflict(params string[] errors)
    {
        return Conflict((IEnumerable<string>)errors);
    }

    /// <summary>
    /// Returns a string representation of this <see cref="ExecutionResult"/>.
    /// </summary>
    /// <returns>The string representation of this result.</returns>
    public override string ToString()
    {
        return $"ExecutionResult - IsSuccess:{this.IsSuccess}";
    }
}
