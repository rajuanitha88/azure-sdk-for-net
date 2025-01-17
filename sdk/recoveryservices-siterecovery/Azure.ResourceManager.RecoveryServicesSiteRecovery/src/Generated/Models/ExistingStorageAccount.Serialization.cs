// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class ExistingStorageAccount : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("azureStorageAccountId");
            writer.WriteStringValue(AzureStorageAccountId);
            writer.WritePropertyName("resourceType");
            writer.WriteStringValue(ResourceType);
            writer.WriteEndObject();
        }

        internal static ExistingStorageAccount DeserializeExistingStorageAccount(JsonElement element)
        {
            string azureStorageAccountId = default;
            string resourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureStorageAccountId"))
                {
                    azureStorageAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
            }
            return new ExistingStorageAccount(resourceType, azureStorageAccountId);
        }
    }
}
