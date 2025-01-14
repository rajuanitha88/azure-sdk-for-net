// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class IotSecuritySolutionsList
    {
        internal static IotSecuritySolutionsList DeserializeIotSecuritySolutionsList(JsonElement element)
        {
            IReadOnlyList<IotSecuritySolutionModelData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<IotSecuritySolutionModelData> array = new List<IotSecuritySolutionModelData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotSecuritySolutionModelData.DeserializeIotSecuritySolutionModelData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new IotSecuritySolutionsList(value, nextLink.Value);
        }
    }
}
