// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing the EventHub data model. </summary>
    public partial class EventHubData : ResourceData
    {
        /// <summary> Initializes a new instance of EventHubData. </summary>
        public EventHubData()
        {
            PartitionIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of EventHubData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="partitionIds"> Current number of shards on the Event Hub. </param>
        /// <param name="createdOn"> Exact time the Event Hub was created. </param>
        /// <param name="updatedOn"> The exact time the message was updated. </param>
        /// <param name="messageRetentionInDays"> Number of days to retain the events for this Event Hub, value should be 1 to 7 days. </param>
        /// <param name="partitionCount"> Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions. </param>
        /// <param name="status"> Enumerates the possible values for the status of the Event Hub. </param>
        /// <param name="captureDescription"> Properties of capture description. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal EventHubData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IReadOnlyList<string> partitionIds, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, long? messageRetentionInDays, long? partitionCount, EntityStatus? status, CaptureDescription captureDescription, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            PartitionIds = partitionIds;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            MessageRetentionInDays = messageRetentionInDays;
            PartitionCount = partitionCount;
            Status = status;
            CaptureDescription = captureDescription;
            Location = location;
        }

        /// <summary> Current number of shards on the Event Hub. </summary>
        public IReadOnlyList<string> PartitionIds { get; }
        /// <summary> Exact time the Event Hub was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The exact time the message was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> Number of days to retain the events for this Event Hub, value should be 1 to 7 days. </summary>
        public long? MessageRetentionInDays { get; set; }
        /// <summary> Number of partitions created for the Event Hub, allowed values are from 1 to 32 partitions. </summary>
        public long? PartitionCount { get; set; }
        /// <summary> Enumerates the possible values for the status of the Event Hub. </summary>
        public EntityStatus? Status { get; set; }
        /// <summary> Properties of capture description. </summary>
        public CaptureDescription CaptureDescription { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
