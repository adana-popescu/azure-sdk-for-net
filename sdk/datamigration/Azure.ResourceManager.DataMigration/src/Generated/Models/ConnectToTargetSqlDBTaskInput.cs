// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Input for the task that validates connection to SQL DB and target server requirements. </summary>
    public partial class ConnectToTargetSqlDBTaskInput
    {
        /// <summary> Initializes a new instance of ConnectToTargetSqlDBTaskInput. </summary>
        /// <param name="targetConnectionInfo"> Connection information for target SQL DB. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetConnectionInfo"/> is null. </exception>
        public ConnectToTargetSqlDBTaskInput(SqlConnectionInfo targetConnectionInfo)
        {
            Argument.AssertNotNull(targetConnectionInfo, nameof(targetConnectionInfo));

            TargetConnectionInfo = targetConnectionInfo;
        }

        /// <summary> Initializes a new instance of ConnectToTargetSqlDBTaskInput. </summary>
        /// <param name="targetConnectionInfo"> Connection information for target SQL DB. </param>
        /// <param name="queryObjectCounts"> Boolean flag indicating whether to query object counts for each database on the target server. </param>
        internal ConnectToTargetSqlDBTaskInput(SqlConnectionInfo targetConnectionInfo, bool? queryObjectCounts)
        {
            TargetConnectionInfo = targetConnectionInfo;
            QueryObjectCounts = queryObjectCounts;
        }

        /// <summary> Connection information for target SQL DB. </summary>
        public SqlConnectionInfo TargetConnectionInfo { get; set; }
        /// <summary> Boolean flag indicating whether to query object counts for each database on the target server. </summary>
        public bool? QueryObjectCounts { get; set; }
    }
}
