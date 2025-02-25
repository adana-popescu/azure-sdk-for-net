// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> A list of firewall rules. </summary>
    internal partial class FirewallRuleListResult
    {
        /// <summary> Initializes a new instance of FirewallRuleListResult. </summary>
        internal FirewallRuleListResult()
        {
            Value = new ChangeTrackingList<CosmosDBFirewallRuleData>();
        }

        /// <summary> Initializes a new instance of FirewallRuleListResult. </summary>
        /// <param name="value"> The list of firewall rules in a mongo cluster. </param>
        /// <param name="nextLink"> The link used to get the next page of results. </param>
        internal FirewallRuleListResult(IReadOnlyList<CosmosDBFirewallRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of firewall rules in a mongo cluster. </summary>
        public IReadOnlyList<CosmosDBFirewallRuleData> Value { get; }
        /// <summary> The link used to get the next page of results. </summary>
        public string NextLink { get; }
    }
}
