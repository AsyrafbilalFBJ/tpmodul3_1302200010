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
    enum State {Terkunci, Terbuka, Keluar };
    class DoorMachine
    {
        public static void doorMachine()
        {
            State state = State.Terkunci;
            string[] screenName = { "Terkunci", "Terbuka", "Keluar"};
            while (state != State.Keluar)
            {
                Console.WriteLine("Pintu " + screenName[(int)state]);
                Console.Write("Enter Command : ");
                string command = Console.ReadLine();
                switch (state)
                {
                    case State.Terkunci:
                        if (command == "Kunci Pintu")
                            state = State.Terkunci;
                        else if (command == "Buka Pintu")
                            state = State.Terbuka;
                        else if (command == "Keluar")
                            state = State.Keluar;
                        else
                            state = State.Terkunci;
                        break;
                    case State.Terbuka:
                        if (command == "Buka Pintu")
                            state = State.Terbuka;
                        else if (command == "Kunci Pintu")
                            state = State.Terkunci;
                        else if (command == "Keluar")
                            state = State.Keluar;
                        else
                            state = State.Terbuka;
                        break;
                    case State.Keluar:
                        break;
                }
            }
            Console.WriteLine("Anda Keluar");
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

            Console.WriteLine();
            DoorMachine.doorMachine();
            Console.ReadKey();
        }
        
    }
}
