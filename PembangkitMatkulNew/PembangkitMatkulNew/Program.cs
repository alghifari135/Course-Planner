using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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

            //create a form 
            Form form = new Form();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            foreach(SimpulBFS simpul in BFS.DaftarTerurutBFS)
            {
                foreach(string tetangga in simpul.Tetangga)
                {
                    graph.AddEdge(simpul.Nama, tetangga);
                }
            }
            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();
        }
    
    }
}