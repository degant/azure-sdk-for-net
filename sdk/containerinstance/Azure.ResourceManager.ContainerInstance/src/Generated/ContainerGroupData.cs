// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ContainerInstance.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ContainerInstance
{
    /// <summary> A class representing the ContainerGroup data model. </summary>
    public partial class ContainerGroupData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ContainerGroupData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="containers"> The containers within the container group. </param>
        /// <param name="osType"> The operating system type required by the containers in the container group. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="containers"/> is null. </exception>
        public ContainerGroupData(AzureLocation location, IEnumerable<ContainerInstanceContainer> containers, OperatingSystemTypes osType) : base(location)
        {
            if (containers == null)
            {
                throw new ArgumentNullException(nameof(containers));
            }

            Containers = containers.ToList();
            ImageRegistryCredentials = new ChangeTrackingList<ImageRegistryCredential>();
            OSType = osType;
            Volumes = new ChangeTrackingList<ContainerInstanceVolume>();
            SubnetIds = new ChangeTrackingList<ContainerGroupSubnetId>();
            InitContainers = new ChangeTrackingList<InitContainerDefinitionContent>();
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ContainerGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the container group, if configured. </param>
        /// <param name="provisioningState"> The provisioning state of the container group. This only appears in the response. </param>
        /// <param name="containers"> The containers within the container group. </param>
        /// <param name="imageRegistryCredentials"> The image registry credentials by which the container group is created from. </param>
        /// <param name="restartPolicy">
        /// Restart policy for all containers within the container group. 
        /// - `Always` Always restart
        /// - `OnFailure` Restart on failure
        /// - `Never` Never restart
        /// 
        /// </param>
        /// <param name="ipAddress"> The IP address type of the container group. </param>
        /// <param name="osType"> The operating system type required by the containers in the container group. </param>
        /// <param name="volumes"> The list of volumes that can be mounted by containers in this container group. </param>
        /// <param name="instanceView"> The instance view of the container group. Only valid in response. </param>
        /// <param name="diagnostics"> The diagnostic information for a container group. </param>
        /// <param name="subnetIds"> The subnet resource IDs for a container group. </param>
        /// <param name="dnsConfig"> The DNS config information for a container group. </param>
        /// <param name="sku"> The SKU for a container group. </param>
        /// <param name="encryptionProperties"> The encryption properties for a container group. </param>
        /// <param name="initContainers"> The init containers for a container group. </param>
        /// <param name="zones"> The zones for the container group. </param>
        internal ContainerGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string provisioningState, IList<ContainerInstanceContainer> containers, IList<ImageRegistryCredential> imageRegistryCredentials, ContainerGroupRestartPolicy? restartPolicy, IPAddress ipAddress, OperatingSystemTypes osType, IList<ContainerInstanceVolume> volumes, ContainerGroupPropertiesInstanceView instanceView, ContainerGroupDiagnostics diagnostics, IList<ContainerGroupSubnetId> subnetIds, DnsConfiguration dnsConfig, ContainerGroupSku? sku, Models.EncryptionProperties encryptionProperties, IList<InitContainerDefinitionContent> initContainers, IList<string> zones) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            ProvisioningState = provisioningState;
            Containers = containers;
            ImageRegistryCredentials = imageRegistryCredentials;
            RestartPolicy = restartPolicy;
            IPAddress = ipAddress;
            OSType = osType;
            Volumes = volumes;
            InstanceView = instanceView;
            Diagnostics = diagnostics;
            SubnetIds = subnetIds;
            DnsConfig = dnsConfig;
            Sku = sku;
            EncryptionProperties = encryptionProperties;
            InitContainers = initContainers;
            Zones = zones;
        }

        /// <summary> The identity of the container group, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The provisioning state of the container group. This only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The containers within the container group. </summary>
        public IList<ContainerInstanceContainer> Containers { get; }
        /// <summary> The image registry credentials by which the container group is created from. </summary>
        public IList<ImageRegistryCredential> ImageRegistryCredentials { get; }
        /// <summary>
        /// Restart policy for all containers within the container group. 
        /// - `Always` Always restart
        /// - `OnFailure` Restart on failure
        /// - `Never` Never restart
        /// 
        /// </summary>
        public ContainerGroupRestartPolicy? RestartPolicy { get; set; }
        /// <summary> The IP address type of the container group. </summary>
        public IPAddress IPAddress { get; set; }
        /// <summary> The operating system type required by the containers in the container group. </summary>
        public OperatingSystemTypes OSType { get; set; }
        /// <summary> The list of volumes that can be mounted by containers in this container group. </summary>
        public IList<ContainerInstanceVolume> Volumes { get; }
        /// <summary> The instance view of the container group. Only valid in response. </summary>
        public ContainerGroupPropertiesInstanceView InstanceView { get; }
        /// <summary> The diagnostic information for a container group. </summary>
        internal ContainerGroupDiagnostics Diagnostics { get; set; }
        /// <summary> Container group log analytics information. </summary>
        public LogAnalytics DiagnosticsLogAnalytics
        {
            get => Diagnostics is null ? default : Diagnostics.LogAnalytics;
            set
            {
                if (Diagnostics is null)
                    Diagnostics = new ContainerGroupDiagnostics();
                Diagnostics.LogAnalytics = value;
            }
        }

        /// <summary> The subnet resource IDs for a container group. </summary>
        public IList<ContainerGroupSubnetId> SubnetIds { get; }
        /// <summary> The DNS config information for a container group. </summary>
        public DnsConfiguration DnsConfig { get; set; }
        /// <summary> The SKU for a container group. </summary>
        public ContainerGroupSku? Sku { get; set; }
        /// <summary> The encryption properties for a container group. </summary>
        public Models.EncryptionProperties EncryptionProperties { get; set; }
        /// <summary> The init containers for a container group. </summary>
        public IList<InitContainerDefinitionContent> InitContainers { get; }
        /// <summary> The zones for the container group. </summary>
        public IList<string> Zones { get; }
    }
}
