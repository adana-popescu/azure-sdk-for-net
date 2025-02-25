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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkDeviceInterfaceResource" /> and their operations.
    /// Each <see cref="NetworkDeviceInterfaceResource" /> in the collection will belong to the same instance of <see cref="NetworkDeviceResource" />.
    /// To get a <see cref="NetworkDeviceInterfaceCollection" /> instance call the GetNetworkDeviceInterfaces method from an instance of <see cref="NetworkDeviceResource" />.
    /// </summary>
    public partial class NetworkDeviceInterfaceCollection : ArmCollection, IEnumerable<NetworkDeviceInterfaceResource>, IAsyncEnumerable<NetworkDeviceInterfaceResource>
    {
        private readonly ClientDiagnostics _networkDeviceInterfaceNetworkInterfacesClientDiagnostics;
        private readonly NetworkInterfacesRestOperations _networkDeviceInterfaceNetworkInterfacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkDeviceInterfaceCollection"/> class for mocking. </summary>
        protected NetworkDeviceInterfaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkDeviceInterfaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkDeviceInterfaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkDeviceInterfaceNetworkInterfacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkDeviceInterfaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkDeviceInterfaceResource.ResourceType, out string networkDeviceInterfaceNetworkInterfacesApiVersion);
            _networkDeviceInterfaceNetworkInterfacesRestClient = new NetworkInterfacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkDeviceInterfaceNetworkInterfacesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkDeviceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkDeviceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a Network Interface resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkInterfaceName"> Name of the Network Interface. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkDeviceInterfaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string networkInterfaceName, NetworkDeviceInterfaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkDeviceInterfaceNetworkInterfacesClientDiagnostics.CreateScope("NetworkDeviceInterfaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkDeviceInterfaceNetworkInterfacesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkInterfaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedNetworkFabricArmOperation<NetworkDeviceInterfaceResource>(new NetworkDeviceInterfaceOperationSource(Client), _networkDeviceInterfaceNetworkInterfacesClientDiagnostics, Pipeline, _networkDeviceInterfaceNetworkInterfacesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkInterfaceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a Network Interface resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="networkInterfaceName"> Name of the Network Interface. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkDeviceInterfaceResource> CreateOrUpdate(WaitUntil waitUntil, string networkInterfaceName, NetworkDeviceInterfaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkDeviceInterfaceNetworkInterfacesClientDiagnostics.CreateScope("NetworkDeviceInterfaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkDeviceInterfaceNetworkInterfacesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkInterfaceName, data, cancellationToken);
                var operation = new ManagedNetworkFabricArmOperation<NetworkDeviceInterfaceResource>(new NetworkDeviceInterfaceOperationSource(Client), _networkDeviceInterfaceNetworkInterfacesClientDiagnostics, Pipeline, _networkDeviceInterfaceNetworkInterfacesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkInterfaceName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get the Network Interface resource details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkInterfaceName"> Name of the Network Interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual async Task<Response<NetworkDeviceInterfaceResource>> GetAsync(string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkDeviceInterfaceNetworkInterfacesClientDiagnostics.CreateScope("NetworkDeviceInterfaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkDeviceInterfaceNetworkInterfacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkInterfaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkDeviceInterfaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Network Interface resource details.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkInterfaceName"> Name of the Network Interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual Response<NetworkDeviceInterfaceResource> Get(string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkDeviceInterfaceNetworkInterfacesClientDiagnostics.CreateScope("NetworkDeviceInterfaceCollection.Get");
            scope.Start();
            try
            {
                var response = _networkDeviceInterfaceNetworkInterfacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkInterfaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkDeviceInterfaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the Network Interface resources in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}/networkInterfaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_ListByNetworkDevice</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkDeviceInterfaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkDeviceInterfaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkDeviceInterfaceNetworkInterfacesRestClient.CreateListByNetworkDeviceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkDeviceInterfaceNetworkInterfacesRestClient.CreateListByNetworkDeviceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkDeviceInterfaceResource(Client, NetworkDeviceInterfaceData.DeserializeNetworkDeviceInterfaceData(e)), _networkDeviceInterfaceNetworkInterfacesClientDiagnostics, Pipeline, "NetworkDeviceInterfaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the Network Interface resources in a given resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}/networkInterfaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_ListByNetworkDevice</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkDeviceInterfaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkDeviceInterfaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkDeviceInterfaceNetworkInterfacesRestClient.CreateListByNetworkDeviceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkDeviceInterfaceNetworkInterfacesRestClient.CreateListByNetworkDeviceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkDeviceInterfaceResource(Client, NetworkDeviceInterfaceData.DeserializeNetworkDeviceInterfaceData(e)), _networkDeviceInterfaceNetworkInterfacesClientDiagnostics, Pipeline, "NetworkDeviceInterfaceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkInterfaceName"> Name of the Network Interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkDeviceInterfaceNetworkInterfacesClientDiagnostics.CreateScope("NetworkDeviceInterfaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkDeviceInterfaceNetworkInterfacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkInterfaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedNetworkFabric/networkDevices/{networkDeviceName}/networkInterfaces/{networkInterfaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkInterfaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkInterfaceName"> Name of the Network Interface. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkInterfaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkInterfaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkInterfaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkInterfaceName, nameof(networkInterfaceName));

            using var scope = _networkDeviceInterfaceNetworkInterfacesClientDiagnostics.CreateScope("NetworkDeviceInterfaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkDeviceInterfaceNetworkInterfacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, networkInterfaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkDeviceInterfaceResource> IEnumerable<NetworkDeviceInterfaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkDeviceInterfaceResource> IAsyncEnumerable<NetworkDeviceInterfaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
