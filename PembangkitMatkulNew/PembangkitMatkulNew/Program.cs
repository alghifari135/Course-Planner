using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembangkitMatkulNew
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpulDFS C1 = new SimpulDFS();
            C1.NamaMatkul = "C1";
            C1.Tetangga.Add("C2");
            C1.Tetangga.Add("C4");
            SimpulDFS C2 = new SimpulDFS();
            C2.NamaMatkul = "C2";
            C2.Tetangga.Add("C5");
            SimpulDFS C3 = new SimpulDFS();
            C3.NamaMatkul = "C3";
            C3.Tetangga.Add("C1");
            C3.Tetangga.Add("C4");
            SimpulDFS C4 = new SimpulDFS();
            C4.NamaMatkul = "C4";
            C4.Tetangga.Add("C2");
            C4.Tetangga.Add("C5");
            SimpulDFS C5 = new SimpulDFS();
            C5.NamaMatkul = "C5";
            C1.KumpulanSimpul.Add("C1",C1);
            C1.KumpulanSimpul.Add("C2", C2);
            C1.KumpulanSimpul.Add("C3", C3);
            C2.KumpulanSimpul.Add("C4", C4);
            C3.KumpulanSimpul.Add("C5", C5);
            DFS dfs = new DFS();
            foreach (KeyValuePair<string, SimpulDFS> pair in C1.KumpulanSimpul)
            {
                for (int i=0; i<C1.KumpulanSimpul[pair.Key].Tetangga.Count; i++)
                {
                    C1.KumpulanSimpul[C1.KumpulanSimpul[pair.Key].Tetangga[i]].SisiMasuk++;
                }       
            }
            foreach (KeyValuePair<string, SimpulDFS> pair in C1.KumpulanSimpul)
            {
                if (C1.KumpulanSimpul[pair.Key].SisiMasuk == 0) {
                    dfs.DFSM(C1.KumpulanSimpul[pair.Key]);
                }
            }
            foreach (KeyValuePair<string, SimpulDFS> pair in C1.KumpulanSimpul)
            {
                Console.WriteLine("{0}, {1}, {2}", pair.Key, C1.KumpulanSimpul[pair.Key].Mulai, C1.KumpulanSimpul[pair.Key].Selesai);
            }
        }
    }
}
