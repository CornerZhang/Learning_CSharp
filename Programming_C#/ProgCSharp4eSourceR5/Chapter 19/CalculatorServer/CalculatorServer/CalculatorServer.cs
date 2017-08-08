#region Using directives

using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;

#endregion

namespace CalculatorServerNS
{
   class CalculatorServer : MarshalByRefObject, Calculator.ICalc
   {
      public CalculatorServer()
      {
         Console.WriteLine( "CalculatorServer constructor" );
      }
      // implement the four functions
      public double Add( double x, double y )
      {
         Console.WriteLine( "Add {0} + {1}", x, y );
         return x + y;
      }
      public double Sub( double x, double y )
      {
         Console.WriteLine( "Sub {0} - {1}", x, y );
         return x - y;
      }
      public double Mult( double x, double y )
      {
         Console.WriteLine( "Mult {0} * {1}", x, y );
         return x * y;
      }
      public double Div( double x, double y )
      {
         Console.WriteLine( "Div {0} / {1}", x, y );
         return x / y;
      }
   }

   public class ServerTest
   {
      public static void Main()
      {
         // create a channel and register it
         HttpChannel chan = new HttpChannel( 65100 );
         ChannelServices.RegisterChannel( chan );

//         Option 1
//         Type calcType =
//            Type.GetType( "CalculatorServerNS.CalculatorServer" );
//         RemotingConfiguration.RegisterWellKnownServiceType
//            ( calcType,
//              "theEndPoint",
//               WellKnownObjectMode.Singleton );


//          Option 2 (comment out options 1 and 3)
//         Type calcType =
//            Type.GetType( "CalculatorServerNS.CalculatorServer" );
//         RemotingConfiguration.RegisterWellKnownServiceType
//            ( calcType,
//              "theEndPoint",
//               WellKnownObjectMode.SingleCall );



//         Option 3 (comment out options 1 and 2)
//         CalculatorServerNS.CalculatorServer  calculator = new CalculatorServer();
//         RemotingServices.Marshal( calculator, "theEndPoint" );


         //  "They also serve who only stand and wait."); (Milton)
         Console.WriteLine( "Press [enter] to exit..." );
         Console.ReadLine();


         //  "They also serve who only stand and wait."); (Milton)
         Console.WriteLine( "Press [enter] to exit..." );
         Console.ReadLine();
      }
   }
}

