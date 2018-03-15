using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembangkitMatkulNew
{
    class DFS
    {
        public void DFSMain(SimpulDFS S)
        {
            foreach (KeyValuePair<string, SimpulDFS> pair in S.KumpulanSimpul)
            {
                if (S.KumpulanSimpul[pair.Key].SisiMasuk == 0 && S.KumpulanSimpul[pair.Key].Dikunjungi == false)
                {
                    DFSRekursif(S.KumpulanSimpul[pair.Key]);
                }
            }
        }
        public void DFSRekursif(SimpulDFS S)
        {
            S.Mulai = ++S.Waktu;
            for (int i = 0; i < S.Tetangga.Count; i++)
            {
                if (!S.KumpulanSimpul[S.Tetangga[i]].Dikunjungi)
                {

                    DFSRekursif(S.KumpulanSimpul[S.Tetangga[i]]);
                }
            }
            S.Selesai = ++S.Waktu;
            S.Dikunjungi = true;
        }
        public void HitungSisiMasuk(SimpulDFS S)
        {
            foreach (KeyValuePair<string, SimpulDFS> pair in S.KumpulanSimpul)
            {
                for (int i = 0; i < S.KumpulanSimpul[pair.Key].Tetangga.Count; i++)
                {
                    S.KumpulanSimpul[S.KumpulanSimpul[pair.Key].Tetangga[i]].SisiMasuk++;
                }
            }
        }
    }
}
