﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

#nullable disable

using Microsoft.AspNetCore.Razor.LanguageServer.Protocol;
using Microsoft.VisualStudio.LanguageServer.Protocol;

namespace Microsoft.VisualStudio.LanguageServerClient.Razor
{
    internal class RazorDocumentRangeFormattingParams
    {
        public RazorLanguageKind Kind { get; set; }

        public string HostDocumentFilePath { get; set; }

        public Range ProjectedRange { get; set; }

        public FormattingOptions Options { get; set; }
    }
}
