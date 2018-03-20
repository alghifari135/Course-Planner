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

                if (!SimpulBFS.DaftarSimpul.ContainsKey(simpulFile[0]))
                {
                    SimpulBFS.DaftarSimpul.Add(simpulFile[0], new SimpulBFS(simpulFile[0]));
                }
                SimpulBFS.DaftarSimpul[simpulFile[0]].TetanggaMasuk = simpulFile.Length - 1;
                if (!SimpulDFS.KumpulanSimpul.ContainsKey(simpulFile[0]))
                {
                    SimpulDFS.KumpulanSimpul.Add(simpulFile[0], new SimpulDFS(simpulFile[0]));
                }
                SimpulDFS.KumpulanSimpul[simpulFile[0]].SisiMasuk = simpulFile.Length - 1;
                for (int i = 1; i < simpulFile.Length; i++)
                {
                    if (!SimpulBFS.DaftarSimpul.ContainsKey(simpulFile[i]))
                    {
                        SimpulBFS.DaftarSimpul.Add(simpulFile[i], new SimpulBFS(simpulFile[i]));
                    }
                    SimpulBFS.DaftarSimpul[simpulFile[i]].Tetangga.Add(simpulFile[0]);

                    if (!SimpulDFS.KumpulanSimpul.ContainsKey(simpulFile[i]))
                    {
                        SimpulDFS.KumpulanSimpul.Add(simpulFile[i], new SimpulDFS(simpulFile[i]));
                    }
                    SimpulDFS.KumpulanSimpul[simpulFile[i]].Tetangga.Add(simpulFile[0]);
                }
            }
            SimpulDFS.semesterX = SimpulDFS.KumpulanSimpul.Count;
        }
    }
}