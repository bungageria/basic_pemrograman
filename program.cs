using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Input output
        Console.Write("Masukkan nama Anda: ");
        string name = Console.ReadLine();
        Console.WriteLine(name);

        // 2. Variabel dan tipe data
        // String = menyimpan teks
        string name = "Bunga";
        Console.WriteLine(name);

        // int = bilangan bulat
        int A = 5;
        int B = A + 5;
        Console.WriteLine(B);

        int count = 10;
        int usia = 17;
        Console.WriteLine(count + usia);

        // float = pecahan/desimal
        double harga = 10.99;
        double kualitas = 1.5E3;
        double total = harga * kualitas;
        Console.WriteLine(total);

        //char
        char Inisial ='A';
        Console.WriteLine(Inisial);

        // boolean = true/false
        bool admin = true;
        bool aktif = false;
        if (admin && !aktif)
        {
            Console.WriteLine("user aktif tapi bukan admin");
        }

        // 3. Operator aritmatika
        int bil1 = 5;
        int bil2 = 10;
        Console.WriteLine(bil1 + bil2);
        Console.WriteLine(bil1 / bil2);
        Console.WriteLine(bil1++);
        Console.WriteLine(++bil1);

        // 4. Operator Pembanding and
        bool menikah = true;
        bool punyaAnak = false;
        if (menikah && punyaAnak)
        {
            Console.WriteLine("Bahagia");
        }
        else
        {
            Console.WriteLine("Masih berusaha");
        }

        // Operator Pembanding or
        if (menikah || punyaAnak)
        {
            Console.WriteLine("Bahagia");
        }
        else
        {
            Console.WriteLine("Masih berusaha");
        }

        // Operator Pembanding Not
        if (!menikah)
        {
            Console.WriteLine("Belum Menikah");
        }
        else
        {
            Console.WriteLine("Sudah Menikah");
        }

        // 5. Percabangan if else
        int nilai = 75;

        if (nilai >= 60)
        {
            Console.WriteLine("Anda lulus!");
        }
        else
        {
            Console.WriteLine("Anda tidak lulus.");
        }

        // percabangan switch 
        string hewan = "kucing";

        switch (hewan)
        {
            case "kucing":
                Console.WriteLine("Hewan favorit Anda adalah kucing!");
                break;
            case "anjing":
                Console.WriteLine("Hewan favorit Anda adalah anjing!");
                break;
            case "kelinci":
                Console.WriteLine("Hewan favorit Anda adalah kelinci!");
                break;
            default:
                Console.WriteLine("Hewan favorit Anda bukan kucing, anjing, atau kelinci.");
                break;
        }

        // 6. perulangan for
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        // foreach
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // while
        int i = 1;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
        }

        // do while
        int a = 10;
        do
        {
            Console.WriteLine(a);
            a++;
        } while (a < 10);

        // 8. Fungsi dengan parameter
        int hasil = tambah(5, 3);
        Console.WriteLine(hasil);
    }

    // Fungsi tambah
    static int tambah(int bil1, int bil2)
    {
        return bil1 + bil2;
    }
}
