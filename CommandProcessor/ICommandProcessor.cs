namespace LineTextEditor.CommandProcessor
{
    public interface ICommandProcessor
    {
        void ProcessCommand(string command, string filePath, List<string> lines);
    }
}
