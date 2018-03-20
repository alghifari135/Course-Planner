using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembangkitMatkulNew
{
    class SimpulDFS
    {
        static public int waktu = 0;
        static public Dictionary<string, SimpulDFS> kumpulanSimpul = new Dictionary<string, SimpulDFS>();
        private List<string> tetangga;
        private string namaMatkul;
        private int mulai;
        private int selesai;
        private bool dikunjungi;
        private int sisiMasuk;
        public int SisiMasuk
        {
            get
            {
                return sisiMasuk;
            }
            set
            {
                sisiMasuk = value;
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
        public int Waktu
        {
            get
            {
                return waktu;
            }
            set
            {
                waktu = value;
            }
        }
        static public Dictionary<string, SimpulDFS> KumpulanSimpul
        {
            get
            {
                return kumpulanSimpul;
            }
            set
            {
                kumpulanSimpul = value;
            }
        }
        public SimpulDFS(string nama)
        {
            this.namaMatkul = nama;
            tetangga = new List<string>();
            dikunjungi = false;
            sisiMasuk = 0;
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
        public string NamaMatkul
        {
            get
            {
                return namaMatkul;
            }
            set
            {
                namaMatkul = value;
            }
        }
        public List<string> Tetangga
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
    }
}
