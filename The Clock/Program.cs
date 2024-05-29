using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace The_Clock
{
    public class EntryPoint
    {
        
        [STAThread]
        public static void Main(string[] args)
        {
            string appdataclock = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}/ /";
            Random rnd = new Random();
            Directory.CreateDirectory(appdataclock);
            DirectoryInfo di = new DirectoryInfo(appdataclock);
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            while (true)
            {
                if (di.GetDirectories().Length == 0) { di.CreateSubdirectory("00꞉00 aa"); }
                Directory.Move(di.GetDirectories()[0].FullName, $"{appdataclock}{rnd.Next(0, 100):00} ꞉ {rnd.Next(0, 100):00}" +
                    $" {alpha[rnd.Next(0, alpha.Length)].ToString().ToLower()}" +
                    $"{alpha[rnd.Next(0, alpha.Length)].ToString().ToLower()}");
                Thread.Sleep(60000);
            }
        }
       
    }
}
