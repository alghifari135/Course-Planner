using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace PembangkitMatkulNew
{
    class DFS
    {
        static private List<SimpulDFS> daftarTerurutDFS = new List<SimpulDFS>();
        static public List<SimpulDFS> DaftarTerurutDFS
        {
            get
            {
                return daftarTerurutDFS;
            }
            set
            {
                daftarTerurutDFS = value;
            }
        }
        public void DFSMain()
        /*Fungsi ini dapat dibilang merupakan fungsi main pada algoritma DFS. Fungsi ini akan memilih simpul2 yang jumlah sisi masuknya 0*/
        {
            foreach (KeyValuePair<string, SimpulDFS> pair in SimpulDFS.KumpulanSimpul)
            {
                if (SimpulDFS.KumpulanSimpul[pair.Key].SisiMasuk == 0 && SimpulDFS.KumpulanSimpul[pair.Key].Dikunjungi == false)
                {
                    DFSRekursif(SimpulDFS.KumpulanSimpul[pair.Key]);
                }
            }
            DaftarTerurutDFS.Reverse();
        }
        public void DFSRekursif(SimpulDFS S)
        /*Fungsi ini yang akan menelusuri simpul secara mendalam. Fungsi ini mencatat waktu mulai dan selesai suatu simpul. */
        {
            S.Mulai = ++S.Waktu;
            this.CetakLangkahDFS();
            for (int i = 0; i < S.Tetangga.Count; i++)
            {
                if (!SimpulDFS.KumpulanSimpul[S.Tetangga[i]].Dikunjungi)
                {
                    DFSRekursif(SimpulDFS.KumpulanSimpul[S.Tetangga[i]]);
                }
            }
            S.Selesai = ++S.Waktu;
            S.Semester = SimpulDFS.semesterX--;
            this.CetakLangkahDFS();
            S.Dikunjungi = true;
            DaftarTerurutDFS.Add(S);
        }
        public void CetakLangkahDFS()
        /*Fungsi ini dipanggil untuk memasukkan simpul ke dalam tipe data graph yang disediakan oleh kakas MSAGL, lalu mencetak graph yang telah dimasuki simpul baru tersebut. Fungsi ini memperlihatkan status mulai dan selesai tiap node*/
        {
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            foreach (KeyValuePair<string, SimpulDFS> pair in SimpulDFS.KumpulanSimpul)
            {
                foreach (string tetangga in SimpulDFS.KumpulanSimpul[pair.Key].Tetangga)
                {
                    graph.AddEdge(pair.Key + "\n m=" + SimpulDFS.KumpulanSimpul[pair.Key].Mulai + ", s=" + SimpulDFS.KumpulanSimpul[pair.Key].Selesai, tetangga + "\n m="+ SimpulDFS.KumpulanSimpul[tetangga].Mulai + ", s=" + SimpulDFS.KumpulanSimpul[tetangga].Selesai);
                }
            }
            
            Microsoft.Msagl.GraphViewerGdi.GraphRenderer renderer
            = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer
            (graph);
            renderer.CalculateLayout();
            int width = 2000;
            Bitmap bitmap = new Bitmap(width, (int)(graph.Height *
            (width / graph.Width)), PixelFormat.Format32bppPArgb);
            renderer.Render(bitmap);
            bitmap.Save("stateDFS"+ SimpulDFS.waktu + ".png");
        }
        public void CetakHasilDFS()
        /*Fungsi ini mencetak hasil akhir dari pengurutan matakuliah.*/
        {
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            foreach (SimpulDFS simpul in DaftarTerurutDFS)
            {
                foreach (string tetangga in simpul.Tetangga)
                {
                    graph.AddEdge("Semester "+ simpul.Semester + ": " + simpul.NamaMatkul, "Semester " + SimpulDFS.KumpulanSimpul[tetangga].Semester + ": " + tetangga);
                }
            }

            Microsoft.Msagl.GraphViewerGdi.GraphRenderer renderer
            = new Microsoft.Msagl.GraphViewerGdi.GraphRenderer
            (graph);
            renderer.CalculateLayout();
            int width = 2000;
            Bitmap bitmap = new Bitmap(width, (int)(graph.Height *
            (width / graph.Width)), PixelFormat.Format32bppPArgb);
            renderer.Render(bitmap);
            bitmap.Save("HasilDFS.png");
        }
    }
}
