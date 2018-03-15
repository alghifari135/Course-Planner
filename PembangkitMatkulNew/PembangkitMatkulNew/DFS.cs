using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembangkitMatkulNew
{
    class DFS
    {
        public void DFSMain()
        {
            foreach (KeyValuePair<string, SimpulDFS> pair in SimpulDFS.KumpulanSimpul)
            {
                if (SimpulDFS.KumpulanSimpul[pair.Key].SisiMasuk == 0 && SimpulDFS.KumpulanSimpul[pair.Key].Dikunjungi == false)
                {
                    DFSRekursif(SimpulDFS.KumpulanSimpul[pair.Key]);
                }
            }
        }
        public void DFSRekursif(SimpulDFS S)
        {
            S.Mulai = ++S.Waktu;
            for (int i = 0; i < S.Tetangga.Count; i++)
            {
                if (!SimpulDFS.KumpulanSimpul[S.Tetangga[i]].Dikunjungi)
                {

                    DFSRekursif(SimpulDFS.KumpulanSimpul[S.Tetangga[i]]);
                }
            }
            S.Selesai = ++S.Waktu;
            S.Dikunjungi = true;
        }
        public void HitungSisiMasuk()
        {
            foreach (KeyValuePair<string, SimpulDFS> pair in SimpulDFS.KumpulanSimpul)
            {
                for (int i = 0; i < SimpulDFS.KumpulanSimpul[pair.Key].Tetangga.Count; i++)
                {
                    SimpulDFS.KumpulanSimpul[SimpulDFS.KumpulanSimpul[pair.Key].Tetangga[i]].SisiMasuk++;
                }
            }
        }
    }
}
