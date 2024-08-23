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
            if (command.StartsWith(LIST_COMMAND))
            {
                _commands.ListLines(lines);
            }
            else if (command.StartsWith(DELETE_COMMAND))
            {
                _commands.DeleteLine(command, lines);
            }
            else if (command.StartsWith(INSERT_COMMAND))
            {
                _commands.InsertLine(command, lines);
            }
            else if (command == SAVE_COMMAND)
            {
                _commands.SaveFile(filePath, lines);
            }
            else if (command != QUIT_COMMAND)
            {
                Console.WriteLine("Unknown command.");
            }
        }
    }
}
