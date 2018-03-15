using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembangkitMatkulNew
{
    class DFS
    {
        public void DFSM(SimpulDFS S)
        {
            Console.WriteLine("Masuk Ke Simpul {0}", S.NamaMatkul);
            S.Mulai = ++S.Waktu;
            Console.WriteLine("Set mulai dari {0} menjadi {1}", S.NamaMatkul, S.Mulai);
            for (int i = 0; i < S.Tetangga.Count; i++)
            {
                Console.WriteLine("Cek tetangga {0} dikunjungi : {1}", S.Tetangga[i], S.KumpulanSimpul[S.Tetangga[i]].Dikunjungi);
                if (!S.KumpulanSimpul[S.Tetangga[i]].Dikunjungi)
                {

                    DFSM(S.KumpulanSimpul[S.Tetangga[i]]);
                }
            }
            S.Selesai = ++S.Waktu;
            Console.WriteLine("Set selesai dari {0} menjadi {1}", S.NamaMatkul, S.Selesai);
            S.Dikunjungi = true;
        }
    }
}
