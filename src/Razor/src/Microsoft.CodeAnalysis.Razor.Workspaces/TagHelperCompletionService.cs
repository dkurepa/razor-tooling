﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

#nullable disable

namespace Microsoft.VisualStudio.Editor.Razor
{
    public abstract class TagHelperCompletionService
    {
        public abstract AttributeCompletionResult GetAttributeCompletions(AttributeCompletionContext completionContext);

        public abstract ElementCompletionResult GetElementCompletions(ElementCompletionContext completionContext);
    }
}
