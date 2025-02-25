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

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="AuthorizationProviderOperationsMetadataResource" /> and their operations.
    /// Each <see cref="AuthorizationProviderOperationsMetadataResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get an <see cref="AuthorizationProviderOperationsMetadataCollection" /> instance call the GetAuthorizationProviderOperationsMetadata method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class AuthorizationProviderOperationsMetadataCollection : ArmCollection, IEnumerable<AuthorizationProviderOperationsMetadataResource>, IAsyncEnumerable<AuthorizationProviderOperationsMetadataResource>
    {
        private readonly ClientDiagnostics _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics;
        private readonly ProviderOperationsMetadataRestOperations _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient;

        /// <summary> Initializes a new instance of the <see cref="AuthorizationProviderOperationsMetadataCollection"/> class for mocking. </summary>
        protected AuthorizationProviderOperationsMetadataCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AuthorizationProviderOperationsMetadataCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AuthorizationProviderOperationsMetadataCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", AuthorizationProviderOperationsMetadataResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AuthorizationProviderOperationsMetadataResource.ResourceType, out string authorizationProviderOperationsMetadataProviderOperationsMetadataApiVersion);
            _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient = new ProviderOperationsMetadataRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, authorizationProviderOperationsMetadataProviderOperationsMetadataApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets provider operations metadata for the specified resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderOperationsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual async Task<Response<AuthorizationProviderOperationsMetadataResource>> GetAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics.CreateScope("AuthorizationProviderOperationsMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = await _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient.GetAsync(resourceProviderNamespace, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationProviderOperationsMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets provider operations metadata for the specified resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderOperationsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual Response<AuthorizationProviderOperationsMetadataResource> Get(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics.CreateScope("AuthorizationProviderOperationsMetadataCollection.Get");
            scope.Start();
            try
            {
                var response = _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient.Get(resourceProviderNamespace, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AuthorizationProviderOperationsMetadataResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets provider operations metadata for all resource providers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/providerOperations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderOperationsMetadata_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AuthorizationProviderOperationsMetadataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AuthorizationProviderOperationsMetadataResource> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient.CreateListRequest(expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient.CreateListNextPageRequest(nextLink, expand);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new AuthorizationProviderOperationsMetadataResource(Client, AuthorizationProviderOperationsMetadataData.DeserializeAuthorizationProviderOperationsMetadataData(e)), _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics, Pipeline, "AuthorizationProviderOperationsMetadataCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets provider operations metadata for all resource providers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/providerOperations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderOperationsMetadata_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AuthorizationProviderOperationsMetadataResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AuthorizationProviderOperationsMetadataResource> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient.CreateListRequest(expand);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient.CreateListNextPageRequest(nextLink, expand);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new AuthorizationProviderOperationsMetadataResource(Client, AuthorizationProviderOperationsMetadataData.DeserializeAuthorizationProviderOperationsMetadataData(e)), _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics, Pipeline, "AuthorizationProviderOperationsMetadataCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderOperationsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics.CreateScope("AuthorizationProviderOperationsMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = await _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient.GetAsync(resourceProviderNamespace, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Authorization/providerOperations/{resourceProviderNamespace}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProviderOperationsMetadata_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceProviderNamespace"> The namespace of the resource provider. </param>
        /// <param name="expand"> Specifies whether to expand the values. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceProviderNamespace"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceProviderNamespace, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceProviderNamespace, nameof(resourceProviderNamespace));

            using var scope = _authorizationProviderOperationsMetadataProviderOperationsMetadataClientDiagnostics.CreateScope("AuthorizationProviderOperationsMetadataCollection.Exists");
            scope.Start();
            try
            {
                var response = _authorizationProviderOperationsMetadataProviderOperationsMetadataRestClient.Get(resourceProviderNamespace, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AuthorizationProviderOperationsMetadataResource> IEnumerable<AuthorizationProviderOperationsMetadataResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AuthorizationProviderOperationsMetadataResource> IAsyncEnumerable<AuthorizationProviderOperationsMetadataResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
