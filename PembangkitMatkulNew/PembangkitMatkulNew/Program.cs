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
            dfs.DFSMain();
            bfs.MulaiBFS();
            dfs.CetakHasilDFS();
            bfs.CetakHasilBFS();
        }
    }
}