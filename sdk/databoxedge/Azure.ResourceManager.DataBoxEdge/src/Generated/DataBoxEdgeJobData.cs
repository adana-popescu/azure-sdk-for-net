// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the DataBoxEdgeJob data model.
    /// A device job.
    /// </summary>
    public partial class DataBoxEdgeJobData : ResourceData
    {
        /// <summary> Initializes a new instance of DataBoxEdgeJobData. </summary>
        internal DataBoxEdgeJobData()
        {
        }

        /// <summary> Initializes a new instance of DataBoxEdgeJobData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="status"> The current status of the job. </param>
        /// <param name="startOn"> The UTC date and time at which the job started. </param>
        /// <param name="endOn"> The UTC date and time at which the job completed. </param>
        /// <param name="percentComplete"> The percentage of the job that is complete. </param>
        /// <param name="error"> The error details. </param>
        /// <param name="jobType"> The type of the job. </param>
        /// <param name="currentStage"> Current stage of the update operation. </param>
        /// <param name="downloadProgress"> The download progress. </param>
        /// <param name="installProgress"> The install progress. </param>
        /// <param name="totalRefreshErrors"> Total number of errors encountered during the refresh process. </param>
        /// <param name="errorManifestFile"> Local share/remote container relative path to the error manifest file of the refresh. </param>
        /// <param name="refreshedEntityId"> ARM ID of the entity that was refreshed. </param>
        /// <param name="folder"> If only subfolders need to be refreshed, then the subfolder path inside the share or container. (The path is empty if there are no subfolders.). </param>
        internal DataBoxEdgeJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DataBoxEdgeJobStatus? status, DateTimeOffset? startOn, DateTimeOffset? endOn, int? percentComplete, DataBoxEdgeJobErrorDetails error, DataBoxEdgeJobType? jobType, UpdateOperationStage? currentStage, UpdateDownloadProgress downloadProgress, UpdateInstallProgress installProgress, int? totalRefreshErrors, string errorManifestFile, ResourceIdentifier refreshedEntityId, string folder) : base(id, name, resourceType, systemData)
        {
            Status = status;
            StartOn = startOn;
            EndOn = endOn;
            PercentComplete = percentComplete;
            Error = error;
            JobType = jobType;
            CurrentStage = currentStage;
            DownloadProgress = downloadProgress;
            InstallProgress = installProgress;
            TotalRefreshErrors = totalRefreshErrors;
            ErrorManifestFile = errorManifestFile;
            RefreshedEntityId = refreshedEntityId;
            Folder = folder;
        }

        /// <summary> The current status of the job. </summary>
        public DataBoxEdgeJobStatus? Status { get; }
        /// <summary> The UTC date and time at which the job started. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The UTC date and time at which the job completed. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The percentage of the job that is complete. </summary>
        public int? PercentComplete { get; }
        /// <summary> The error details. </summary>
        public DataBoxEdgeJobErrorDetails Error { get; }
        /// <summary> The type of the job. </summary>
        public DataBoxEdgeJobType? JobType { get; }
        /// <summary> Current stage of the update operation. </summary>
        public UpdateOperationStage? CurrentStage { get; }
        /// <summary> The download progress. </summary>
        public UpdateDownloadProgress DownloadProgress { get; }
        /// <summary> The install progress. </summary>
        public UpdateInstallProgress InstallProgress { get; }
        /// <summary> Total number of errors encountered during the refresh process. </summary>
        public int? TotalRefreshErrors { get; }
        /// <summary> Local share/remote container relative path to the error manifest file of the refresh. </summary>
        public string ErrorManifestFile { get; }
        /// <summary> ARM ID of the entity that was refreshed. </summary>
        public ResourceIdentifier RefreshedEntityId { get; }
        /// <summary> If only subfolders need to be refreshed, then the subfolder path inside the share or container. (The path is empty if there are no subfolders.). </summary>
        public string Folder { get; }
    }
}
