// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// Defines methods to support the comparison of objects of type FileContent for equality.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "0.56.0.0")]
    internal sealed class FileContentEqualityComparer : IEqualityComparer<FileContent>
    {
        internal static readonly FileContentEqualityComparer Instance = new FileContentEqualityComparer();

        public bool Equals(FileContent left, FileContent right)
        {
            if (ReferenceEquals(left, right))
            {
                return true;
            }

            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
            {
                return false;
            }

            if (left.Text != right.Text)
            {
                return false;
            }

            if (left.Binary != right.Binary)
            {
                return false;
            }

            return true;
        }

        public int GetHashCode(FileContent obj)
        {
            if (ReferenceEquals(obj, null))
            {
                return 0;
            }

            int result = 17;
            unchecked
            {
                if (obj.Text != null)
                {
                    result = (result * 31) + obj.Text.GetHashCode();
                }

                if (obj.Binary != null)
                {
                    result = (result * 31) + obj.Binary.GetHashCode();
                }
            }

            return result;
        }
    }
}