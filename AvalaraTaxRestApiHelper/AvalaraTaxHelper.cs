using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZNode.Libraries.AvalaraTax.Entities;

namespace AvalaraTaxRestApiHelper
{
    public class AvalaraTaxHelper
    {
        public Response GetTax(AvalaraRequestData requestData)
        {
            //Address of the Rest API which we need to call
            var endPoint = requestData.EndPointURL; // @"https://development.avalara.net/1.0/tax/get";

            //Request Method(POST/GET/DELETE/PUT)
            var method = Enums.HttpVerb.POST;

            //Type of content which we want.
            //Rest API accept two content types.
            //1."text/xml"-Working with XML data
            //2."appplication/json"-Working with Json data
            var contentType = "appplication/json";

            //Basic [account number]:[license key] encoded to Base64,
            //as per basic access authentication.
            //For example: Authorization: Basic a2VlcG1vdmluZzpub3RoaW5nMnNlZWhlcmU
            var rawAuthenticationString = requestData.key + ":" + requestData.Password;
            byte[] bytes = Encoding.UTF8.GetBytes(rawAuthenticationString);
            var base64 = Convert.ToBase64String(bytes);
            var authenticationHeader = "Basic" + " " + base64;
            Dictionary<string, string> requestHeaders = new Dictionary<string, string>();
            requestHeaders.Add("Authorization", authenticationHeader);


            if (string.IsNullOrEmpty(requestData.CustomerCode))
            {
                requestData.CustomerCode = "NEWCUSTOMER";
            }

            //Optional
            //Additional data that you want to pass with your request
            //In case of Json data object is serialized into string using Json.Net 
            var postData = JsonConvert.SerializeObject
                (requestData, Formatting.Indented,
                            new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore
                            });
            RestAPIHelper callAvalaraRestAPI = new RestAPIHelper();
            var restAPIResponseData = callAvalaraRestAPI.MakeRequest(endPoint, method, contentType, requestHeaders, postData);
            Response response = new Response();
            response.Status = restAPIResponseData.Status;

            if (restAPIResponseData.Status == Enums.Status.Success)
            {
                response.SuccessResponse = JsonConvert.DeserializeObject<AvalaraSuccessResponseData>(restAPIResponseData.ResponseData);
                response.ErrorResponse = null;
            }
            else
            {
                response.SuccessResponse = null;
                response.ErrorResponse = JsonConvert.DeserializeObject<AvalaraErrorResponseData>(restAPIResponseData.ResponseData);
            }

            return response;
        }
    }
}
