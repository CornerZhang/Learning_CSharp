using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{

   [WebMethod]
   public double Add( double x, double y )
   {
      return x + y;
   }

   [WebMethod]
   public double Sub( double x, double y )
   {
      return x - y;
   }
   [WebMethod]
   public double Mult( double x, double y )
   {
      return x * y;
   }
   [WebMethod]
   public double Div( double x, double y )
   {
      return x / y;
   }
   [WebMethod]
   public double Pow( double x, double y )
   {
      double retVal = x;
      for ( int i = 0; i < y - 1; i++ )
      {
         retVal *= x;
      }
      return retVal;
   }
    
}
