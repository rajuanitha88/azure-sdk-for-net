// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class WorkspacePurgeResponse
    {
        internal static WorkspacePurgeResponse DeserializeWorkspacePurgeResponse(JsonElement element)
        {
            string operationId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
            }
            return new WorkspacePurgeResponse(operationId);
        }
    }
}
