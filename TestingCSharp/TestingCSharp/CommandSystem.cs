using System;
using System.Collections;
using System.Collections.Generic;

namespace TestingCSharp
{
    using NameToCommandMapper = Dictionary<string,CommandSystem.CommandDelegate>;

    public class CommandArguments
    {
        public CommandArguments() {}

        public CommandArguments(object firstArguemnt) {
            arguments.Add(firstArguemnt);
        }

        void Add(object argument) {
            arguments.Add(argument);
        }

        void Clear() {
            arguments.Clear();
        }
            
        private ArrayList arguments;
    }


    public class CommandSystem
    {

        public delegate void CommandDelegate(CommandArguments arguments);

        public static CommandSystem only = new CommandSystem();

        // ctor be called in the class
        private CommandSystem() {
            commandDelegates = new Dictionary<string, CommandDelegate>();
        }

        public bool RegisterCommand(string commandName, CommandDelegate delegateObject ) {
            // get list of handle by name
            CommandDelegate foundCommandDelegate = null;


            bool bFound = commandDelegates.TryGetValue(commandName, out foundCommandDelegate);

            if (bFound==false || (foundCommandDelegate == null))
            {
                foundCommandDelegate += delegateObject;

                // save to dict
                commandDelegates[commandName] = foundCommandDelegate;
            }
            else
            {
                // assure one handle add only once, if it add yet, delete it first
                foundCommandDelegate -= delegateObject;
                // add it again, if it add yet, it is deleted yet, so this add action is "only once"
                foundCommandDelegate += delegateObject;

                // save to dict
                commandDelegates[commandName] = foundCommandDelegate;
            }

            return true;
        }

        public void UnregisterCommand(string commandName) {
            commandDelegates.Remove(commandName);
        }

        public void UnregisterDelegateFromCommand(string commandName, CommandDelegate delegateObject) {
            // get list of handle by name
            CommandDelegate foundCommandDelegate = null;
            bool bFound = commandDelegates.TryGetValue(commandName, out foundCommandDelegate);

            if (bFound && (foundCommandDelegate != null))
            {
                // remove it
                foundCommandDelegate -= delegateObject;

                // save to dict
                commandDelegates[commandName] = foundCommandDelegate;
            }
        }

        public void UnregisterAllCommand() {
            commandDelegates.Clear();
        }

        public void RunCommand(string commandName, CommandArguments arguments)
        {
            // get list of handle by name
            CommandDelegate foundCommandDelegate = null;
            bool bFound = commandDelegates.TryGetValue(commandName, out foundCommandDelegate);

            // execute all the handles
            if (bFound && (foundCommandDelegate != null))
            {
                foundCommandDelegate(arguments);
            } else {
                // error!!!
            }
        }

        private static NameToCommandMapper commandDelegates = null;
    }
}

