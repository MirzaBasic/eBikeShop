using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace PeP_PCL.Util
{
   public class WebApiHelper
    {
       private HttpClient client { get; set; }
      

       private string route { get; set; }
       public WebApiHelper(string uri, string route)
       {

           client = new HttpClient();

           client.BaseAddress = new Uri(uri);
           this.route = route;
       }


       public HttpResponseMessage GetResponse()
       {
          
           return client.GetAsync(route).Result;
       }
        public HttpResponseMessage GetResponse(int id)
        {

            return client.GetAsync(route+"/"+id).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parameter = "", string parameter1 = "", string parameter2 = "")
        {
            return client.GetAsync(route + "/" + action + "/" + parameter + "/" + parameter1 + "/" + parameter2).Result;
        }

        public HttpResponseMessage GetActionResponse(string action, string parameter = "")
       {

           return client.GetAsync(route + "/" + action + "/" + parameter).Result;

       }
       public HttpResponseMessage GetActionResponse(string action, int parameter)
       {

           return client.GetAsync(route + "/" + action + "/" + parameter).Result;

       }

       public HttpResponseMessage GetActionResponse(string action , string parameter1, int parameter2)
       {

           return client.GetAsync(route + "/" + action + "/" + parameter1+"/"+parameter2).Result;

       }

        public HttpResponseMessage GetActionResponse(string action, int parameter1, int parameter2)
        {

            return client.GetAsync(route + "/" + action + "/" + parameter1 + "/" + parameter2).Result;

        }
        public HttpResponseMessage GetActionResponse(string action, int parameter1, string parameter2)
        {

            return client.GetAsync(route + "/" + action + "/" + parameter1 + "/" + parameter2).Result;

        }


        public HttpResponseMessage GetActionResponse(int parameter, string action)
       {

           return client.GetAsync(route + "/" +parameter+ "/" + action).Result;

       }
       public HttpResponseMessage PostActionResponse(string action, int parameter1, List<Object> obj)
       {
           //prepravit ako treba da bolje izlgeeda routa
           return client.PostAsJsonAsync(route + "/"+action +"/"+ parameter1,obj).Result;

       }

      
       public HttpResponseMessage GetResponse(string username)
       {

           return client.GetAsync(route+"/"+username).Result;
       }

       public HttpResponseMessage PutActionResponse(int id, Object obj)
       {


           return client.PutAsJsonAsync(route + "/" + id, obj).Result;

       }
     
     

       public HttpResponseMessage PostResponse(Object obj)
       {
           return client.PostAsJsonAsync(route, obj).Result;


       }





    
    }
}
