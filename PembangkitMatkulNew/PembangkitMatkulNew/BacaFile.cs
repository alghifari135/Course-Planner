using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembangkitMatkulNew
{
    class BacaFile
    {
        public BacaFile(string fileName)
        {
            string[] kumpulanBaris = File.ReadAllLines(fileName);
            string[] simpulFile;
            foreach (string baris in kumpulanBaris)
            {
                simpulFile = baris.Split(new char[] { ',', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                SimpulBFS.HashBFS.Add(simpulFile[0], new SimpulBFS(simpulFile[0]));
                for (int i = 1; i < simpulFile.Length; i++)
                {
                    SimpulBFS.HashBFS[simpulFile[0]].TambahTetangga(simpulFile[i]);
                }
            }
        }
    }
}
