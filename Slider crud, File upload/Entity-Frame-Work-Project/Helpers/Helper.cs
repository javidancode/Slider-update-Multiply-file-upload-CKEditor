﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Frame_Work_Project.Helpers
{
    public static class Helper
    {
        public static bool CheckFileType(this IFormFile file, string type)
        {
            return file.ContentType.Contains(type);
        }

        public static bool CheckFileSize(this IFormFile file, long size)
        {
            return (file.Length / 1024) < size;
        }

        public static string GetFilePath(string root, string folder, string fileName)
        {
            return Path.Combine(root, folder, fileName);
        }

        public static void SliderImgDelete(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }
    }
}
