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
        static private List<List<SimpulBFS>> daftarTerurutBFS = new List<List<SimpulBFS>>();
        static private Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
        static public Microsoft.Msagl.Drawing.Graph Graph
        {
            get
            {
                return graph;
            }
            set
            {
                graph = value;
            }
        }
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
        static public List<List<SimpulBFS>> DaftarTerurutBFS
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
            List<SimpulBFS> DaftarMatkulSemester = new List<SimpulBFS>();
            int i = 1;
            while (AdaSimpulTerakar())
            {
                DaftarMatkulSemester = new List<SimpulBFS>();
                foreach (KeyValuePair<string, SimpulBFS> pair in SimpulBFS.DaftarSimpul)
                {
                    if (SimpulBFS.DaftarSimpul[pair.Key].TetanggaMasuk == 0)
                    {
                        DaftarMatkulSemester.Add(SimpulBFS.DaftarSimpul[pair.Key]);
                        if (i == 1)
                        {
                            graph.AddNode(SimpulBFS.DaftarSimpul[pair.Key].Nama);
                            CetakGambar();
                        }
                    }
                }
                DaftarTerurutBFS.Add(DaftarMatkulSemester);
                foreach (SimpulBFS simpul in DaftarMatkulSemester)
                {
                    CoretSimpul(simpul);
                }
                i++;
            }

            i = 1;
            foreach (List<SimpulBFS> daftarSimpul in DaftarTerurutBFS)
            {
                foreach(SimpulBFS S in daftarSimpul)
                {
                    Cetak(S);
                }
                i++;
            }
        }

        private bool AdaSimpulTerakar()
        {
            bool hasil = false;
            foreach (KeyValuePair<string, SimpulBFS> pair in SimpulBFS.DaftarSimpul)
            {
                if (SimpulBFS.DaftarSimpul[pair.Key].TetanggaMasuk == 0) {
                    hasil = true;
                    break;
                }
            }
            return hasil;
        }

        private void CoretSimpul (SimpulBFS S)
        {
            SimpulBFS.DaftarSimpul[S.Nama].TetanggaMasuk--;
            foreach(string key in S.Tetangga)
            {
                SimpulBFS.DaftarSimpul[key].TetanggaMasuk--;
            }
        }

        private void Cetak (SimpulBFS S)
        {
            int i = 0;
            foreach (KeyValuePair<string, SimpulBFS> pair in SimpulBFS.DaftarSimpul)
            {
                foreach (string tetangga in SimpulBFS.DaftarSimpul[pair.Key].Tetangga)
                {
                    if (tetangga == S.Nama)
                    {
                        graph.AddEdge(pair.Key, S.Nama);
                        i++;
                    }
                }
            }
            if (i > 0)
            {
                CetakGambar();
            }
        }

        public void CetakGambar()
        {
            
            Microsoft.Msagl.GraphViewerGdi.GraphRenderer renderer
            = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer
            (graph);
            renderer.CalculateLayout();
            int width = 200;
            Bitmap bitmap = new Bitmap(width, (int)(graph.Height *
            (width / graph.Width)), PixelFormat.Format32bppPArgb);
            renderer.Render(bitmap);
            bitmap.Save("state"+ state +".png");
            State++;
        }
    }
}