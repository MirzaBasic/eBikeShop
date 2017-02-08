using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace PeP_API.Util
{
    public class ExceptionFilter:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
          if(actionExecutedContext.Exception is NotImplementedException){
        HttpResponseMessage msg=new HttpResponseMessage(){
            StatusCode=HttpStatusCode.PaymentRequired,
            Content=new StringContent("Pristup metodi zahtjeva uplatu"),
            ReasonPhrase="Uplata obavezna"

        };
            actionExecutedContext.Response=msg;
          
          }
        
       }
    }
}