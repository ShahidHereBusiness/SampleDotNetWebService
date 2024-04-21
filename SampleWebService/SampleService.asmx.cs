using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Services;
using SOA;

namespace SampleWebService
{
    /// <summary>
    /// Summary description for Sample WebService
    /// </summary>
    [WebService(Description = "SOAV Group hosted by SOA", Name = "Sample Method Collection's", Namespace = "https://www.w3schools.com/SOA/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SampleService : System.Web.Services.WebService
    {
        [WebMethod]       
        public Response MakeSimple()
        {            
            return new SOA.RequestCartesian().SayHello();
        }
        [WebMethod(MessageName = "MakeParametrized")]
        public Response MakeParametrized(string msg)
        {
            //"Single Param Supported"
            //"msg":"Success"
            //"Success"            
            return new SOA.RequestCartesian().SayHello(new Request { Status = 0, Message = (string.IsNullOrEmpty(msg) ? "" : msg) });
        }
        [WebMethod (MessageName ="MakeObject")]
        public Response MakeObject(Request req)
        {
            // Multiple params Supported
            // "message":"Multiplicity","status":"0"            
            return new SOA.RequestCartesian().SayHello(req);
        }
    }
}
