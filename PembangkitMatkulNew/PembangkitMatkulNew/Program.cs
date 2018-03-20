using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

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
            
        }
    
    }
}