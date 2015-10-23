using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndStreamDemo
{
    public class FileModeAndFileAccess
    {
        public void FileModeFileAccessExample()
        {
            string path = Directory.GetCurrentDirectory();
            string totalPath = Path.Combine(path, "data.txt");
            using (FileStream fs = new FileStream(totalPath, FileMode.Create,
                                FileAccess.ReadWrite))
            {
                fs.WriteByte(100);
                fs.Position = 0;
                if (fs.CanRead)
                {
                    fs.ReadByte();
                }
            }
        }
    }
}
