using System;

namespace Buble2
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private readonly Array[] a = Array;

        // Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private Array MDW;
        private static Array? v;

        // Fungsi / Method untuk menerima masukan
        public void read(Array? v)
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada Array: ");
                string? v = Console.ReadLine();
                Array s = v;
                MDW = v;
                if (MDW > j)
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
                else
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Muhammad Davin Widyatmaka ");
            Console.WriteLine("-----------------------");

            // Pengguna memasukan elemen pada array
            for (Array a= j; j < MDW; j++)
            {
                Console.Write("<" + (j + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Array[];
            }
        }
        public void display()
        {
            // Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (arr j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) // for n - 1 passes
            {
                // Pada pass i,bandingkan n - i elemen pertama dengan elemen
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) // Jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Creating the object of the BubbleSort class
            Program mylist = new Program();

            // Pemanggilan funsi untuk menerima elemen array
            mylist.read(v);

            // Pemanggilan fungsi untuk mengurutkan array
            mylist.BubbleSortArray();

            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            mylist.display();

            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar. ");
        }
    }
}