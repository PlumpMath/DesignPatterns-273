using GeneralModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNet.Identity;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Web.Http.Cors;

namespace GeneralApi.Controllers
{
   
    [EnableCors( origins:"*",headers:"*",methods:"*")]
    public class BaseController : ApiController
    {
        protected string UserId { get { return User.Identity.GetUserId(); } }

        protected HttpResponseMessage GenericResponse<T>(ServiceResponse<T> response)
        {
            try
            {
                var responseModel = new HttpResponseModel<T>() { Data = response.Data, InnerCode = response.Code, Message = "" };// HttpResponseMap.CodeMapping[response.Code].Value };
                return Request.CreateResponse( HttpStatusCode.OK, responseModel);
                //return Request.CreateResponse(HttpResponseMap.CodeMapping[response.Code].Key, responseModel);
            }
            catch (Exception) 
            {

                throw;
            }

        }
    }
}
