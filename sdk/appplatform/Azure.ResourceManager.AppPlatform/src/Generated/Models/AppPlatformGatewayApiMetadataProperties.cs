// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> API metadata property for Spring Cloud Gateway. </summary>
    public partial class AppPlatformGatewayApiMetadataProperties
    {
        /// <summary> Initializes a new instance of AppPlatformGatewayApiMetadataProperties. </summary>
        public AppPlatformGatewayApiMetadataProperties()
        {
        }

        /// <summary> Initializes a new instance of AppPlatformGatewayApiMetadataProperties. </summary>
        /// <param name="title"> Title describing the context of the APIs available on the Gateway instance (default: `Spring Cloud Gateway for K8S`). </param>
        /// <param name="description"> Detailed description of the APIs available on the Gateway instance (default: `Generated OpenAPI 3 document that describes the API routes configured.`). </param>
        /// <param name="documentation"> Location of additional documentation for the APIs available on the Gateway instance. </param>
        /// <param name="version"> Version of APIs available on this Gateway instance (default: `unspecified`). </param>
        /// <param name="serverUri"> Base URL that API consumers will use to access APIs on the Gateway instance. </param>
        internal AppPlatformGatewayApiMetadataProperties(string title, string description, string documentation, string version, Uri serverUri)
        {
            Title = title;
            Description = description;
            Documentation = documentation;
            Version = version;
            ServerUri = serverUri;
        }

        /// <summary> Title describing the context of the APIs available on the Gateway instance (default: `Spring Cloud Gateway for K8S`). </summary>
        public string Title { get; set; }
        /// <summary> Detailed description of the APIs available on the Gateway instance (default: `Generated OpenAPI 3 document that describes the API routes configured.`). </summary>
        public string Description { get; set; }
        /// <summary> Location of additional documentation for the APIs available on the Gateway instance. </summary>
        public string Documentation { get; set; }
        /// <summary> Version of APIs available on this Gateway instance (default: `unspecified`). </summary>
        public string Version { get; set; }
        /// <summary> Base URL that API consumers will use to access APIs on the Gateway instance. </summary>
        public Uri ServerUri { get; set; }
    }
}
