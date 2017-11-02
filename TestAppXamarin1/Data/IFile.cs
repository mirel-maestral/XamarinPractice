using System;
namespace TestAppXamarin1.Data
{
    public interface IFile
    {
        void SaveText(string filename, string text);
        string LoadText(string filename);
        string ClearFile(string filename);
        bool FileExists(string filename);
    }
}
