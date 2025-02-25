// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> The range of time. Cannot be null or negative. </summary>
    internal partial class DateTimeRange
    {
        /// <summary> Initializes a new instance of DateTimeRange. </summary>
        /// <param name="from"> Start timestamp of the time range. Start timestamp is inclusive when used in time series query requests. Events that have this timestamp are included. </param>
        /// <param name="to"> End timestamp of the time range. End timestamp is exclusive when used in time series query requests. Events that match this timestamp are excluded. Note that end timestamp is inclusive when returned by Get Availability (meaning that there is an event with this exact "to" timestamp). </param>
        public DateTimeRange(DateTimeOffset @from, DateTimeOffset to)
        {
            From = @from;
            To = to;
        }

        /// <summary> Start timestamp of the time range. Start timestamp is inclusive when used in time series query requests. Events that have this timestamp are included. </summary>
        public DateTimeOffset From { get; set; }
        /// <summary> End timestamp of the time range. End timestamp is exclusive when used in time series query requests. Events that match this timestamp are excluded. Note that end timestamp is inclusive when returned by Get Availability (meaning that there is an event with this exact "to" timestamp). </summary>
        public DateTimeOffset To { get; set; }
    }
}
