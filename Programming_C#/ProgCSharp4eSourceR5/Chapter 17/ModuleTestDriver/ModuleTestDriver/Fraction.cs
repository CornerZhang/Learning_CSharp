﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ProgCS
{
   public class Fraction
   {
      private int numerator;
      private int denominator;

      public Fraction( int numerator, int denominator )
      {
         this.numerator = numerator;
         this.denominator = denominator;
      }

      public Fraction Add( Fraction rhs )
      {
         if ( rhs.denominator != this.denominator )
         {
            throw new ArgumentException(
               "Denominators must match" );
         }

         return new Fraction(
             this.numerator + rhs.numerator,
                  this.denominator );
      }

      public override string ToString()
      {
         return numerator + "/" + denominator;
      }
   }

}
