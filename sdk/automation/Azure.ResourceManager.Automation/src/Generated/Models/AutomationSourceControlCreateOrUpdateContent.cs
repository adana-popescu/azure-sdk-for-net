// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update source control operation. </summary>
    public partial class AutomationSourceControlCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of AutomationSourceControlCreateOrUpdateContent. </summary>
        public AutomationSourceControlCreateOrUpdateContent()
        {
        }

        /// <summary> The repo url of the source control. </summary>
        public Uri RepoUri { get; set; }
        /// <summary> The repo branch of the source control. Include branch as empty string for VsoTfvc. </summary>
        public string Branch { get; set; }
        /// <summary> The folder path of the source control. Path must be relative. </summary>
        public string FolderPath { get; set; }
        /// <summary> The auto async of the source control. Default is false. </summary>
        public bool? IsAutoSyncEnabled { get; set; }
        /// <summary> The auto publish of the source control. Default is true. </summary>
        public bool? IsAutoPublishRunbookEnabled { get; set; }
        /// <summary> The source type. Must be one of VsoGit, VsoTfvc, GitHub, case sensitive. </summary>
        public SourceControlSourceType? SourceType { get; set; }
        /// <summary> The authorization token for the repo of the source control. </summary>
        public SourceControlSecurityTokenProperties SecurityToken { get; set; }
        /// <summary> The user description of the source control. </summary>
        public string Description { get; set; }
    }
}
