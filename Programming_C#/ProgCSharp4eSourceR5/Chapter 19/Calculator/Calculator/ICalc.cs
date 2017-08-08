#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Calculator
{
   public interface ICalc
   {
      double Add( double x, double y );
      double Sub( double x, double y );
      double Mult( double x, double y );
      double Div( double x, double y );
   }
}
