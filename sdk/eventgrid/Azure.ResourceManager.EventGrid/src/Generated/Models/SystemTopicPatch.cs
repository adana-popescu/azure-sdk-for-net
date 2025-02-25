// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the System Topic update. </summary>
    public partial class SystemTopicPatch
    {
        /// <summary> Initializes a new instance of SystemTopicPatch. </summary>
        public SystemTopicPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Tags of the system topic. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Resource identity information. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
