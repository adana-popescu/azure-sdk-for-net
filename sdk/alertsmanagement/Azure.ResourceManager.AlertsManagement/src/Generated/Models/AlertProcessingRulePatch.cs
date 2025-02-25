// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Data contract for patch. </summary>
    public partial class AlertProcessingRulePatch
    {
        /// <summary> Initializes a new instance of AlertProcessingRulePatch. </summary>
        public AlertProcessingRulePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Tags to be updated. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Indicates if the given alert processing rule is enabled or disabled. </summary>
        public bool? IsEnabled { get; set; }
    }
}
