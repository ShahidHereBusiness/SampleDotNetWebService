using System;
using SOAV;
using static SOAV.Enumeration;

namespace SOA
{
    public class RequestCartesian
    {
        /// <summary>
        /// Sample Say Hello
        /// </summary>
        /// <returns>Response Object</returns>
        public Response SayHello(Request req = null)
        {
            try
            {
                if (req == null)
                    req = new Request { Status = -6 };
                else if (!Enum.IsDefined(typeof(ResponseEnum), req.Status))
                    req.Status = -6;
                else if (req.Status == 0)
                    return new Response { Error = false };
            }
            catch {
                req.Status = 1;
            }
            finally
            {
                // Diminish Here
            }
            //Make Response
            return new Response
            {
                Error = true,
                Data = new ErrorData
                {
                    Code = (int)((ResponseEnum)req.Status),
                    Detail = ((ResponseEnum)req.Status).ToString()
                }
            };
        }
    }
}