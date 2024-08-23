using LineTextEditor.CommandProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineTextEditor
{
    public class LineEditor
    {
        static List<string> lines = new List<string>();
        static string filePath = @"C:\My Files\Exercises\DevFiles\LineEditorFolder\TestText.txt";
        private readonly string QUIT_COMMAND = "quit";
        private readonly ICommandProcessor _commandProcessor;

        public LineEditor(ICommandProcessor commandProcessor)
        {
            _commandProcessor = commandProcessor;
        }
        public void Run()
        {
            if (File.Exists(filePath))
            {
                lines.AddRange(File.ReadAllLines(filePath));
            }
            else
            {
                Console.WriteLine("File not found.");
                return;
            }

            string command;
            do
            {
                Console.Write(">> ");
                command = Console.ReadLine();
                _commandProcessor.ProcessCommand(command, filePath, lines);
            } while (command != QUIT_COMMAND);
        }
    }
}
