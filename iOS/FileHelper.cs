using System;
using Xamarin.Forms;
using TestAppXamarin1.Data;
using System.IO;
using TestAppXamarin1.iOS;

[assembly: Dependency(typeof(FileHelper))]
namespace TestAppXamarin1.iOS
{
    
    public class FileHelper: IFileHelper
    {
        public FileHelper()
        {
            
        }

        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }

            return Path.Combine(libFolder, filename);
        }
    }
}
