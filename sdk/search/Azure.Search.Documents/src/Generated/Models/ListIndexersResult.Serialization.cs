// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    internal partial class ListIndexersResult
    {
        internal static ListIndexersResult DeserializeListIndexersResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SearchIndexer> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SearchIndexer> array = new List<SearchIndexer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchIndexer.DeserializeSearchIndexer(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ListIndexersResult(value);
        }
    }
}
