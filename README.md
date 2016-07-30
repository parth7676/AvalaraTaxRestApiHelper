# AvalaraTaxRestApiHelper
This project is using my another project [RestAPI-Caller](https://github.com/parth7676/RestAPI-Caller) to call [Avalara Rest API](http://developer.avalara.com/api-documentation/avatax-15-api/avatax-rest-api-reference). And return you the response object.

# AvalaraRequestData Object:
[AvalaraRequestData](AvalaraTaxRestApiHelper/Entities/AvalaraRequestData.cs) contains total 8 properties.

1.You need to pass EndPointURL (For devs:https://development.avalara.net/1.0/tax/get)

2.CustomerCode - Given by Avalara 

3.CompanyCode - Given by Avalara

4.DocType 

5.key   

6.Password        

7.Addresses         

8.Lines        

You can get more info about Avalar Request object @ : [Avalara Rest API Reference](http://developer.avalara.com/api-documentation/avatax-15-api/avatax-rest-api-reference)

# Response Object:
[Response Object](AvalaraTaxRestApiHelper/Entities/Response.cs) contains three properties:

 1.It will be filled with  return success or failure status according, wheather the call to rest API is successfull or not.
 
 2.It call to rest API is successfull.All the calculated data will be filled in [AvalaraSuccessResponseData](AvalaraTaxRestApiHelper/Entities/AvalaraResponseData.cs).
 
 3.If it has falied then error code and failure reason will be filled in [AvalaraErrorResponseData](AvalaraTaxRestApiHelper/Entities/AvalaraResponseData.cs).
 
#How TO Use:
 1.You can directly download this library and keep it in you project or you can use it's [Nuget Package](https://www.nuget.org/packages/AvalaraTaxHelper/).
