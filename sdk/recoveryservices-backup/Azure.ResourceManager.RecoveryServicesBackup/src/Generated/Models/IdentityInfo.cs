// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Encapsulates Managed Identity related information. </summary>
    public partial class IdentityInfo
    {
        /// <summary> Initializes a new instance of IdentityInfo. </summary>
        public IdentityInfo()
        {
        }

        /// <summary> Initializes a new instance of IdentityInfo. </summary>
        /// <param name="isSystemAssignedIdentity"> To differentiate if the managed identity is system assigned or user assigned. </param>
        /// <param name="managedIdentityResourceId">
        /// Managed Identity Resource Id
        /// Optional: Might not be required in the case of system assigned managed identity
        /// </param>
        internal IdentityInfo(bool? isSystemAssignedIdentity, string managedIdentityResourceId)
        {
            IsSystemAssignedIdentity = isSystemAssignedIdentity;
            ManagedIdentityResourceId = managedIdentityResourceId;
        }

        /// <summary> To differentiate if the managed identity is system assigned or user assigned. </summary>
        public bool? IsSystemAssignedIdentity { get; set; }
        /// <summary>
        /// Managed Identity Resource Id
        /// Optional: Might not be required in the case of system assigned managed identity
        /// </summary>
        public string ManagedIdentityResourceId { get; set; }
    }
}
