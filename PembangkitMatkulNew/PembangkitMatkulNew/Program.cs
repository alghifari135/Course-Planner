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
            BFS bfs = new BFS();
            bfs.BacaFile("filesimpul.txt");
        }
    }
}
