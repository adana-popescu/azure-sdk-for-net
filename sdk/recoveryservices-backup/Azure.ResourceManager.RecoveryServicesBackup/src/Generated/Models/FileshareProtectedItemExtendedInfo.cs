// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Additional information about Azure File Share backup item. </summary>
    public partial class FileshareProtectedItemExtendedInfo
    {
        /// <summary> Initializes a new instance of FileshareProtectedItemExtendedInfo. </summary>
        public FileshareProtectedItemExtendedInfo()
        {
        }

        /// <summary> Initializes a new instance of FileshareProtectedItemExtendedInfo. </summary>
        /// <param name="oldestRecoverOn"> The oldest backup copy available for this item in the service. </param>
        /// <param name="recoveryPointCount"> Number of available backup copies associated with this backup item. </param>
        /// <param name="policyState"> Indicates consistency of policy object and policy applied to this backup item. </param>
        /// <param name="resourceState"> Indicates the state of this resource. Possible values are from enum ResourceState {Invalid, Active, SoftDeleted, Deleted}. </param>
        /// <param name="resourceStateSyncOn"> The resource state sync time for this backup item. </param>
        internal FileshareProtectedItemExtendedInfo(DateTimeOffset? oldestRecoverOn, int? recoveryPointCount, string policyState, string resourceState, DateTimeOffset? resourceStateSyncOn)
        {
            OldestRecoverOn = oldestRecoverOn;
            RecoveryPointCount = recoveryPointCount;
            PolicyState = policyState;
            ResourceState = resourceState;
            ResourceStateSyncOn = resourceStateSyncOn;
        }

        /// <summary> The oldest backup copy available for this item in the service. </summary>
        public DateTimeOffset? OldestRecoverOn { get; set; }
        /// <summary> Number of available backup copies associated with this backup item. </summary>
        public int? RecoveryPointCount { get; set; }
        /// <summary> Indicates consistency of policy object and policy applied to this backup item. </summary>
        public string PolicyState { get; set; }
        /// <summary> Indicates the state of this resource. Possible values are from enum ResourceState {Invalid, Active, SoftDeleted, Deleted}. </summary>
        public string ResourceState { get; }
        /// <summary> The resource state sync time for this backup item. </summary>
        public DateTimeOffset? ResourceStateSyncOn { get; }
    }
}
