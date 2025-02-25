// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The storage account key regenerate parameters. </summary>
    internal partial class StorageAccountRegenerteKeyParameters
    {
        /// <summary> Initializes a new instance of StorageAccountRegenerteKeyParameters. </summary>
        /// <param name="keyName"> The storage account key name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyName"/> is null. </exception>
        public StorageAccountRegenerteKeyParameters(string keyName)
        {
            Argument.AssertNotNull(keyName, nameof(keyName));

            KeyName = keyName;
        }

        /// <summary> The storage account key name. </summary>
        public string KeyName { get; }
    }
}
