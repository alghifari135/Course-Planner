using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace PembangkitMatkulNew
{
    class BFS
    {
        static public int state = 0;
        static private List<SimpulBFS> daftarTerurutBFS = new List<SimpulBFS>();
        static public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        static public List<SimpulBFS> DaftarTerurutBFS
        {
            get
            {
                return daftarTerurutBFS;
            }
            set
            {
                daftarTerurutBFS = value;
            }
        }
        
        public void MulaiBFS()
        {
            
            for (int i = 1; i <= SimpulBFS.DaftarSimpul.Count; i++)
            {
                foreach (KeyValuePair<string, SimpulBFS> pair in SimpulBFS.DaftarSimpul)
                {
                    if (SimpulBFS.DaftarSimpul[pair.Key].TetanggaMasuk == 0)
                    {
                        TambahUrutan(SimpulBFS.DaftarSimpul[pair.Key]);
                        SimpulBFS.DaftarSimpul[pair.Key].TetanggaMasuk--;
                        break;
                    }
                }
            }
            
        }

        private void TambahUrutan (SimpulBFS S)
        {
            DaftarTerurutBFS.Add(S);
            foreach(string key in S.Tetangga)
            {
                SimpulBFS.DaftarSimpul[key].TetanggaMasuk--;
            }
            this.CetakHasilBFS(State);
            State = State + 1 ;
        }

        public void CetakHasilBFS(int State)
        {
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
            bitmap.Save("state"+ state +".png");
        }
    }
}