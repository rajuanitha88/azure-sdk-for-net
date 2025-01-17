// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    /// <summary> A class representing the VirtualNetwork data model. </summary>
    public partial class VirtualNetworkData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualNetworkData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualNetworkData(AzureLocation location) : base(location)
        {
            AllowedSubnets = new ChangeTrackingList<Subnet>();
            ExternalSubnets = new ChangeTrackingList<ExternalSubnet>();
            SubnetOverrides = new ChangeTrackingList<SubnetOverride>();
        }

        /// <summary> Initializes a new instance of VirtualNetworkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="allowedSubnets"> The allowed subnets of the virtual network. </param>
        /// <param name="description"> The description of the virtual network. </param>
        /// <param name="externalProviderResourceId"> The Microsoft.Network resource identifier of the virtual network. </param>
        /// <param name="externalSubnets"> The external subnet properties. </param>
        /// <param name="subnetOverrides"> The subnet overrides of the virtual network. </param>
        /// <param name="createdOn"> The creation date of the virtual network. </param>
        /// <param name="provisioningState"> The provisioning status of the resource. </param>
        /// <param name="uniqueIdentifier"> The unique immutable identifier of a resource (Guid). </param>
        internal VirtualNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, IList<Subnet> allowedSubnets, string description, string externalProviderResourceId, IReadOnlyList<ExternalSubnet> externalSubnets, IList<SubnetOverride> subnetOverrides, DateTimeOffset? createdOn, string provisioningState, string uniqueIdentifier) : base(id, name, resourceType, systemData, tags, location)
        {
            AllowedSubnets = allowedSubnets;
            Description = description;
            ExternalProviderResourceId = externalProviderResourceId;
            ExternalSubnets = externalSubnets;
            SubnetOverrides = subnetOverrides;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
        }

        /// <summary> The allowed subnets of the virtual network. </summary>
        public IList<Subnet> AllowedSubnets { get; }
        /// <summary> The description of the virtual network. </summary>
        public string Description { get; set; }
        /// <summary> The Microsoft.Network resource identifier of the virtual network. </summary>
        public string ExternalProviderResourceId { get; set; }
        /// <summary> The external subnet properties. </summary>
        public IReadOnlyList<ExternalSubnet> ExternalSubnets { get; }
        /// <summary> The subnet overrides of the virtual network. </summary>
        public IList<SubnetOverride> SubnetOverrides { get; }
        /// <summary> The creation date of the virtual network. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The provisioning status of the resource. </summary>
        public string ProvisioningState { get; }
        /// <summary> The unique immutable identifier of a resource (Guid). </summary>
        public string UniqueIdentifier { get; }
    }
}
