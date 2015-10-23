using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileAndStreamDemo
{
    public class FileshareDemo
    {
        public void FileShareExample()
        {
         string path = Directory.GetCurrentDirectory();
        string totalPath = Path.Combine(path, "data.txt");
            using (FileStream fs1 = new FileStream(@"\data.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (FileStream fs2 = new FileStream(@"\data.txt", FileMode.Open, FileAccess.Write) { }) ;

            }

    }
}
}
