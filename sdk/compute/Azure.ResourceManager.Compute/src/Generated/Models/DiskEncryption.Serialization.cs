// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DiskEncryption : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DiskEncryptionSetId))
            {
                writer.WritePropertyName("diskEncryptionSetId");
                writer.WriteStringValue(DiskEncryptionSetId);
            }
            if (Optional.IsDefined(EncryptionType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(EncryptionType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static DiskEncryption DeserializeDiskEncryption(JsonElement element)
        {
            Optional<ResourceIdentifier> diskEncryptionSetId = default;
            Optional<EncryptionType> type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskEncryptionSetId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    diskEncryptionSetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    type = new EncryptionType(property.Value.GetString());
                    continue;
                }
            }
            return new DiskEncryption(diskEncryptionSetId.Value, Optional.ToNullable(type));
        }
    }
}
