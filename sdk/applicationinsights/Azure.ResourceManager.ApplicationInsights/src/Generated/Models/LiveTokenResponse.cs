// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> The response to a live token query. </summary>
    public partial class LiveTokenResponse
    {
        /// <summary> Initializes a new instance of LiveTokenResponse. </summary>
        internal LiveTokenResponse()
        {
        }

        /// <summary> Initializes a new instance of LiveTokenResponse. </summary>
        /// <param name="liveToken"> JWT token for accessing live metrics stream data. </param>
        internal LiveTokenResponse(string liveToken)
        {
            LiveToken = liveToken;
        }

        /// <summary> JWT token for accessing live metrics stream data. </summary>
        public string LiveToken { get; }
    }
}
