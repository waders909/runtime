// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.ComponentModel;

namespace Microsoft.CSharp.RuntimeBinder
{
    /// <summary>
    /// Represents information about C# dynamic operations that are not specific to particular arguments at a call site.
    /// Instances of this class are generated by the C# compiler.
    /// </summary>
    [Flags, EditorBrowsable(EditorBrowsableState.Never)]
    public enum CSharpBinderFlags
    {
        /// <summary>
        /// There is no additional information required for this binder.
        /// </summary>
        None = 0x00000000,

        /// <summary>
        /// The evaluation of this binder happens in a checked context.
        /// </summary>
        CheckedContext = 0x00000001,

        /// <summary>
        /// The binder represents an invoke on a simple name.
        /// </summary>
        InvokeSimpleName = 0x00000002,

        /// <summary>
        /// The binder represents an invoke on a specialname.
        /// </summary>
        InvokeSpecialName = 0x00000004,

        /// <summary>
        /// The binder represents a logical AND or logical OR that is part of a conditional logical operator evaluation.
        /// </summary>
        BinaryOperationLogical = 0x00000008,

        /// <summary>
        /// The binder represents an explicit conversion.
        /// </summary>
        ConvertExplicit = 0x00000010,

        /// <summary>
        /// The binder represents an implicit conversion for use in an array creation expression.
        /// </summary>
        ConvertArrayIndex = 0x00000020,

        /// <summary>
        /// The result of any bind is going to be indexed get a set index or get index binder.
        /// </summary>
        ResultIndexed = 0x00000040,

        /// <summary>
        /// The value in this set index or set member comes a compound assignment operator.
        /// </summary>
        ValueFromCompoundAssignment = 0x00000080,

        /// <summary>
        /// The binder is used in a position that does not require a result, and can therefore bind to a void returning method.
        /// </summary>
        ResultDiscarded = 0x00000100,
    }
}
