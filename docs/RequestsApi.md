# YL.Web.Api.ThirdParty.Prequalification.Client.Api.RequestsApi

All URIs are relative to *https://dev.youlendapi.com/prequalification*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RequestsPost**](RequestsApi.md#requestspost) | **POST** /Requests | Initiates a prequalification of a merchant for a loan. It will use as much data as it can to do the analysis  so the more data provided the more accurate the result


<a name="requestspost"></a>
# **RequestsPost**
> PreQualificationResultDocument RequestsPost (string apiVersion = null, PreQualificationModel preQualificationModel = null)

Initiates a prequalification of a merchant for a loan. It will use as much data as it can to do the analysis  so the more data provided the more accurate the result

Can add sample as an example here

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Prequalification.Client.Api;
using YL.Web.Api.ThirdParty.Prequalification.Client.Client;
using YL.Web.Api.ThirdParty.Prequalification.Client.Model;

namespace Example
{
    public class RequestsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://dev.youlendapi.com/prequalification";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
			var config = new Configuration
            {
                BasePath = "https://dev.youlendapi.com/prequalification"",
                AccessToken =
                    "YOUR_ACCESS_TOKEN"
            };
            
            var apiInstance = new RequestsApi(config);
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var preQualificationModel = new PreQualificationModel(); // PreQualificationModel |  (optional) 

            try
            {
                // Initiates a prequalification of a merchant for a loan. It will use as much data as it can to do the analysis  so the more data provided the more accurate the result
                PreQualificationResultDocument result = apiInstance.RequestsPost(apiVersion, preQualificationModel);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RequestsApi.RequestsPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | [optional] 
 **preQualificationModel** | [**PreQualificationModel**](PreQualificationModel.md)|  | [optional] 

### Return type

[**PreQualificationResultDocument**](PreQualificationResultDocument.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request |  -  |
| **200** | Returns PreQualificationResultDocument |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

