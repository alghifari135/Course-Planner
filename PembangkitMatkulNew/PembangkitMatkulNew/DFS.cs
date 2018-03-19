using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembangkitMatkulNew
{
    class DFS
    {
        static private List<SimpulDFS> daftarTerurutDFS = new List<SimpulDFS>();
        static public List<SimpulDFS> DaftarTerurutDFS
        {
            get
            {
                return daftarTerurutDFS;
            }
            set
            {
                daftarTerurutDFS = value;
            }
        }
        public void DFSMain()
        {
            foreach (KeyValuePair<string, SimpulDFS> pair in SimpulDFS.KumpulanSimpul)
            {
                if (SimpulDFS.KumpulanSimpul[pair.Key].SisiMasuk == 0 && SimpulDFS.KumpulanSimpul[pair.Key].Dikunjungi == false)
                {
                    DFSRekursif(SimpulDFS.KumpulanSimpul[pair.Key]);
                }
            }
            DaftarTerurutDFS.Reverse();
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
            DaftarTerurutDFS.Add(S);
        }
        public void CetakHasilDFS()
        {
            Console.WriteLine("Urutan DFS : ");
            for (int i=0; i<DaftarTerurutDFS.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, DaftarTerurutDFS[i].NamaMatkul);
            }
        }   
    }
}
