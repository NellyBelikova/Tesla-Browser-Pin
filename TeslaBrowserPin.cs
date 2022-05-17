using System.Diagnostics;
using System.IO;


namespace TeslaPin
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.teslabrowser.com/";
            NavigateToTesla(url);
        }

        public static void NavigateToTesla(string url)
        {
            string pathTesla = @"C:\Program Files\TeslaBrowser\TeslaBrowser.exe";
            try
            {
                if (File.Exists(pathTesla)) Process.Start(pathTesla, url);
                else Process.Start(url);
            }
            catch
            {
                Process.Start(Path.Combine("microsoft-edge:", url));
            }
        }

    }
}