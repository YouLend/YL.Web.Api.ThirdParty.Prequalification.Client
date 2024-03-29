# YL.Web.Api.ThirdParty.Prequalification.Client - the C# library for the YouLend Third Party Pre Qualification API

Through this API you can can check if a merchant pre qualifies for a Youlend loan

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.6.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [CompareNETObjects](https://www.nuget.org/packages/CompareNETObjects) - 4.57.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
Install-Package CompareNETObjects
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
<a name="installation"></a>
## Installation

*Install dotnet dotnet:*
```
dotnet add package YL.Web.Api.ThirdParty.Prequalification.Client --version 1.0.0
```
*Install with nuget:*
```B
Install-Package YL.Web.Api.ThirdParty.Prequalification.Client -Version 1.0.0
```

*Add direct package reference to you project file:*
```
<PackageReference Include="YL.Web.Api.ThirdParty.Prequalification.Client" Version="1.0.1" />
```

More detail on nuget: [YL.Web.Api.ThirdParty.Prequalification.Client.Client]( https://www.nuget.org/packages/YL.Web.Api.ThirdParty.Prequalification.Client/1.0.0)


Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using YL.Web.Api.ThirdParty.Prequalification.Client.Api;
using YL.Web.Api.ThirdParty.Prequalification.Client.Client;
using YL.Web.Api.ThirdParty.Prequalification.Client.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.Prequalification.Client.Api;
using YL.Web.Api.ThirdParty.Prequalification.Client.Client;
using YL.Web.Api.ThirdParty.Prequalification.Client.Model;

namespace Example
{
	public class Example
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
			catch (ApiException e)
			{
				Debug.Print("Exception when calling RequestsApi.RequestsPost: " + e.Message );
				Debug.Print("Status Code: "+ e.ErrorCode);
				Debug.Print(e.StackTrace);
			}

		}
	}
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://dev.youlendapi.com/prequalification*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*RequestsApi* | [**RequestsPost**](docs/RequestsApi.md#requestspost) | **POST** /Requests | Initiates a prequalification of a merchant for a loan. It will use as much data as it can to do the analysis  so the more data provided the more accurate the result


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressModel](docs/AddressModel.md)
 - [Model.FinancialDataModel](docs/FinancialDataModel.md)
 - [Model.InvoiceDataRowModel](docs/InvoiceDataRowModel.md)
 - [Model.LoanOptionDocument](docs/LoanOptionDocument.md)
 - [Model.PaymentDataRowModel](docs/PaymentDataRowModel.md)
 - [Model.PreQualificationModel](docs/PreQualificationModel.md)
 - [Model.PreQualificationResultDocument](docs/PreQualificationResultDocument.md)
 - [Model.ProblemDetails](docs/ProblemDetails.md)
 - [Model.PurchaseDataRowModel](docs/PurchaseDataRowModel.md)
 - [Model.SignificantPersonModel](docs/SignificantPersonModel.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="oauth2"></a>
### oauth2

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: N/A

