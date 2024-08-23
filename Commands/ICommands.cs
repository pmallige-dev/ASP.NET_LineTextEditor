using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineTextEditor.Commands
{
    public interface ICommands
    {
        void ListLines(List<string> lines);
        void DeleteLine(string command, List<string> lines);
        void InsertLine(string command, List<string> lines);
        void SaveFile(string filePath, List<string> lines);
    }
}
