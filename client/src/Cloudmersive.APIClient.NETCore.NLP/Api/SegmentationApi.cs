/* 
 * nlpapiv2
 *
 * The powerful Natural Language Processing APIs (v2) let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Cloudmersive.APIClient.NETCore.NLP.Client;
using Cloudmersive.APIClient.NETCore.NLP.Model;

namespace Cloudmersive.APIClient.NETCore.NLP.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISegmentationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Extract sentences from string
        /// </summary>
        /// <remarks>
        /// Segment an input string into separate sentences, output result as a string.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>SentenceSegmentationResponse</returns>
        SentenceSegmentationResponse SegmentationGetSentences (SentenceSegmentationRequest input);

        /// <summary>
        /// Extract sentences from string
        /// </summary>
        /// <remarks>
        /// Segment an input string into separate sentences, output result as a string.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>ApiResponse of SentenceSegmentationResponse</returns>
        ApiResponse<SentenceSegmentationResponse> SegmentationGetSentencesWithHttpInfo (SentenceSegmentationRequest input);
        /// <summary>
        /// Get words in input string
        /// </summary>
        /// <remarks>
        /// Get the component words in an input string
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">String to process</param>
        /// <returns>GetWordsResponse</returns>
        GetWordsResponse SegmentationGetWords (GetWordsRequest input);

        /// <summary>
        /// Get words in input string
        /// </summary>
        /// <remarks>
        /// Get the component words in an input string
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">String to process</param>
        /// <returns>ApiResponse of GetWordsResponse</returns>
        ApiResponse<GetWordsResponse> SegmentationGetWordsWithHttpInfo (GetWordsRequest input);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Extract sentences from string
        /// </summary>
        /// <remarks>
        /// Segment an input string into separate sentences, output result as a string.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>Task of SentenceSegmentationResponse</returns>
        System.Threading.Tasks.Task<SentenceSegmentationResponse> SegmentationGetSentencesAsync (SentenceSegmentationRequest input);

        /// <summary>
        /// Extract sentences from string
        /// </summary>
        /// <remarks>
        /// Segment an input string into separate sentences, output result as a string.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>Task of ApiResponse (SentenceSegmentationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SentenceSegmentationResponse>> SegmentationGetSentencesAsyncWithHttpInfo (SentenceSegmentationRequest input);
        /// <summary>
        /// Get words in input string
        /// </summary>
        /// <remarks>
        /// Get the component words in an input string
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">String to process</param>
        /// <returns>Task of GetWordsResponse</returns>
        System.Threading.Tasks.Task<GetWordsResponse> SegmentationGetWordsAsync (GetWordsRequest input);

        /// <summary>
        /// Get words in input string
        /// </summary>
        /// <remarks>
        /// Get the component words in an input string
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">String to process</param>
        /// <returns>Task of ApiResponse (GetWordsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetWordsResponse>> SegmentationGetWordsAsyncWithHttpInfo (GetWordsRequest input);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SegmentationApi : ISegmentationApi
    {
        private Cloudmersive.APIClient.NETCore.NLP.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SegmentationApi(String basePath)
        {
            this.Configuration = new Cloudmersive.APIClient.NETCore.NLP.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NETCore.NLP.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SegmentationApi(Cloudmersive.APIClient.NETCore.NLP.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Cloudmersive.APIClient.NETCore.NLP.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NETCore.NLP.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Cloudmersive.APIClient.NETCore.NLP.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloudmersive.APIClient.NETCore.NLP.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Extract sentences from string Segment an input string into separate sentences, output result as a string.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>SentenceSegmentationResponse</returns>
        public SentenceSegmentationResponse SegmentationGetSentences (SentenceSegmentationRequest input)
        {
             ApiResponse<SentenceSegmentationResponse> localVarResponse = SegmentationGetSentencesWithHttpInfo(input);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Extract sentences from string Segment an input string into separate sentences, output result as a string.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>ApiResponse of SentenceSegmentationResponse</returns>
        public ApiResponse< SentenceSegmentationResponse > SegmentationGetSentencesWithHttpInfo (SentenceSegmentationRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling SegmentationApi->SegmentationGetSentences");

            var localVarPath = "./nlp-v2/segmentation/sentences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SegmentationGetSentences", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SentenceSegmentationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SentenceSegmentationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SentenceSegmentationResponse)));
        }

        /// <summary>
        /// Extract sentences from string Segment an input string into separate sentences, output result as a string.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>Task of SentenceSegmentationResponse</returns>
        public async System.Threading.Tasks.Task<SentenceSegmentationResponse> SegmentationGetSentencesAsync (SentenceSegmentationRequest input)
        {
             ApiResponse<SentenceSegmentationResponse> localVarResponse = await SegmentationGetSentencesAsyncWithHttpInfo(input);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Extract sentences from string Segment an input string into separate sentences, output result as a string.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">Input string</param>
        /// <returns>Task of ApiResponse (SentenceSegmentationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SentenceSegmentationResponse>> SegmentationGetSentencesAsyncWithHttpInfo (SentenceSegmentationRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling SegmentationApi->SegmentationGetSentences");

            var localVarPath = "./nlp-v2/segmentation/sentences";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SegmentationGetSentences", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SentenceSegmentationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SentenceSegmentationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SentenceSegmentationResponse)));
        }

        /// <summary>
        /// Get words in input string Get the component words in an input string
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">String to process</param>
        /// <returns>GetWordsResponse</returns>
        public GetWordsResponse SegmentationGetWords (GetWordsRequest input)
        {
             ApiResponse<GetWordsResponse> localVarResponse = SegmentationGetWordsWithHttpInfo(input);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get words in input string Get the component words in an input string
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">String to process</param>
        /// <returns>ApiResponse of GetWordsResponse</returns>
        public ApiResponse< GetWordsResponse > SegmentationGetWordsWithHttpInfo (GetWordsRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling SegmentationApi->SegmentationGetWords");

            var localVarPath = "./nlp-v2/segmentation/words";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SegmentationGetWords", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetWordsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (GetWordsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetWordsResponse)));
        }

        /// <summary>
        /// Get words in input string Get the component words in an input string
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">String to process</param>
        /// <returns>Task of GetWordsResponse</returns>
        public async System.Threading.Tasks.Task<GetWordsResponse> SegmentationGetWordsAsync (GetWordsRequest input)
        {
             ApiResponse<GetWordsResponse> localVarResponse = await SegmentationGetWordsAsyncWithHttpInfo(input);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get words in input string Get the component words in an input string
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.NLP.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">String to process</param>
        /// <returns>Task of ApiResponse (GetWordsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetWordsResponse>> SegmentationGetWordsAsyncWithHttpInfo (GetWordsRequest input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling SegmentationApi->SegmentationGetWords");

            var localVarPath = "./nlp-v2/segmentation/words";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = this.Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SegmentationGetWords", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetWordsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (GetWordsResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetWordsResponse)));
        }

    }
}