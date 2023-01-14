using System.Collections.Generic;

namespace Core.Abstractions
{
    public interface IFileWriteRead
    {
        List<string> ReadFile(string path);
        bool WriteToFile(string path, List<string> data);
    
    }
}