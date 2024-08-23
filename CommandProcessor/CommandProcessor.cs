using LineTextEditor.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineTextEditor.CommandProcessor
{
    public class CommandProcessor : ICommandProcessor
    {
        private readonly ICommands _commands;
        private readonly string LIST_COMMAND = "list";
        private readonly string DELETE_COMMAND = "del ";
        private readonly string INSERT_COMMAND = "ins ";
        private readonly string SAVE_COMMAND = "save";
        private readonly string QUIT_COMMAND = "quit";
        public CommandProcessor(ICommands commands)
        {
            _commands = commands;
        }
        public void ProcessCommand(string command, string filePath, List<string> lines)
        {
            switch (command)
            {
                case string comm when comm.StartsWith(LIST_COMMAND):
                    _commands.ListLines(lines);
                    break;
                case string comm when comm.StartsWith(DELETE_COMMAND):
                    _commands.DeleteLine(command, lines);
                    break;
                case string comm when comm.StartsWith(INSERT_COMMAND):
                    _commands.InsertLine(command, lines);
                    break;
                case string comm when comm == SAVE_COMMAND:
                    _commands.SaveFile(filePath, lines);
                    break;
                case string comm when comm == QUIT_COMMAND:
                    break;
                default:
                    Console.WriteLine("Unknown command.");
                    break;
            }
        }
    }
}
