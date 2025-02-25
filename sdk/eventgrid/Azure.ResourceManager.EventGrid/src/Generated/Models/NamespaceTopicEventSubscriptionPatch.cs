// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the Event Subscription update. </summary>
    public partial class NamespaceTopicEventSubscriptionPatch
    {
        /// <summary> Initializes a new instance of NamespaceTopicEventSubscriptionPatch. </summary>
        public NamespaceTopicEventSubscriptionPatch()
        {
        }

        /// <summary> Information about the delivery configuration of the event subscription. </summary>
        public DeliveryConfiguration DeliveryConfiguration { get; set; }
        /// <summary> The event delivery schema for the event subscription. </summary>
        public DeliverySchema? EventDeliverySchema { get; set; }
        /// <summary> Information about the filter for the event subscription. </summary>
        public FiltersConfiguration FiltersConfiguration { get; set; }
    }
}
