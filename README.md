# Cloudmersive.APIClient.NETCore.NLP - the C# library for the nlpapiv2

The powerful Natural Language Processing APIs (v2) let you perform part of speech tagging, entity identification, sentence parsing, and much more to help you understand the meaning of unstructured text.

This C# SDK is for the [Cloudmersive Natural Language Processing API](https://www.cloudmersive.com/nlp-api):

- API version: v1
- SDK version: 2.0.7
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NETCore.NLP.Api;
using Cloudmersive.APIClient.NETCore.NLP.Client;
using Cloudmersive.APIClient.NETCore.NLP.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.NLP.Api;
using Cloudmersive.APIClient.NETCore.NLP.Client;
using Cloudmersive.APIClient.NETCore.NLP.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new ExtractEntitiesApi();
            var value = new ExtractEntitiesRequest(); // ExtractEntitiesRequest | Input string

            try
            {
                // Extract entities from string
                ExtractEntitiesResponse result = apiInstance.ExtractEntitiesPost(value);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtractEntitiesApi.ExtractEntitiesPost: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ExtractEntitiesApi* | [**ExtractEntitiesPost**](docs/ExtractEntitiesApi.md#extractentitiespost) | **POST** /nlp-v2/extract-entities | Extract entities from string
*LanguageDetectionApi* | [**LanguageDetectionGetLanguage**](docs/LanguageDetectionApi.md#languagedetectiongetlanguage) | **POST** /nlp-v2/language/detect | Detect language of text
*LanguageTranslationApi* | [**LanguageTranslationTranslateDeuToEng**](docs/LanguageTranslationApi.md#languagetranslationtranslatedeutoeng) | **POST** /nlp-v2/translate/language/deu/to/eng | Translate German to English text with Deep Learning AI
*LanguageTranslationApi* | [**LanguageTranslationTranslateEngToDeu**](docs/LanguageTranslationApi.md#languagetranslationtranslateengtodeu) | **POST** /nlp-v2/translate/language/eng/to/deu | Translate English to German text with Deep Learning AI
*LanguageTranslationApi* | [**LanguageTranslationTranslateEngToRus**](docs/LanguageTranslationApi.md#languagetranslationtranslateengtorus) | **POST** /nlp-v2/translate/language/eng/to/rus | Translate English to Russian text with Deep Learning AI
*LanguageTranslationApi* | [**LanguageTranslationTranslateRusToEng**](docs/LanguageTranslationApi.md#languagetranslationtranslaterustoeng) | **POST** /nlp-v2/translate/language/rus/to/eng | Translate Russian to English text with Deep Learning AI
*ParseApi* | [**ParseParseString**](docs/ParseApi.md#parseparsestring) | **POST** /nlp-v2/parse/tree | Parse string to syntax tree
*PosTaggerApi* | [**PosTaggerTagAdjectives**](docs/PosTaggerApi.md#postaggertagadjectives) | **POST** /nlp-v2/pos/tag/adjectives | Part-of-speech tag a string, filter to adjectives
*PosTaggerApi* | [**PosTaggerTagAdverbs**](docs/PosTaggerApi.md#postaggertagadverbs) | **POST** /nlp-v2/pos/tag/adverbs | Part-of-speech tag a string, filter to adverbs
*PosTaggerApi* | [**PosTaggerTagNouns**](docs/PosTaggerApi.md#postaggertagnouns) | **POST** /nlp-v2/pos/tag/nouns | Part-of-speech tag a string, filter to nouns
*PosTaggerApi* | [**PosTaggerTagPronouns**](docs/PosTaggerApi.md#postaggertagpronouns) | **POST** /nlp-v2/pos/tag/pronouns | Part-of-speech tag a string, filter to pronouns
*PosTaggerApi* | [**PosTaggerTagSentence**](docs/PosTaggerApi.md#postaggertagsentence) | **POST** /nlp-v2/pos/tag/sentence | Part-of-speech tag a string
*PosTaggerApi* | [**PosTaggerTagVerbs**](docs/PosTaggerApi.md#postaggertagverbs) | **POST** /nlp-v2/pos/tag/verbs | Part-of-speech tag a string, filter to verbs
*RephraseApi* | [**RephraseTranslateDeuToEng**](docs/RephraseApi.md#rephrasetranslatedeutoeng) | **POST** /nlp-v2/rephrase/rephrase/eng/by-sentence | Rephrase, paraphrase English text sentence-by-sentence using Deep Learning AI
*SegmentationApi* | [**SegmentationGetSentences**](docs/SegmentationApi.md#segmentationgetsentences) | **POST** /nlp-v2/segmentation/sentences | Extract sentences from string
*SegmentationApi* | [**SegmentationGetWords**](docs/SegmentationApi.md#segmentationgetwords) | **POST** /nlp-v2/segmentation/words | Get words in input string
*SpellcheckApi* | [**SpellcheckCheckSentence**](docs/SpellcheckApi.md#spellcheckchecksentence) | **POST** /nlp-v2/spellcheck/check/sentence | Check if sentence is spelled correctly
*SpellcheckApi* | [**SpellcheckCorrectJson**](docs/SpellcheckApi.md#spellcheckcorrectjson) | **POST** /nlp-v2/spellcheck/check/word | Find spelling corrections


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.CheckSentenceRequest](docs/CheckSentenceRequest.md)
 - [Model.CheckSentenceResponse](docs/CheckSentenceResponse.md)
 - [Model.CheckWordRequest](docs/CheckWordRequest.md)
 - [Model.CheckWordResponse](docs/CheckWordResponse.md)
 - [Model.CorrectWordInSentence](docs/CorrectWordInSentence.md)
 - [Model.Entity](docs/Entity.md)
 - [Model.ExtractEntitiesRequest](docs/ExtractEntitiesRequest.md)
 - [Model.ExtractEntitiesResponse](docs/ExtractEntitiesResponse.md)
 - [Model.GetWordsRequest](docs/GetWordsRequest.md)
 - [Model.GetWordsResponse](docs/GetWordsResponse.md)
 - [Model.LanguageDetectionRequest](docs/LanguageDetectionRequest.md)
 - [Model.LanguageDetectionResponse](docs/LanguageDetectionResponse.md)
 - [Model.LanguageTranslationRequest](docs/LanguageTranslationRequest.md)
 - [Model.LanguageTranslationResponse](docs/LanguageTranslationResponse.md)
 - [Model.ParseRequest](docs/ParseRequest.md)
 - [Model.ParseResponse](docs/ParseResponse.md)
 - [Model.PosRequest](docs/PosRequest.md)
 - [Model.PosResponse](docs/PosResponse.md)
 - [Model.PosSentence](docs/PosSentence.md)
 - [Model.PosTaggedWord](docs/PosTaggedWord.md)
 - [Model.RephraseRequest](docs/RephraseRequest.md)
 - [Model.RephraseResponse](docs/RephraseResponse.md)
 - [Model.RephrasedSentence](docs/RephrasedSentence.md)
 - [Model.RephrasedSentenceOption](docs/RephrasedSentenceOption.md)
 - [Model.SentenceSegmentationRequest](docs/SentenceSegmentationRequest.md)
 - [Model.SentenceSegmentationResponse](docs/SentenceSegmentationResponse.md)
 - [Model.WordPosition](docs/WordPosition.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

