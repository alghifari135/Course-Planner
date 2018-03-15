using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PembangkitMatkulNew
{
    class SimpulBFS
    {
        private string nama;
        private int tetanggaMasuk;
        private List<string> tetangga;
        static private Dictionary<string, SimpulBFS> daftarSimpul = new Dictionary<string, SimpulBFS>();

        public SimpulBFS(string nama)
        {
            this.nama = nama;
            this.tetangga = new List<string>();
            this.tetanggaMasuk = 0;
        }


        /// Getter + Setter
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

        public int TetanggaMasuk
        {
            get
            {
                return tetanggaMasuk;
            }
            set
            {
                tetanggaMasuk = value;
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

        static public Dictionary<string, SimpulBFS> DaftarSimpul
        {
            get
            {
                return daftarSimpul;
            }
            set
            {
                daftarSimpul = value;
            }
        }
    }
}
