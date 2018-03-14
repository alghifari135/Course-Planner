using System;
using System.Collections.Generic;

namespace PembangkitMatkul
{
    public class SimpulDFS
    {
        private string nama;
        private int mulai;
        private int selesai;
        private List<Simpul> tetangga;
        private bool dikunjungi;

        public string Nama
        {
            get
            {
                return nama;
            }
            set
            {
                nama = value;
            }
        }

        public int Mulai
        {
            get
            {
                return mulai;
            }
            set
            {
                mulai = value;
            }
        }

        public int Selesai
        {
            get
            {
                return selesai;
            }
            set
            {
                selesai = value;
            }
        }

        public List<Simpul> Tetangga
        {
            get
            {
                return tetangga;
            }
            set
            {
                tetangga = value;
            }
        }

        public bool Dikunjungi
        {
            get
            {
                return dikunjungi;
            }
            set
            {
                dikunjungi = value;
            }
        }

        public SimpulDFS(string nama, int mulai, int selesai, List<SimpulDFS> tetangga, bool dikunjungi)
        {
            this.nama = nama;
            this.mulai = mulai;
            this.selesai = selesai;
            this.tetangga = tetangga;
            this.dikunjungi = dikunjungi;
        }
    }

    class DFS
    {
        private int waktu;
        //private int[] arr;

        private void KunjungiSimpul(SimpulDFS simpul)
        {
            waktu++;
            simpul.Mulai = waktu;
            if (simpul.Tetangga != null)
            {
                for (int i=0; i<simpul.Tetangga.Count; i++)
                {
                    SimpulDFS simpulTetangga = simpul.Tetangga[i];
                    if (simpulTetangga.Dikunjungi == false)
                    {
                        KunjungiSimpul(simpulTetangga);
                    }
                }
            }
            waktu++;
            simpul.Selesai = waktu;
        }
        public void mainDFS(List<SimpulDFS> simpul)
        {
            for (int i=0; i<simpul.Count; i++)
            {
                SimpulDFS S = simpul[i];
                S.Dikunjungi = false;
            }
            for (int i=0; i<simpul.Count; i++)
            {
                SimpulDFS S = simpul[i];
                if (S.dikunjungi==false)
                {
                    KunjungiSimpul(S);
                }
            }
        }
    }
}
