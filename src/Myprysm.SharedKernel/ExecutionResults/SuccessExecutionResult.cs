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

using Myprysm.SharedKernel.Extensions;

/// <summary>
/// Generic success execution result
/// </summary>
public class SuccessExecutionResult : ExecutionResult
{
    /// <summary>
    /// The default success message.
    /// </summary>
    public const string DefaultMessage = "Successful execution";

    /// <inheritdoc />
    public override bool IsSuccess => true;

    /// <inheritdoc />
    public override string ToString()
    {
        return DefaultMessage;
    }
}

/// <summary>
/// Success execution result with a value.
/// </summary>
/// <typeparam name="TResult">The type of the result value</typeparam>
public class ObjectSuccessExecutionResult<TResult> : SuccessExecutionResult
{
    /// <summary>
    /// The success message template.
    /// </summary>
    public const string MessageTemplate = $"{DefaultMessage}: {{0}}";

    /// <summary>
    /// Create a new <see cref="ObjectSuccessExecutionResult{TResult}"/>.
    /// </summary>
    /// <param name="result">The result.</param>
    public ObjectSuccessExecutionResult(TResult result)
    {
        this.Result = result;
    }

    /// <summary>
    /// The result returned by the execution.
    /// </summary>
    public TResult Result { get; }

    /// <inheritdoc />
    public override string ToString()
    {
        return MessageTemplate.Fmt(this.Result!);
    }
}
