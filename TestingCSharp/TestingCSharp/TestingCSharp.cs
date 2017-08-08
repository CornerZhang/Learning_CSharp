using System;
using So = TestingCSharp.Mee.Lee.So;    // alias of namespace


namespace TestingCSharp
{
    using CmdSys = CommandSystem;

    class TestingCSharp
    {

        protected static CommandSystem commandSystem = null;

        public static void TestingRenderSystem() {

            RenderSystem renderSystem = RenderSystem.only;
            // ...
            if( renderSystem.BeginContent() ) {
                // ...
                renderSystem.EndContent();
            }
        }

        public static void Testing_Any() {
            int value = 32;
            object anyObject = value;
            int valueOther = Convert.ToInt32(anyObject);
            ++valueOther;
        }

        public static void Testing_CommandSystem() {
            commandSystem.RegisterCommand(CommandAllDefine.MainMenu_Loading, CommandAllDefine.Event_MainMenu_Loading);

            // ...

            CommandArguments args = new CommandArguments(23);
            commandSystem.RunCommand(CommandAllDefine.MainMenu_Loading, args);
            commandSystem.RunCommand(CommandAllDefine.MainMenu_Loading, new CommandArguments(264));


            // ...

            commandSystem.UnregisterAllCommand();
        }

        public So.Mixer mx = new So.Mixer();
        protected Mee.Lee.So.Mixer mxFar = new Mee.Lee.So.Mixer();


        public static void Main(string[] args) {
            Testing_Any();

            commandSystem = CommandSystem.only;
            Testing_CommandSystem();

            int c = Utility.Add(3, 8);
            c += 3;

        }

    }
}
