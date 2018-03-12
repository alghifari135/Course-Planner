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

        public string nama
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

        public int mulai
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

        public int selesai
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

        public List<Simpul> tetangga
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

        public bool dikunjungi
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

        public SimpulDFS(string nama, int mulai, int selesai, List<Simpul> tetangga, bool dikunjungi)
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
            simpul.mulai = waktu;
            if (simpul.tetangga != null)
            {
                for (int i=0; i<simpul.tetangga.Count; i++)
                {
                    SimpulDFS simpulTetangga = simpul.tetangga[i];
                    if (simpulTetangga.dikunjungi == false)
                    {
                        KunjungiSimpul(simpulTetangga);
                    }
                }
            }
            waktu++;
            selesai = waktu;
        }
        public void mainDFS(List<SimpulDFS> simpul)
        {
            for (int i=0; i<simpul.Count; i++)
            {
                SimpulDFS S = simpul[i];
                S.dikunjungi = false;
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
