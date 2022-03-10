using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302200010
{
    class KodePos
    {
        public static int getKodePos(string k)
        {
            string[] kelurahan = { "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura", "Jatisari",
                "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja" };
            int[] kode = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            int jumlahKelurahan = kelurahan.Length - 1;
            int hasil = 0;
            int i = 0;
            while (i < jumlahKelurahan)
            {
                if (k == kelurahan[i])
                {
                    hasil = kode[i];
                }
                i++;
            }
            return hasil;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan Nama Kelurahan   : ");
            string kalurahan = Console.ReadLine();
            Console.Write("Kode Pos                 : ");
            Console.WriteLine(KodePos.getKodePos(kalurahan));

            Console.ReadKey();
        }
        
    }
}
