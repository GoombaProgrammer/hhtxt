using MoonSharp.Interpreter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApplication1.MacroLib
{
    public class HHTXT
    {
        public void Exit()
        {
            Environment.Exit(0);
        }

        public void WriteText(string path, string data)
        {
            File.WriteAllText(path, data);
        }

        public void AppendText(string path, string data)
        {
            File.AppendAllText(path, data);
        }
        
        public string ReadText(string path)
        {
            return File.ReadAllText(path);
        }

        public void CreateFile(string path)
        {
            using(var str = File.Create(path))
            {
                // empty so str is disposed
            }
        }

        public void DeleteFile(string path)
        {
            File.Delete(path);
        }

        public void Mkdir(string path)
        {
            Directory.CreateDirectory(path);
        }

        public void Rmdir(string path, bool recursive = false)
        {
            Directory.Delete(path, recursive);
        }

        public string LocalAppDataPath => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public string DocumentsPath => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    }
}
