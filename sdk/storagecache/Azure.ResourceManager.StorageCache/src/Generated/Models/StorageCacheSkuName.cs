// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> SKU for the resource. </summary>
    internal partial class StorageCacheSkuName
    {
        /// <summary> Initializes a new instance of StorageCacheSkuName. </summary>
        public StorageCacheSkuName()
        {
        }

        /// <summary> Initializes a new instance of StorageCacheSkuName. </summary>
        /// <param name="name"> SKU name for this resource. </param>
        internal StorageCacheSkuName(string name)
        {
            Name = name;
        }

        /// <summary> SKU name for this resource. </summary>
        public string Name { get; set; }
    }
}
