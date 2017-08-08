﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Windows.Forms;

#endregion

namespace AmazonWebServiceClient
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.EnableRTLMirroring();
         Application.Run( new AmazonWebServiceClient() );
      }
   }
}