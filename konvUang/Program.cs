using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konvUang
{
    /// <summary>
    /// class untuk konversi dari rupiah ke dollar
    /// </summary>
    /// <remarks>class KonvDollar ini dapat mengoprasikan konversi dari rupiah ke dollar</remarks>
    public class KonvDollar
    {
        /// <summary>
        /// deklarasi variabel yang akan digunakan yaitu 'rupiah' dan 'dollar'
        /// </summary>
        public double rupiah, dollar;

        /// <summary>
        /// method ini adalah untuk menginput nominal rupiah yang ingin anda konversi
        /// </summary>
        public void Masukkandatadoll()
        {
            Console.Write("Masukkan nominal rupiah : ");
            rupiah = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// method untuk operasi konversi dari rupiah yang diinput untuk dikonversi ke dollar
        /// </summary>
        ///<param name="r">angka rupiah dalam operasi untuk konversi ke dollar</param>
        ///<param name="d">angka dollar hasil dari operasi konversi rupiah</param>
        ///<returns>hasil dari rupiah dibagi 14000(konversi 1 dollar ke rupiah saat itu)</returns>
        public double ProsesDoll(double r, double d)
        {
            return d = r / 14000;
        }


        /// <summary>
        /// method untuk menampilkan hasil rupiah yang telah dikonversi ke dollar
        /// </summary>
        public void TampilkanDoll()
        {
            Console.WriteLine("Hasil konversi rupiah ke dollar : " + this.ProsesDoll(rupiah, dollar));
            Console.WriteLine("Tekan 4 untuk keluar ... ");
            Console.WriteLine("Tekan Enter untuk Melanjutkan");
            Console.ReadKey();
        }
    }



    /// <summary>
    /// class untuk konversi dari rupiah ke yen
    /// </summary>
    /// <remarks>class KonvYen ini dapat mengoprasikan konversi dari rupiah ke Yen</remarks>
    public class KonvYen
    {
        /// <summary>
        /// deklarasi variabel yang akan digunakan yaitu 'rupiah' dan 'Yen'
        /// </summary>
        public double rupiah, Yen;


        /// <summary>
        /// method ini adalah untuk menginput nominal rupiah yang ingin anda konversi
        /// </summary>
        public void MasukkandataYen()
        {
            Console.Write("Masukkan nominal rupiah : ");
            rupiah = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// method untuk operasi konversi dari rupiah yang diinput untuk dikonversi ke dollar
        /// </summary>
        /// <param name="r1">angka rupiah dalam operasi untuk konversi ke Yen</param>
        /// <param name="y">angka yen hasil dari operasi konversi rupiah</param>
        /// <returns>hasil dari rupiah dibagi 1900(konversi 1 yen ke rupiah saat itu)</returns>
        public double ProsesYen(double r1, double y)
        {
            return y = r1 / 1900;
        }

        /// <summary>
        /// method untuk menampilkan hasil rupiah yang telah dikonversi ke yen
        /// </summary>
        public void TampilkanYen()
        {
            Console.WriteLine("Hasil konversi rupiah ke Yen : " + this.ProsesYen(rupiah, Yen));
            Console.WriteLine("Tekan 4 untuk keluar ... ");
            Console.WriteLine("Tekan Enter untuk Melanjutkan");
            Console.ReadKey();
        }
    }


    /// <summary>
    /// class untuk konversi dari rupiah ke euro
    /// </summary>
    /// <remarks>class KonvYen ini dapat mengoprasikan konversi dari rupiah ke euro</remarks>
    public class KonvEuro
    {
        /// <summary>
        /// deklarasi variabel yang akan digunakan yaitu 'rupiah' dan 'Yen'
        /// </summary>
        public double rupiah, Euro;

        /// <summary>
        /// method ini adalah untuk menginput nominal rupiah yang ingin anda konversi
        /// </summary>
        public void MasukkandataEuro()
        {
            Console.Write("Masukkan nominal rupiah : ");
            rupiah = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// method untuk operasi konversi dari rupiah yang diinput untuk dikonversi ke euro
        /// </summary>
        /// <param name="r2">angka rupiah dalam operasi untuk konversi ke euro</param>
        /// <param name="e"></param>
        /// <returns>hasil dari rupiah dibagi 16000(konversi 1 euro ke rupiah saat itu)</returns>
        public double ProsesEuro(double r2, double e)
        {
            return e = r2 / 16000;
        }

        /// <summary>
        /// method untuk menampilkan hasil rupiah yang telah dikonversi ke euro
        /// </summary>
        public void TampilkanEuro()
        {
            Console.WriteLine("Hasil konversi rupiah ke Euro : " + this.ProsesEuro(rupiah, Euro));
            Console.WriteLine("Tekan 4 untuk keluar ... ");
            Console.WriteLine("Tekan Enter untuk Melanjutkan");
            Console.ReadKey();
        }
    }


    class Program
    {
        /// <summary>
        /// class Main ini untuk menu
        /// </summary>
        /// <remarks>Class ini berisi menu ataupun code switch yang berguna agar pengguna bisa memilih
        /// koversi mana yang dinginkan</remarks>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /// <summary>deklarasi untuk memanggil class/method yang telah dibuat sebelumnya</summary>
            KonvDollar dl = new KonvDollar();
            KonvYen yn = new KonvYen();
            KonvEuro eu = new konvUang.KonvEuro();


            /// <summary>operasi while looping untuk switch case menu</summary>
            int pilih;
            bool lanjut = true;
            while (lanjut)
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
                Console.WriteLine("║      Selamat datang di aplikasi konversi mata uang      ║" +
                                "\n║   Silahkan memilih mata uang yang diinginkan pada menu  ║" +
                                "\n╚═════════════════════════════════════════════════════════╝" +
                                 "\n==========================================================\n");
                Console.WriteLine("1. Rupiah ke Dollar");
                Console.WriteLine("2. Rupiah ke Yen");
                Console.WriteLine("3. Rupiah ke Euro");
                Console.WriteLine("4. Keluar");
                Console.Write("Pilihan (1/2/3/4) : ");
                pilih = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");


                ///<summary>operasi switch case menu untuk memilih konversi mana yang akan dipilih</summary>
                switch (pilih)
                {
                    case 1:
                        dl.Masukkandatadoll();
                        dl.TampilkanDoll();
                        break;
                    case 2:
                        yn.MasukkandataYen();
                        yn.TampilkanYen();
                        break;
                    case 3:
                        eu.MasukkandataEuro();
                        eu.TampilkanEuro();
                        break;
                    case 4:
                        lanjut = false;
                        break;

                    default:
                        Console.WriteLine("Pilihan Salah!!!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
