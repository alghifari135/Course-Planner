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
            DFS dfs = new DFS();
            dfs.HitungSisiMasuk(C1);
            dfs.DFSMain(C1);
            foreach (KeyValuePair<string, SimpulDFS> pair in C1.KumpulanSimpul)
            {
                Console.WriteLine("{0}, {1}, {2}", pair.Key, C1.KumpulanSimpul[pair.Key].Mulai, C1.KumpulanSimpul[pair.Key].Selesai);
            }
        }
    }
}
