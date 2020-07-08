using ProjectPenjualan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Pilih Menu:");
            Console.WriteLine("1. Tambah Mahasiswa \n2. Hapus Mahasiswa \n3. Tampil Mahasiswa \n4. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Mahasiswa mahasiswa = new Mahasiswa();

            Console.Clear();

            Console.WriteLine("Tambah Mahasiswa: ");

            Console.WriteLine("NIM: ");
            mahasiswa.Nim = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nama: ");
            mahasiswa.nama = Console.ReadLine();

            Console.Write("Jenis [L/P]: ");
            string jenis = Console.ReadLine();

            mahasiswa.Jenis = (jenis == "L" || jenis == "P") ? "Laki Laki" : "Perempuan";

            Console.Write("IPK: ");
            mahasiswa.IPK = Console.Read();

            daftarMahasiswa.Add(mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();
            bool status = false;

            // PERINTAH: lengkapi kode untuk menghapus objek mahasiswa dari dalam collection
            Console.WriteLine("Hapus Data Mahasiswa");

            Console.Write("NIM: ");
            int Nim = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < daftarMahasiswa.Count; i++)
            {
                if (Nim == daftarMahasiswa[i].Nim)
                {
                    daftarMahasiswa.Remove(daftarMahasiswa[i]);
                    status = true;
                    break;
                }
                else
                {
                    status = false;
                }
            }

            if (status)
            {
                Console.WriteLine("Data Mahasiswa \"{0}\" telah dihapus", Nim);
            }
            else
            {
                Console.WriteLine("Data Mahasiswa \"{0}\" tidak di temukan", Nim);
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke Menu");
            Console.ReadKey();
        }


        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.WriteLine("Tampil Mahasiswa: ");

            if (daftarMahasiswa.Count > 0)
            {
                for (int i = 0; i < daftarMahasiswa.Count; i++)
                {
                    Console.WriteLine(" {0}. | {1}, {2}, {3}, {4}, {5}", i + 1, daftarMahasiswa[i].Nim, daftarMahasiswa[i].Nama, daftarMahasiswa[i].Jenis, daftarMahasiswa[i].IPK);
                }
            }
            else
            {
                Console.WriteLine("Tidak Ada Daftar Mahasiswa");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
