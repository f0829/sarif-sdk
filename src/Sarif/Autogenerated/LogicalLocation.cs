// Copyright (c) Microsoft.  All Rights Reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Microsoft.CodeAnalysis.Sarif
{
    /// <summary>
    /// A logical location of a construct that produced a result.
    /// </summary>
    [DataContract]
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "0.56.0.0")]
    public partial class LogicalLocation : ISarifNode
    {
        public static IEqualityComparer<LogicalLocation> ValueComparer => LogicalLocationEqualityComparer.Instance;

        public bool ValueEquals(LogicalLocation other) => ValueComparer.Equals(this, other);
        public int ValueGetHashCode() => ValueComparer.GetHashCode(this);

        /// <summary>
        /// Gets a value indicating the type of object implementing <see cref="ISarifNode" />.
        /// </summary>
        public SarifNodeKind SarifNodeKind
        {
            get
            {
                return SarifNodeKind.LogicalLocation;
            }
        }

        /// <summary>
        /// Identifies the construct in which the result occurred. For example, this property might contain the name of a class or a method.
        /// </summary>
        [DataMember(Name = "name", IsRequired = false, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The human-readable fully qualified name of the logical location.
        /// </summary>
        [DataMember(Name = "fullyQualifiedName", IsRequired = false, EmitDefaultValue = false)]
        public string FullyQualifiedName { get; set; }

        /// <summary>
        /// The machine-readable name for the logical location, such as a mangled function name provided by a C++ compiler that encodes calling convention, return type and other details along with the function name.
        /// </summary>
        [DataMember(Name = "decoratedName", IsRequired = false, EmitDefaultValue = false)]
        public string DecoratedName { get; set; }

        /// <summary>
        /// Identifies the key of the immediate parent of the construct in which the result was detected. For example, this property might point to a logical location that represents the namespace that holds a type.
        /// </summary>
        [DataMember(Name = "parentKey", IsRequired = false, EmitDefaultValue = false)]
        public string ParentKey { get; set; }

        /// <summary>
        /// The type of construct this logicalLocationComponent refers to. Should be one of 'function', 'member', 'module', 'namespace', 'package', 'parameter', 'resource', 'returnType', 'type', or 'variable', if any of those accurately describe the construct.
        /// </summary>
        [DataMember(Name = "kind", IsRequired = false, EmitDefaultValue = false)]
        public string Kind { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogicalLocation" /> class.
        /// </summary>
        public LogicalLocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogicalLocation" /> class from the supplied values.
        /// </summary>
        /// <param name="name">
        /// An initialization value for the <see cref="P: Name" /> property.
        /// </param>
        /// <param name="fullyQualifiedName">
        /// An initialization value for the <see cref="P: FullyQualifiedName" /> property.
        /// </param>
        /// <param name="decoratedName">
        /// An initialization value for the <see cref="P: DecoratedName" /> property.
        /// </param>
        /// <param name="parentKey">
        /// An initialization value for the <see cref="P: ParentKey" /> property.
        /// </param>
        /// <param name="kind">
        /// An initialization value for the <see cref="P: Kind" /> property.
        /// </param>
        public LogicalLocation(string name, string fullyQualifiedName, string decoratedName, string parentKey, string kind)
        {
            Init(name, fullyQualifiedName, decoratedName, parentKey, kind);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogicalLocation" /> class from the specified instance.
        /// </summary>
        /// <param name="other">
        /// The instance from which the new instance is to be initialized.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="other" /> is null.
        /// </exception>
        public LogicalLocation(LogicalLocation other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            Init(other.Name, other.FullyQualifiedName, other.DecoratedName, other.ParentKey, other.Kind);
        }

        ISarifNode ISarifNode.DeepClone()
        {
            return DeepCloneCore();
        }

        /// <summary>
        /// Creates a deep copy of this instance.
        /// </summary>
        public LogicalLocation DeepClone()
        {
            return (LogicalLocation)DeepCloneCore();
        }

        private ISarifNode DeepCloneCore()
        {
            return new LogicalLocation(this);
        }

        private void Init(string name, string fullyQualifiedName, string decoratedName, string parentKey, string kind)
        {
            Name = name;
            FullyQualifiedName = fullyQualifiedName;
            DecoratedName = decoratedName;
            ParentKey = parentKey;
            Kind = kind;
        }
    }
}