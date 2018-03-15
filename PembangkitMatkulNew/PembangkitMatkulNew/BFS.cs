using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembangkitMatkulNew
{
    class BFS
    {
        public void MulaiBFS()
        {
            foreach (KeyValuePair<string, SimpulBFS> S in SimpulBFS.DaftarSimpul)
            {
                foreach(string T in SimpulBFS.DaftarSimpul[S.Key].Tetangga)
                {
                    SimpulBFS.DaftarSimpul[T].TetanggaMasuk++;
                }
            }


        }
    }
}
