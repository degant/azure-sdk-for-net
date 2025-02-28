// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceUsage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AppServiceUsage DeserializeAppServiceUsage(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<string> resourceName = default;
            Optional<string> unit = default;
            Optional<long> currentValue = default;
            Optional<long> limit = default;
            Optional<DateTimeOffset> nextResetTime = default;
            Optional<ComputeModeOptions> computeMode = default;
            Optional<string> siteMode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceName"))
                        {
                            resourceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("unit"))
                        {
                            unit = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentValue"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            currentValue = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("limit"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            limit = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("nextResetTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            nextResetTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("computeMode"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            computeMode = property0.Value.GetString().ToComputeModeOptions();
                            continue;
                        }
                        if (property0.NameEquals("siteMode"))
                        {
                            siteMode = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AppServiceUsage(id, name, type, systemData.Value, displayName.Value, resourceName.Value, unit.Value, Optional.ToNullable(currentValue), Optional.ToNullable(limit), Optional.ToNullable(nextResetTime), Optional.ToNullable(computeMode), siteMode.Value, kind.Value);
        }
    }
}
