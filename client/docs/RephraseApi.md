# Cloudmersive.APIClient.NETCore.NLP.Api.RephraseApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RephraseTranslateDeuToEng**](RephraseApi.md#rephrasetranslatedeutoeng) | **POST** /nlp-v2/rephrase/rephrase/eng/by-sentence | Rephrase, paraphrase English text sentence-by-sentence using Deep Learning AI


<a name="rephrasetranslatedeutoeng"></a>
# **RephraseTranslateDeuToEng**
> RephraseResponse RephraseTranslateDeuToEng (RephraseRequest input)

Rephrase, paraphrase English text sentence-by-sentence using Deep Learning AI

Automatically rephrases or paraphrases input text in English sentence by sentence using advanced Deep Learning and Neural NLP.  Creates multiple reprhasing candidates per input sentence, from 1 to 10 possible rephrasings of the original sentence.  Seeks to preserve original semantic meaning in rephrased output candidates.  Consumes 1-2 API calls per output rephrasing option generated, per sentence.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.NLP.Api;
using Cloudmersive.APIClient.NETCore.NLP.Client;
using Cloudmersive.APIClient.NETCore.NLP.Model;

namespace Example
{
    public class RephraseTranslateDeuToEngExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new RephraseApi();
            var input = new RephraseRequest(); // RephraseRequest | Input rephrase request

            try
            {
                // Rephrase, paraphrase English text sentence-by-sentence using Deep Learning AI
                RephraseResponse result = apiInstance.RephraseTranslateDeuToEng(input);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RephraseApi.RephraseTranslateDeuToEng: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **input** | [**RephraseRequest**](RephraseRequest.md)| Input rephrase request | 

### Return type

[**RephraseResponse**](RephraseResponse.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
