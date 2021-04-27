using CommandSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialPlugin_EXILED.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class Deny : ICommand
    {
        public string Command { get; } = "deny";

        public string[] Aliases { get; } = { };

        public string Description { get; } = "A command that is denied";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            response = "The Command was not a success!";
            return false;
        }
    }
}
