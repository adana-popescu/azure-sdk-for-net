// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ArcScVmm
{
    /// <summary>
    /// A class representing a collection of <see cref="ScVmmVirtualMachineResource" /> and their operations.
    /// Each <see cref="ScVmmVirtualMachineResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ScVmmVirtualMachineCollection" /> instance call the GetScVmmVirtualMachines method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ScVmmVirtualMachineCollection : ArmCollection, IEnumerable<ScVmmVirtualMachineResource>, IAsyncEnumerable<ScVmmVirtualMachineResource>
    {
        private readonly ClientDiagnostics _scVmmVirtualMachineVirtualMachinesClientDiagnostics;
        private readonly VirtualMachinesRestOperations _scVmmVirtualMachineVirtualMachinesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScVmmVirtualMachineCollection"/> class for mocking. </summary>
        protected ScVmmVirtualMachineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScVmmVirtualMachineCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScVmmVirtualMachineCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scVmmVirtualMachineVirtualMachinesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ArcScVmm", ScVmmVirtualMachineResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ScVmmVirtualMachineResource.ResourceType, out string scVmmVirtualMachineVirtualMachinesApiVersion);
            _scVmmVirtualMachineVirtualMachinesRestClient = new VirtualMachinesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, scVmmVirtualMachineVirtualMachinesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates Or Updates virtual machines deployed on scvmm fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualMachineName"> Name of the VirtualMachine. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ScVmmVirtualMachineResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualMachineName, ScVmmVirtualMachineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("ScVmmVirtualMachineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scVmmVirtualMachineVirtualMachinesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ArcScVmmArmOperation<ScVmmVirtualMachineResource>(new ScVmmVirtualMachineOperationSource(Client), _scVmmVirtualMachineVirtualMachinesClientDiagnostics, Pipeline, _scVmmVirtualMachineVirtualMachinesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates Or Updates virtual machines deployed on scvmm fabric.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualMachineName"> Name of the VirtualMachine. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ScVmmVirtualMachineResource> CreateOrUpdate(WaitUntil waitUntil, string virtualMachineName, ScVmmVirtualMachineData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _scVmmVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("ScVmmVirtualMachineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scVmmVirtualMachineVirtualMachinesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, data, cancellationToken);
                var operation = new ArcScVmmArmOperation<ScVmmVirtualMachineResource>(new ScVmmVirtualMachineOperationSource(Client), _scVmmVirtualMachineVirtualMachinesClientDiagnostics, Pipeline, _scVmmVirtualMachineVirtualMachinesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements VirtualMachine GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineName"> Name of the VirtualMachine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual async Task<Response<ScVmmVirtualMachineResource>> GetAsync(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _scVmmVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("ScVmmVirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = await _scVmmVirtualMachineVirtualMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements VirtualMachine GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineName"> Name of the VirtualMachine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual Response<ScVmmVirtualMachineResource> Get(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _scVmmVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("ScVmmVirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = _scVmmVirtualMachineVirtualMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScVmmVirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of VirtualMachines in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScVmmVirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScVmmVirtualMachineResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmVirtualMachineVirtualMachinesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmVirtualMachineVirtualMachinesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ScVmmVirtualMachineResource(Client, ScVmmVirtualMachineData.DeserializeScVmmVirtualMachineData(e)), _scVmmVirtualMachineVirtualMachinesClientDiagnostics, Pipeline, "ScVmmVirtualMachineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of VirtualMachines in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScVmmVirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScVmmVirtualMachineResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _scVmmVirtualMachineVirtualMachinesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _scVmmVirtualMachineVirtualMachinesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ScVmmVirtualMachineResource(Client, ScVmmVirtualMachineData.DeserializeScVmmVirtualMachineData(e)), _scVmmVirtualMachineVirtualMachinesClientDiagnostics, Pipeline, "ScVmmVirtualMachineCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineName"> Name of the VirtualMachine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _scVmmVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("ScVmmVirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = await _scVmmVirtualMachineVirtualMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ScVmm/virtualMachines/{virtualMachineName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualMachines_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualMachineName"> Name of the VirtualMachine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualMachineName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachineName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualMachineName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualMachineName, nameof(virtualMachineName));

            using var scope = _scVmmVirtualMachineVirtualMachinesClientDiagnostics.CreateScope("ScVmmVirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = _scVmmVirtualMachineVirtualMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualMachineName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScVmmVirtualMachineResource> IEnumerable<ScVmmVirtualMachineResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScVmmVirtualMachineResource> IAsyncEnumerable<ScVmmVirtualMachineResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
