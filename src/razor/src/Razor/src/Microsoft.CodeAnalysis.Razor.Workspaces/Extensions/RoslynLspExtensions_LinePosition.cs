﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Text;

namespace Roslyn.LanguageServer.Protocol;

internal static partial class RoslynLspExtensions
{
    public static Position ToPosition(this LinePosition linePosition)
        => RoslynLspFactory.CreatePosition(linePosition.Line, linePosition.Character);
}
