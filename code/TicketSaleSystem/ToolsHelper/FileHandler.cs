using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsHelper
{
    public static class FileHandler
    {
        public static void CheckDir(string path)
        {
            path = path.Substring(0, path.LastIndexOf('\\'));
            string[] dirNameArr = path.Split(new string[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
            string[] allPath = GetAllPath(dirNameArr);
            foreach (string item in allPath)
            {
                CreateDir(item);
            }
        }

        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="path"></param>
        private static void CreateDir(string path)
        {
            try
            {
                if (!Directory.Exists(path) && path.Length > 2)
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ex)
            {
                LogFile.WriteLine(String.Format("path:{0}------{1}", path, ex));
            }
        }

        /// <summary>
        /// 换行追加写入
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool WriteAppend(string filepath, string content)
        {
            CheckDir(filepath);
            try
            {
                StreamWriter streamWriter = File.AppendText(filepath);
                streamWriter.WriteLine(content);
                streamWriter.Flush();
                streamWriter.Close();
                return true;
            }
            catch (Exception ex)
            {
                LogFile.WriteLine(ex.ToString());
                return false;
            }

        }

        private static string[] GetAllPath(string[] dirNameArr)
        {
            string[] retArr = new string[dirNameArr.Length];
            int i = 0;
            foreach (string item in dirNameArr)
            {
                if (i == 0)
                {
                    retArr[i] = item;
                }
                else
                {
                    retArr[i] = String.Format("{0}\\{1}", retArr[i - 1], item);
                }
                i++;
            }
            return retArr;
        }
    }
}
