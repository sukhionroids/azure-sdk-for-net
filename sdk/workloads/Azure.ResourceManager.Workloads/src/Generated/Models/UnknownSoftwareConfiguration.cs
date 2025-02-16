// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The UnknownSoftwareConfiguration. </summary>
    internal partial class UnknownSoftwareConfiguration : SapSoftwareConfiguration
    {
        /// <summary> Initializes a new instance of UnknownSoftwareConfiguration. </summary>
        /// <param name="softwareInstallationType"> The SAP software installation Type. </param>
        internal UnknownSoftwareConfiguration(SapSoftwareInstallationType softwareInstallationType) : base(softwareInstallationType)
        {
            SoftwareInstallationType = softwareInstallationType;
        }
    }
}
