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
            BFS bfs = new BFS();
            //dfs.HitungSisiMasuk();
            dfs.DFSMain();
            bfs.MulaiBFS();
            foreach (KeyValuePair<string, SimpulDFS> pair in SimpulDFS.KumpulanSimpul)
            {
                Console.WriteLine("{0}, {1}, {2}", pair.Key, SimpulDFS.KumpulanSimpul[pair.Key].Mulai, SimpulDFS.KumpulanSimpul[pair.Key].Selesai);
            }
            Console.WriteLine("Urutan BFS :");
            int i = 1;
            foreach (SimpulBFS simpul in BFS.DaftarTerurutBFS)
            {
                Console.WriteLine("{0}. {1}", i, simpul.Nama);
                i++;
            }
        }
    }
}
