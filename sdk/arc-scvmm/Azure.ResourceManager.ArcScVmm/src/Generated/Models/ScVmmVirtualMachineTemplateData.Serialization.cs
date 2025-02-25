// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ArcScVmm
{
    public partial class ScVmmVirtualMachineTemplateData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("extendedLocation"u8);
            JsonSerializer.Serialize(writer, ExtendedLocation); if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(InventoryItemId))
            {
                writer.WritePropertyName("inventoryItemId"u8);
                writer.WriteStringValue(InventoryItemId);
            }
            if (Optional.IsDefined(Uuid))
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid);
            }
            if (Optional.IsDefined(VmmServerId))
            {
                writer.WritePropertyName("vmmServerId"u8);
                writer.WriteStringValue(VmmServerId);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ScVmmVirtualMachineTemplateData DeserializeScVmmVirtualMachineTemplateData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ExtendedLocation extendedLocation = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> inventoryItemId = default;
            Optional<string> uuid = default;
            Optional<string> vmmServerId = default;
            Optional<OSType> osType = default;
            Optional<string> osName = default;
            Optional<string> computerName = default;
            Optional<int> memoryMB = default;
            Optional<int> cpuCount = default;
            Optional<LimitCpuForMigration> limitCpuForMigration = default;
            Optional<DynamicMemoryEnabled> dynamicMemoryEnabled = default;
            Optional<IsCustomizable> isCustomizable = default;
            Optional<int> dynamicMemoryMaxMB = default;
            Optional<int> dynamicMemoryMinMB = default;
            Optional<string> isHighlyAvailable = default;
            Optional<int> generation = default;
            Optional<IReadOnlyList<NetworkInterfaces>> networkInterfaces = default;
            Optional<IReadOnlyList<VirtualDisk>> disks = default;
            Optional<string> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedLocation"u8))
                {
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("inventoryItemId"u8))
                        {
                            inventoryItemId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uuid"u8))
                        {
                            uuid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmmServerId"u8))
                        {
                            vmmServerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osType = new OSType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("osName"u8))
                        {
                            osName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("computerName"u8))
                        {
                            computerName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("memoryMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            memoryMB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("cpuCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            cpuCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("limitCpuForMigration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            limitCpuForMigration = new LimitCpuForMigration(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dynamicMemoryEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dynamicMemoryEnabled = new DynamicMemoryEnabled(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isCustomizable"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isCustomizable = new IsCustomizable(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dynamicMemoryMaxMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dynamicMemoryMaxMB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("dynamicMemoryMinMB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dynamicMemoryMinMB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isHighlyAvailable"u8))
                        {
                            isHighlyAvailable = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("generation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            generation = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("networkInterfaces"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkInterfaces> array = new List<NetworkInterfaces>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.NetworkInterfaces.DeserializeNetworkInterfaces(item));
                            }
                            networkInterfaces = array;
                            continue;
                        }
                        if (property0.NameEquals("disks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualDisk> array = new List<VirtualDisk>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualDisk.DeserializeVirtualDisk(item));
                            }
                            disks = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ScVmmVirtualMachineTemplateData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, extendedLocation, inventoryItemId.Value, uuid.Value, vmmServerId.Value, Optional.ToNullable(osType), osName.Value, computerName.Value, Optional.ToNullable(memoryMB), Optional.ToNullable(cpuCount), Optional.ToNullable(limitCpuForMigration), Optional.ToNullable(dynamicMemoryEnabled), Optional.ToNullable(isCustomizable), Optional.ToNullable(dynamicMemoryMaxMB), Optional.ToNullable(dynamicMemoryMinMB), isHighlyAvailable.Value, Optional.ToNullable(generation), Optional.ToList(networkInterfaces), Optional.ToList(disks), provisioningState.Value);
        }
    }
}
