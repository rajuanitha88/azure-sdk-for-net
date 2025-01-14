// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class HostNameSslState : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(SslState))
            {
                writer.WritePropertyName("sslState");
                writer.WriteStringValue(SslState.Value.ToSerialString());
            }
            if (Optional.IsDefined(VirtualIP))
            {
                writer.WritePropertyName("virtualIP");
                writer.WriteStringValue(VirtualIP);
            }
            if (Optional.IsDefined(Thumbprint))
            {
                writer.WritePropertyName("thumbprint");
                writer.WriteStringValue(Thumbprint);
            }
            if (Optional.IsDefined(IsToUpdate))
            {
                if (IsToUpdate != null)
                {
                    writer.WritePropertyName("toUpdate");
                    writer.WriteBooleanValue(IsToUpdate.Value);
                }
                else
                {
                    writer.WriteNull("toUpdate");
                }
            }
            if (Optional.IsDefined(HostType))
            {
                writer.WritePropertyName("hostType");
                writer.WriteStringValue(HostType.Value.ToSerialString());
            }
            writer.WriteEndObject();
        }

        internal static HostNameSslState DeserializeHostNameSslState(JsonElement element)
        {
            Optional<string> name = default;
            Optional<SslState> sslState = default;
            Optional<string> virtualIP = default;
            Optional<string> thumbprint = default;
            Optional<bool?> toUpdate = default;
            Optional<HostType> hostType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sslState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sslState = property.Value.GetString().ToSslState();
                    continue;
                }
                if (property.NameEquals("virtualIP"))
                {
                    virtualIP = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("toUpdate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        toUpdate = null;
                        continue;
                    }
                    toUpdate = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hostType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    hostType = property.Value.GetString().ToHostType();
                    continue;
                }
            }
            return new HostNameSslState(name.Value, Optional.ToNullable(sslState), virtualIP.Value, thumbprint.Value, Optional.ToNullable(toUpdate), Optional.ToNullable(hostType));
        }
    }
}
