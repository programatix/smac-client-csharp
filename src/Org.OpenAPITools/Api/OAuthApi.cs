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
    public interface IOAuthApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Verifies token issued by SMAC for OAuth purposes.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyTokenRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VerifyTokenResponse</returns>
        VerifyTokenResponse ApiOAuthVerifyTokenPost(VerifyTokenRequest verifyTokenRequest = default(VerifyTokenRequest), int operationIndex = 0);

        /// <summary>
        /// Verifies token issued by SMAC for OAuth purposes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyTokenRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VerifyTokenResponse</returns>
        ApiResponse<VerifyTokenResponse> ApiOAuthVerifyTokenPostWithHttpInfo(VerifyTokenRequest verifyTokenRequest = default(VerifyTokenRequest), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuthApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Verifies token issued by SMAC for OAuth purposes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyTokenRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VerifyTokenResponse</returns>
        System.Threading.Tasks.Task<VerifyTokenResponse> ApiOAuthVerifyTokenPostAsync(VerifyTokenRequest verifyTokenRequest = default(VerifyTokenRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Verifies token issued by SMAC for OAuth purposes.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyTokenRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VerifyTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VerifyTokenResponse>> ApiOAuthVerifyTokenPostWithHttpInfoAsync(VerifyTokenRequest verifyTokenRequest = default(VerifyTokenRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOAuthApi : IOAuthApiSync, IOAuthApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OAuthApi : IOAuthApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OAuthApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OAuthApi(string basePath)
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
        /// Initializes a new instance of the <see cref="OAuthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OAuthApi(Org.OpenAPITools.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="OAuthApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public OAuthApi(Org.OpenAPITools.Client.ISynchronousClient client, Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
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
        /// Verifies token issued by SMAC for OAuth purposes. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyTokenRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>VerifyTokenResponse</returns>
        public VerifyTokenResponse ApiOAuthVerifyTokenPost(VerifyTokenRequest verifyTokenRequest = default(VerifyTokenRequest), int operationIndex = 0)
        {
            Org.OpenAPITools.Client.ApiResponse<VerifyTokenResponse> localVarResponse = ApiOAuthVerifyTokenPostWithHttpInfo(verifyTokenRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Verifies token issued by SMAC for OAuth purposes. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyTokenRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of VerifyTokenResponse</returns>
        public Org.OpenAPITools.Client.ApiResponse<VerifyTokenResponse> ApiOAuthVerifyTokenPostWithHttpInfo(VerifyTokenRequest verifyTokenRequest = default(VerifyTokenRequest), int operationIndex = 0)
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

            localVarRequestOptions.Data = verifyTokenRequest;

            localVarRequestOptions.Operation = "OAuthApi.ApiOAuthVerifyTokenPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-SMAC-PLATFORM-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-SMAC-PLATFORM-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-SMAC-PLATFORM-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<VerifyTokenResponse>("/api/OAuth/verify-token", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiOAuthVerifyTokenPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Verifies token issued by SMAC for OAuth purposes. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyTokenRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VerifyTokenResponse</returns>
        public async System.Threading.Tasks.Task<VerifyTokenResponse> ApiOAuthVerifyTokenPostAsync(VerifyTokenRequest verifyTokenRequest = default(VerifyTokenRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Org.OpenAPITools.Client.ApiResponse<VerifyTokenResponse> localVarResponse = await ApiOAuthVerifyTokenPostWithHttpInfoAsync(verifyTokenRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Verifies token issued by SMAC for OAuth purposes. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="verifyTokenRequest"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (VerifyTokenResponse)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<VerifyTokenResponse>> ApiOAuthVerifyTokenPostWithHttpInfoAsync(VerifyTokenRequest verifyTokenRequest = default(VerifyTokenRequest), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.Data = verifyTokenRequest;

            localVarRequestOptions.Operation = "OAuthApi.ApiOAuthVerifyTokenPost";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-SMAC-PLATFORM-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-SMAC-PLATFORM-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-SMAC-PLATFORM-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<VerifyTokenResponse>("/api/OAuth/verify-token", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiOAuthVerifyTokenPost", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
