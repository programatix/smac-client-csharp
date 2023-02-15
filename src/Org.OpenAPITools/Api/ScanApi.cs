/*
 * SMAC API
 *
 * SMAC ASP.NET Core Web API
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScanApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves the SMAC content list.
        /// </summary>
        /// <remarks>
        /// This API should be followed up by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content\&quot;&gt;/api/Scan/content&lt;/a&gt;.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ScanContentListResponse</returns>
        ScanContentListResponse ApiScanContentListPost(ScanContentListRequest scanContentListRequest = default(ScanContentListRequest), int operationIndex = 0);

        /// <summary>
        /// Retrieves the SMAC content list.
        /// </summary>
        /// <remarks>
        /// This API should be followed up by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content\&quot;&gt;/api/Scan/content&lt;/a&gt;.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ScanContentListResponse</returns>
        ApiResponse<ScanContentListResponse> ApiScanContentListPostWithHttpInfo(ScanContentListRequest scanContentListRequest = default(ScanContentListRequest), int operationIndex = 0);
        /// <summary>
        /// Retrieves the SMAC content.
        /// </summary>
        /// <remarks>
        /// Before calling this API, &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt; must be called first.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ScanContentResponse</returns>
        ScanContentResponse ApiScanContentPost(ScanContentRequest scanContentRequest = default(ScanContentRequest), int operationIndex = 0);

        /// <summary>
        /// Retrieves the SMAC content.
        /// </summary>
        /// <remarks>
        /// Before calling this API, &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt; must be called first.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ScanContentResponse</returns>
        ApiResponse<ScanContentResponse> ApiScanContentPostWithHttpInfo(ScanContentRequest scanContentRequest = default(ScanContentRequest), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScanApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves the SMAC content list.
        /// </summary>
        /// <remarks>
        /// This API should be followed up by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content\&quot;&gt;/api/Scan/content&lt;/a&gt;.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ScanContentListResponse</returns>
        System.Threading.Tasks.Task<ScanContentListResponse> ApiScanContentListPostAsync(ScanContentListRequest scanContentListRequest = default(ScanContentListRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the SMAC content list.
        /// </summary>
        /// <remarks>
        /// This API should be followed up by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content\&quot;&gt;/api/Scan/content&lt;/a&gt;.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ScanContentListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScanContentListResponse>> ApiScanContentListPostWithHttpInfoAsync(ScanContentListRequest scanContentListRequest = default(ScanContentListRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Retrieves the SMAC content.
        /// </summary>
        /// <remarks>
        /// Before calling this API, &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt; must be called first.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ScanContentResponse</returns>
        System.Threading.Tasks.Task<ScanContentResponse> ApiScanContentPostAsync(ScanContentRequest scanContentRequest = default(ScanContentRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the SMAC content.
        /// </summary>
        /// <remarks>
        /// Before calling this API, &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt; must be called first.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ScanContentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScanContentResponse>> ApiScanContentPostWithHttpInfoAsync(ScanContentRequest scanContentRequest = default(ScanContentRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScanApi : IScanApiSync, IScanApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ScanApi : IScanApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScanApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScanApi(string basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ScanApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScanApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ScanApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Retrieves the SMAC content list. This API should be followed up by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content\&quot;&gt;/api/Scan/content&lt;/a&gt;.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ScanContentListResponse</returns>
        public ScanContentListResponse ApiScanContentListPost(ScanContentListRequest scanContentListRequest = default(ScanContentListRequest), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<ScanContentListResponse> localVarResponse = ApiScanContentListPostWithHttpInfo(scanContentListRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the SMAC content list. This API should be followed up by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content\&quot;&gt;/api/Scan/content&lt;/a&gt;.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ScanContentListResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<ScanContentListResponse> ApiScanContentListPostWithHttpInfo(ScanContentListRequest scanContentListRequest = default(ScanContentListRequest), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = scanContentListRequest;

            localVarRequestOptions.Operation = "ScanApi.ApiScanContentListPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ScanContentListResponse>("/api/Scan/content-list", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiScanContentListPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the SMAC content list. This API should be followed up by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content\&quot;&gt;/api/Scan/content&lt;/a&gt;.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ScanContentListResponse</returns>
        public async System.Threading.Tasks.Task<ScanContentListResponse> ApiScanContentListPostAsync(ScanContentListRequest scanContentListRequest = default(ScanContentListRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<ScanContentListResponse> localVarResponse = await ApiScanContentListPostWithHttpInfoAsync(scanContentListRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the SMAC content list. This API should be followed up by &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content\&quot;&gt;/api/Scan/content&lt;/a&gt;.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentListRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ScanContentListResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<ScanContentListResponse>> ApiScanContentListPostWithHttpInfoAsync(ScanContentListRequest scanContentListRequest = default(ScanContentListRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = scanContentListRequest;

            localVarRequestOptions.Operation = "ScanApi.ApiScanContentListPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ScanContentListResponse>("/api/Scan/content-list", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiScanContentListPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the SMAC content. Before calling this API, &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt; must be called first.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ScanContentResponse</returns>
        public ScanContentResponse ApiScanContentPost(ScanContentRequest scanContentRequest = default(ScanContentRequest), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<ScanContentResponse> localVarResponse = ApiScanContentPostWithHttpInfo(scanContentRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the SMAC content. Before calling this API, &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt; must be called first.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ScanContentResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<ScanContentResponse> ApiScanContentPostWithHttpInfo(ScanContentRequest scanContentRequest = default(ScanContentRequest), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = scanContentRequest;

            localVarRequestOptions.Operation = "ScanApi.ApiScanContentPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Post<ScanContentResponse>("/api/Scan/content", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiScanContentPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the SMAC content. Before calling this API, &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt; must be called first.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ScanContentResponse</returns>
        public async System.Threading.Tasks.Task<ScanContentResponse> ApiScanContentPostAsync(ScanContentRequest scanContentRequest = default(ScanContentRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<ScanContentResponse> localVarResponse = await ApiScanContentPostWithHttpInfoAsync(scanContentRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the SMAC content. Before calling this API, &lt;a href&#x3D;\&quot;#operations-Scan-post_api_Scan_content_list\&quot;&gt;/api/Scan/content-list&lt;/a&gt; must be called first.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanContentRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ScanContentResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<ScanContentResponse>> ApiScanContentPostWithHttpInfoAsync(ScanContentRequest scanContentRequest = default(ScanContentRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/*+json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = scanContentRequest;

            localVarRequestOptions.Operation = "ScanApi.ApiScanContentPost";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<ScanContentResponse>("/api/Scan/content", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiScanContentPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
