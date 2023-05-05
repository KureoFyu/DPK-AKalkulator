using System;
class PortofolioDPK1933
{
    public static void Main(string[] args)
    {
        for (int i = 1; i == 1;)
        {
            int Bilangan1_33_19;
            int Bilangan2_33_19;
            string Inputan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===============================================");
            Console.Write("||[ Selamat datang di Kalku");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("lator Agus Kecap ]||");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===============================================");
            Console.WriteLine();

            Console.Write("Masukkan Bilangan 1 = ");
            Bilangan1_33_19 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Masukkan ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Jumlah(+) |");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Kurang(-) |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Kali(*) |");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" Bagi(/) |");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Pangkat(^) |");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Akar(Akar)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Inputan = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Masukkan Bilangan 2 = ");
            Bilangan2_33_19 = int.Parse(Console.ReadLine());

            if (Inputan == "+")
            {
                int hasilTambah = Bilangan1_33_19 + Bilangan2_33_19;
                Console.WriteLine();
                Console.WriteLine(" [ " + Bilangan1_33_19 + " + " + Bilangan2_33_19 + " = " + hasilTambah + " ] ");
            }
            else if (Inputan == "-")
            {
                int hasilKurang = Bilangan1_33_19 - Bilangan2_33_19;
                Console.WriteLine();
                Console.WriteLine(" [ " + Bilangan1_33_19 + " - " + Bilangan2_33_19 + " = " + hasilKurang + " ] ");
            }
            else if (Inputan == "/")
            {
                int hasilBagi = Bilangan1_33_19 / Bilangan2_33_19;
                Console.WriteLine();
                Console.WriteLine(" [ " + Bilangan1_33_19 + " / " + Bilangan2_33_19 + " = " + hasilBagi + " ]");
            }
            else if (Inputan == "*")
            {
                int hasilKali = Bilangan1_33_19 * Bilangan2_33_19;
                Console.WriteLine();
                Console.WriteLine(" [ " + Bilangan1_33_19 + " * " + Bilangan2_33_19 + " = " + hasilKali + " ] ");
            }
            else if (Inputan == "^")
            {
                double hasilpangkat = Math.Pow(Bilangan1_33_19, Bilangan2_33_19);
                Console.WriteLine(" [ " + Bilangan1_33_19 + " ^ " + Bilangan2_33_19 + " = " + hasilpangkat + " ] ");
            }
            else if (Inputan == "Akar")
            {
                double hasilakar = Math.Sqrt(Bilangan1_33_19);
                Console.WriteLine(" [ Akar dari " + Bilangan1_33_19 + " adalah " + hasilakar + " ] ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Error Mohon Masukan Operator Yang Benar");
                Console.ForegroundColor = ConsoleColor.White;
            }
            string agusbalikbadan;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.Write(" Apakah Beliau Ingin Mengulangi Kalkulator? ( y / n ) ");
            agusbalikbadan = Convert.ToString(Console.ReadLine());
            if (agusbalikbadan == "y")
            {
                Console.Clear();
            }
            else if (agusbalikbadan == "n")
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ========================================================= ");
                Console.WriteLine(" ||!Terimakasih Telah Menggunakan Kalkulator Agus Kecap!|| ");
                Console.WriteLine(" ========================================================= ");
                Console.ForegroundColor = ConsoleColor.White;
                break;
            }
        }
    }
}