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
            dfs.CetakHasilDFS();
            /*
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            
            foreach (SimpulBFS simpul in BFS.DaftarTerurutBFS)
            {
                foreach (string tetangga in simpul.Tetangga)
                {
                    graph.AddEdge(simpul.Nama, tetangga);
                }
            }
            
            Microsoft.Msagl.GraphViewerGdi.GraphRenderer renderer
            = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer
            (graph);
            renderer.CalculateLayout();
            int width = 50;
            Bitmap bitmap = new Bitmap(width, (int)(graph.Height *
            (width / graph.Width)), PixelFormat.Format32bppPArgb);
            renderer.Render(bitmap);
            bitmap.Save("test2.png");
            */
        }
    
    }
}