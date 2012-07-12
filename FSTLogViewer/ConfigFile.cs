using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;

namespace FSTLogViewer
{
    public class ConfigFile
    {
        readonly string _pathConfig = Path.Combine(Environment.CurrentDirectory, "config.txt");

        public string LogsPath { get; set; }
        public int RefreshTime { get; set; }

        public void ReadConfigFile()
        {
            if (File.Exists(_pathConfig))
            {
                var sr = new StreamReader(_pathConfig);
                LogsPath = sr.ReadLine();
                RefreshTime = int.Parse(sr.ReadLine());
                sr.Close();
            }
            else
            {
                WriteConfigFile();
            }
        }

        public void WriteConfigFile()
        {
                var sw = new StreamWriter(_pathConfig); 
                sw.WriteLine(LogsPath);
                sw.WriteLine(RefreshTime.ToString(CultureInfo.InvariantCulture));
                sw.Flush();
                sw.Close();
        }
    }
}
