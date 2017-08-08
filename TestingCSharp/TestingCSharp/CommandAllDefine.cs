using System;
using TestingCSharp;

namespace TestingCSharp
{
    public class CommandAllDefine
    {
        public static string MainMenu_Loading = "MainMenu_Loading";
        public static string MainMenu_Unload = "MainMenu_Unload";

        public static void Event_MainMenu_Loading(CommandArguments args) {
            
        }

        // disable create instance
        private CommandAllDefine() {
        }
    }
}

