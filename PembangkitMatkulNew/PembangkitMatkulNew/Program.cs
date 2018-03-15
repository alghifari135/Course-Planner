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
            BacaFile BF = new BacaFile("filesimpul.txt");
            DFS dfs = new DFS();
            dfs.HitungSisiMasuk();
            dfs.DFSMain();
            foreach (KeyValuePair<string, SimpulDFS> pair in SimpulDFS.KumpulanSimpul)
            {
                Console.WriteLine("{0}, {1}, {2}", pair.Key, SimpulDFS.KumpulanSimpul[pair.Key].Mulai, SimpulDFS.KumpulanSimpul[pair.Key].Selesai);
            }
        }
    }
}
