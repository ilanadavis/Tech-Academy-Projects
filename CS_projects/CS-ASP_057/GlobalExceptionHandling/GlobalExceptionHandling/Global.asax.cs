using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace GlobalExceptionHandling
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {

        }

        void Application_Error (object sender, EventArgs e)
        {
            //What just happened?
            Exception ex = Server.GetLastError();

            //ex will be of type HttpUnhandledException
            //To get to the exception that CAUSED that to happen
            //you'll need to look at ex.InnerException
            var innerException = ex.InnerException;

            //Handle a specific type of error differently.
            if (innerException.GetType() == typeof(ArgumentOutOfRangeException))
            {
                Server.Transfer("Error.aspx"); 
            }

            Response.Write("<h2>Something bad happened...</h2>");
            Response.Write("<p>" + innerException.Message + "</p>");


            //Don't forget to clear errors to avoid the yellow page of death
            Server.ClearError();
        }
    }
}