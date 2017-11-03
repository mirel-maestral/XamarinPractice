using System;
using System.IO;
using TestAppXamarin1.Data;
using TestAppXamarin1.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileImplementation))]
namespace TestAppXamarin1.Droid
{
    public class FileImplementation: IFile
    {
        public FileImplementation()
        {
        }

        public string ClearFile(string filename)
        {
            var documentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentPath, filename);
            File.Delete(filePath);
        }

        public bool FileExists(string filename)
        {
            var documentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentPath, filename);
            return File.Exists(filePath);
        }

        public string LoadText(string filename)
        {
            var documentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentPath, filename);
            return File.ReadAllText(filePath);
        }

        public void SaveText(string filename, string text)
        {
            var documentPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var filePath = Path.Combine(documentPath, filename);
            File.Delete(filePath);
            File.WriteAllText(filePath, text);

        }
    }
}
