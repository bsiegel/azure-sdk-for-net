// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Dns
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DnsResourceReferenceOperations.
    /// </summary>
    public static partial class DnsResourceReferenceOperationsExtensions
    {
            /// <summary>
            /// Returns the DNS records specified by the referencing targetResourceIds.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetResources'>
            /// A list of references to azure resources for which referencing dns records
            /// need to be queried.
            /// </param>
            public static DnsResourceReferenceResult GetByTargetResources(this IDnsResourceReferenceOperations operations, IList<SubResource> targetResources = default(IList<SubResource>))
            {
                return operations.GetByTargetResourcesAsync(targetResources).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the DNS records specified by the referencing targetResourceIds.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetResources'>
            /// A list of references to azure resources for which referencing dns records
            /// need to be queried.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DnsResourceReferenceResult> GetByTargetResourcesAsync(this IDnsResourceReferenceOperations operations, IList<SubResource> targetResources = default(IList<SubResource>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByTargetResourcesWithHttpMessagesAsync(targetResources, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}