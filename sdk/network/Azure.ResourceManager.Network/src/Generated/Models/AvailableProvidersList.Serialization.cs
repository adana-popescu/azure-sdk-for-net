// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class AvailableProvidersList
    {
        internal static AvailableProvidersList DeserializeAvailableProvidersList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AvailableProvidersListCountry> countries = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("countries"u8))
                {
                    List<AvailableProvidersListCountry> array = new List<AvailableProvidersListCountry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AvailableProvidersListCountry.DeserializeAvailableProvidersListCountry(item));
                    }
                    countries = array;
                    continue;
                }
            }
            return new AvailableProvidersList(countries);
        }
    }
}
