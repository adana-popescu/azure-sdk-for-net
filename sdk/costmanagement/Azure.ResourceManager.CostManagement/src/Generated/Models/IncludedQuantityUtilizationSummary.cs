// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> Included Quantity utilization summary resource. </summary>
    public partial class IncludedQuantityUtilizationSummary : BenefitUtilizationSummary
    {
        /// <summary> Initializes a new instance of IncludedQuantityUtilizationSummary. </summary>
        public IncludedQuantityUtilizationSummary()
        {
            Kind = BillingAccountBenefitKind.IncludedQuantity;
        }

        /// <summary> Initializes a new instance of IncludedQuantityUtilizationSummary. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Supported values: 'SavingsPlan'. </param>
        /// <param name="armSkuName"> ARM SKU name. For example, 'Compute_Savings_Plan' for savings plan. </param>
        /// <param name="benefitId"> The benefit ID is the identifier of the benefit. </param>
        /// <param name="benefitOrderId"> The benefit order ID is the identifier for a benefit purchase. </param>
        /// <param name="benefitType"> The benefit type. Supported values: 'SavingsPlan'. </param>
        /// <param name="usageOn"> Date corresponding to the utilization summary record. If the grain of data is monthly, value for this field will be first day of the month. </param>
        /// <param name="utilizationPercentage"> This is the utilized percentage for the benefit ID. </param>
        internal IncludedQuantityUtilizationSummary(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, BillingAccountBenefitKind kind, string armSkuName, string benefitId, string benefitOrderId, BillingAccountBenefitKind? benefitType, DateTimeOffset? usageOn, decimal? utilizationPercentage) : base(id, name, resourceType, systemData, kind)
        {
            ArmSkuName = armSkuName;
            BenefitId = benefitId;
            BenefitOrderId = benefitOrderId;
            BenefitType = benefitType;
            UsageOn = usageOn;
            UtilizationPercentage = utilizationPercentage;
            Kind = kind;
        }

        /// <summary> ARM SKU name. For example, 'Compute_Savings_Plan' for savings plan. </summary>
        public string ArmSkuName { get; }
        /// <summary> The benefit ID is the identifier of the benefit. </summary>
        public string BenefitId { get; }
        /// <summary> The benefit order ID is the identifier for a benefit purchase. </summary>
        public string BenefitOrderId { get; }
        /// <summary> The benefit type. Supported values: 'SavingsPlan'. </summary>
        public BillingAccountBenefitKind? BenefitType { get; set; }
        /// <summary> Date corresponding to the utilization summary record. If the grain of data is monthly, value for this field will be first day of the month. </summary>
        public DateTimeOffset? UsageOn { get; }
        /// <summary> This is the utilized percentage for the benefit ID. </summary>
        public decimal? UtilizationPercentage { get; }
    }
}
