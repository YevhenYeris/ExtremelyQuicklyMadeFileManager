using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace ExtremelyQuicklyMadeFileManager
{
    class PathManager
    {
        public string GetNewFileName(string path, string ext)
        {
            string name = "\\NewFile";
            string res = name;
            int num = 0;
            while (true)
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                var list = new List<FileInfo>(dir.GetFiles("*" + ext, SearchOption.TopDirectoryOnly));
                res = path + name + "(" + num.ToString() + ")" + ext;
                if (File.Exists(res))
                {
                    ++num;
                }
                else
                {
                    break;
                }
            }
            return res;
        }

        public string GetNewFileName(string path, string ext, string name)
        {
            string temp = "";
            foreach (var i in name)
            {
                if (i == '.')
                    break;
                temp += i;
            }
            name = @"\" + temp;
            string res = name;
            int num = 0;
            while (true)
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                var list = new List<FileInfo>(dir.GetFiles("*" + ext, SearchOption.TopDirectoryOnly));
                res = path + name + "(" + num.ToString() + ")" + ext;
                if (File.Exists(res))
                {
                    ++num;
                }
                else
                {
                    break;
                }
            }
            return res;
        }

        public string GetNewDirectoryName(string path)
        {
            string name = "\\NewFolder";
            string res = name;
            int num = 0;
            while (true)
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                var list = new List<DirectoryInfo>(dir.GetDirectories());
                res = path + name + "(" + num.ToString() + ")";
                if (Directory.Exists(res))
                {
                    ++num;
                }
                else
                {
                    break;
                }
            }
            return res;
        }

        public string GetNewDirectoryName(string path, string name)
        {
            string res = @"\" + name;
            name = @"\" + name;
            int num = 0;
            while (true)
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                var list = new List<DirectoryInfo>(dir.GetDirectories());
                res = path + name + "(" + num.ToString() + ")";
                if (Directory.Exists(res))
                {
                    ++num;
                }
                else
                {
                    break;
                }
            }
            return res;
        }

        public string ShortenPath(string path)
        {
            string res = path;
            DirectoryInfo dir = new DirectoryInfo(path);
            if (dir.Parent != null)
                res = dir.Parent.FullName;
            return res;
        }
    }
}
