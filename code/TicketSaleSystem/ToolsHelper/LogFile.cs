using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ToolsHelper
{
    public static class LogFile
    {
        private static System.Text.Encoding encoding = System.Text.Encoding.Default;
        private static object sysObject = new object();
        private static DateTime createFileTime = DateTime.Now;
        private static string logFilePath = string.Empty;
        private static string path = ConfigurationSettings.AppSettings["LogFileName"];

        static LogFile()
        {
            if (string.IsNullOrEmpty(path))
            {
                path = @"C:\Log\LogFile.txt";
            }
            logFilePath = GetCurFileName(path);
        }

        public static string GetCurFileName(string FileName)
        {
            string fileName = String.Format("{0}_{1:yyyy-MM-dd}", FileName, DateTime.Now);
            fileName += ".log";
            return fileName;
        }

        public static void WriteLine(string msg)
        {
            string strData = System.DateTime.Now.ToString() + "	" + msg;
            try
            {
                CreateFile();
                FileHandler.WriteAppend(logFilePath, strData);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        private static void CreateFile()
        {
            lock (sysObject)
            {
                if (createFileTime.Day != DateTime.Now.Day)
                {
                    logFilePath = GetCurFileName(path);
                    FileHandler.CheckDir(logFilePath);
                    if (!File.Exists(logFilePath))
                    {
                        FileStream fs = File.Create(logFilePath);
                        fs.Close();
                        createFileTime = DateTime.Now;
                    }
                }
            }
        }
    }
}
