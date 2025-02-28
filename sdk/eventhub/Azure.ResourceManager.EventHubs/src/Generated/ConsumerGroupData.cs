// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing the ConsumerGroup data model. </summary>
    public partial class ConsumerGroupData : ResourceData
    {
        /// <summary> Initializes a new instance of ConsumerGroupData. </summary>
        public ConsumerGroupData()
        {
        }

        /// <summary> Initializes a new instance of ConsumerGroupData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="createdOn"> Exact time the message was created. </param>
        /// <param name="updatedOn"> The exact time the message was updated. </param>
        /// <param name="userMetadata"> User Metadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal ConsumerGroupData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, string userMetadata, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            UserMetadata = userMetadata;
            Location = location;
        }

        /// <summary> Exact time the message was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The exact time the message was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; }
        /// <summary> User Metadata is a placeholder to store user-defined string data with maximum length 1024. e.g. it can be used to store descriptive data, such as list of teams and their contact information also user-defined configuration settings can be stored. </summary>
        public string UserMetadata { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
