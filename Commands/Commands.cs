namespace LineTextEditor.Commands
{
    public class Commands : ICommands
    {
        public void DeleteLine(string command, List<string> lines)
        {
            if (int.TryParse(command.Substring(4), out int lineNumber) && lineNumber > 0 && lineNumber <= lines.Count)
            {
                lines.RemoveAt(lineNumber - 1);
            }
            else
            {
                Console.WriteLine("Invalid line number.");
            }
        }

        public void InsertLine(string command, List<string> lines)
        {
            string[] parts = command.Split(new[] { ' ' }, 3);
            if (parts.Length == 3 && int.TryParse(parts[1], out int lineNumber) && lineNumber > 0 && lineNumber <= lines.Count + 1)
            {
                lines.Insert(lineNumber - 1, parts[2]);
            }
            else
            {
                Console.WriteLine("Invalid command or line number.");
            }
        }

        public void ListLines(List<string> lines)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {lines[i]}");
            }
        }

        public void SaveFile(string filepath, List<string> lines)
        {
            File.WriteAllLines(filepath, lines);
            Console.WriteLine("File saved.");
        }
    }
}
