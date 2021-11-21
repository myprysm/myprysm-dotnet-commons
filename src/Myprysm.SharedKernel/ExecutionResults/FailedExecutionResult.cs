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
/// Represents a failed execution for a task/process/handler.
///
/// Can carry errors associated with the failure.
/// </summary>
public class FailedExecutionResult : ExecutionResult
{
    public const string DefaultMessage = "Failed execution";
    public const string MessageTemplate = "Failed execution due to: {0}";

    internal FailedExecutionResult(
        IEnumerable<string> errors)
    {
        this.Errors = errors.ToList().AsReadOnly();
    }

    public IEnumerable<string> Errors { get; }

    public override bool IsSuccess => false;

    public override string ToString()
    {
        return this.Errors.Any()
            ? MessageTemplate.Fmt(string.Join(", ", this.Errors))
            : DefaultMessage;
    }
}
