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
        static private List<SimpulBFS> daftarTerurutBFS = new List<SimpulBFS>();
        static public List<SimpulBFS> DaftarTerurutBFS
        {
            get
            {
                return daftarTerurutBFS;
            }
            set
            {
                daftarTerurutBFS = value;
            }
        }
        
        public void MulaiBFS()
        {
            
            for (int i = 1; i <= SimpulBFS.DaftarSimpul.Count; i++)
            {
                foreach (KeyValuePair<string, SimpulBFS> pair in SimpulBFS.DaftarSimpul)
                {
                    if (SimpulBFS.DaftarSimpul[pair.Key].TetanggaMasuk == 0)
                    {
                        TambahUrutan(SimpulBFS.DaftarSimpul[pair.Key]);
                        SimpulBFS.DaftarSimpul[pair.Key].TetanggaMasuk--;
                        break;
                    }
                }
            }
            
        }

        private void TambahUrutan (SimpulBFS S)
        {
            DaftarTerurutBFS.Add(S);
            foreach(string key in S.Tetangga)
            {
                SimpulBFS.DaftarSimpul[key].TetanggaMasuk--;
            }
        }
    }
}
