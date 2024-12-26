using System;

class Program
{
    static void Main(string[] args)
    {
        // =======================================================================================
        //tugas modul 2 nomer 1
        Console.WriteLine("Travel Suka Bahagia");
        Console.WriteLine("<==================>");

        //pilihan tujuan
        while (true)
        {
            Console.WriteLine("\nPilih tujuan:");
            Console.WriteLine("1. Sidoarjo");
            Console.WriteLine("2. Gresik");
            Console.WriteLine("3. Bandung");
            Console.WriteLine("0. Keluar");

            Console.Write("Masukkan pilihan: ");
            string pilihan = Console.ReadLine();

            //jika memilih keluar maka program berhenti
            if (pilihan == "0")
            {
                break;
            }

            //declare variable
            Console.Write("Masukkan jumlah orang: ");
            int jumlahOrang = int.Parse(Console.ReadLine());
            int tarif = 0;
            double diskon = 0;

            // Sidoarjo
            if (pilihan == "1") 
            {
                tarif = 175000;
                if (jumlahOrang >= 5)
                {
                    diskon = 0.2;
                }
                else if (jumlahOrang >= 3)
                {
                    diskon = 0.1;
                }
            }
            // Gresik
            else if (pilihan == "2") 
            {
                tarif = 100000;
                if (jumlahOrang >= 4)
                {
                    diskon = 0.25;
                }
                else if (jumlahOrang >= 2)
                {
                    diskon = 0.15;
                }
            }
            // Bandung
            else if (pilihan == "3") 
            {
                tarif = 495000;
                if (jumlahOrang > 10)
                {
                    diskon = 0.45;
                }
                else if (jumlahOrang > 5)
                {
                    diskon = 0.3;
                }
            }
            else
            {
                Console.WriteLine("Error! Pilihan tidak valid.");
                continue;
            }

            //menghitung total harga dan harga potongan setelah diskon
            double totalHarga = tarif * jumlahOrang;
            double hargaSetelahDiskon = totalHarga - (totalHarga * diskon);

            Console.WriteLine($"Total harga: Rp {totalHarga:N0}");
            Console.WriteLine($"Diskon: {diskon * 100}%");
            Console.WriteLine($"Harga setelah diskon: Rp {hargaSetelahDiskon:N0}");
        }

        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Terima kasih telah menggunakan Travel Suka Bahagia!");
        Console.WriteLine("---------------------------------------------------");

    //=============================================================================================
    //tugas modul2 nomer 2

        // Console.WriteLine("========================");
        // Console.WriteLine("Program Jadwal Pelajaran");
        // Console.WriteLine("========================");

        // Console.Write("Masukkan hari: ");
        // string hari = Console.ReadLine().ToLower(); //Menggunakan ToLower agar tidak Case Sensitive

        // Console.WriteLine("\nJadwal Pelajaran:");

        // //Switch case hari
        // switch (hari)
        // {
        //     case "senin":
        //         Console.WriteLine("- Upacara Bendera");
        //         Console.WriteLine("- Bahasa Indonesia");
        //         Console.WriteLine("- Matematika");
        //     break;
        //     case "selasa":
        //         Console.WriteLine("- Pendidikan Agama");
        //         Console.WriteLine("- Pancasila");
        //     break;
        //     case "rabu":
        //         Console.WriteLine("- Pendidikan Jasmani, Olahraga, dan Kesehatan");
        //         Console.WriteLine("- Bahasa Daerah");
        //     break;
        //     case "kamis":
        //         Console.WriteLine("- Seni Budaya dan Prakarya");
        //     break;
        //     case "jumat":
        //         Console.WriteLine("- Pramuka");
        //         Console.WriteLine("- Kegiatan Tematik");
        //     break;
        //     //case digabungkan karena kedua harinya pada jadwal libur
        //     case "sabtu":
        //     case "minggu":
        //         Console.WriteLine("- Libur");
        //     break;
        //     default:
        //         Console.WriteLine("Hari yang dimasukkan tidak valid.");
        //         break;
        // }

        // Console.WriteLine("\nTerima kasih telah menggunakan program Jadwal Pelajaran!");
//------------------------------------------------------------------------------------------
        // int tarif, jumlahorang;
        // double diskon, total;
        // string kota;

        // Console.WriteLine("Tentukan kota tujuan yang ingin anda tuju!" + (char) 13 + "1.Sidoarjo Rp.175000" + (char) 13 + "2.Gresik Rp.100000" + (char) 13 + "3.Bandung Rp.495000" + (char) 13 + "Masukkan kota yang ingin anda tuju :");
        // kota = Console.ReadLine();
        // Console.WriteLine("Masukkan Jumlah Orang :");
        // jumlahorang = (int) inputValue();
        // if (kota == "bandung")
        // {
        //     tarif = 495000;
        //     if (jumlahorang > 10)
        //     {
        //         diskon = tarif * 0.45;
        //     }
        //     else
        //     {
        //         if (jumlahorang > 5)
        //         {
        //             diskon = tarif * 0.3;
        //         }
        //         else
        //         {
        //             diskon = tarif * 0;
        //         }
        //     }
        // }
        // else
        // {
        //     if (kota == "sidoarjo")
        //     {
        //         tarif = 175000;
        //         if (jumlahorang >= 5)
        //         {
        //             diskon = tarif * 0.2;
        //         }
        //         else
        //         {
        //             if (jumlahorang >= 3)
        //             {
        //                 diskon = tarif * 0.1;
        //             }
        //             else
        //             {
        //                 diskon = tarif * 0;
        //             }
        //         }
        //     }
        //     else
        //     {
        //         if (kota == "gresik")
        //         {
        //             tarif = 100000;
        //             if (jumlahorang >= 4)
        //             {
        //                 diskon = tarif * 0.25;
        //             }
        //             else
        //             {
        //                 if (jumlahorang >= 2)
        //                 {
        //                     diskon = tarif * 0.15;
        //                 }
        //                 else
        //                 {
        //                     diskon = tarif * 0;
        //                 }
        //             }
        //         }
        //         else
        //         {
        //             Console.WriteLine("Error! Kota yang anda masukkan salah.");
        //         }
        //     }
        // }
        // total = jumlahorang * tarif - diskon;
        // Console.WriteLine("Anda mendapatkan diskon sebesar :Rp." + diskon);
        // Console.WriteLine("Harga tarif anda yang harus dibayar setelah potongan diskon sebesar : Rp." + total);
        //----------------------------------------------------------------------------------------------------------

    // int i=5,j;

    // Console.WriteLine(j=i*2);

    //---------------------------------------------------------------------------------------------------------------
    // tugas alpro bu anisa
    
    //  Console.WriteLine("Selamat datang di Program Pengajuan KPR Bank Jago");

    //     // Input data
    //     Console.Write("Masukkan gaji per bulan: ");
    //     double gaji = Convert.ToDouble(Console.ReadLine());

    //     Console.Write("Apakah Anda memiliki pinjaman dari bank? (ya/tidak): ");
    //     string pinjaman = Console.ReadLine().ToLower();

    //     Console.Write("Masukkan saldo yang Anda miliki: ");
    //     double saldo = Convert.ToDouble(Console.ReadLine());

    //     // Pengecekan syarat KPR
    //     bool syaratGaji = gaji > 10000000;
    //     bool syaratPinjaman = pinjaman != "ya";
    //     bool syaratSaldo = saldo > 7000000;

    //     // Pengecekan kelayakan KPR
    //     if (syaratGaji && syaratPinjaman && syaratSaldo)
    //     {
    //         Console.WriteLine("Selamat! Anda memenuhi syarat untuk KPR Bank Jago.");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Maaf, Anda tidak memenuhi syarat untuk KPR Bank Jago.");
    //         Console.WriteLine("Pilihan yang tersedia:");
    //         Console.WriteLine("1. Pinjam uang sebesar 100 juta");
    //         Console.WriteLine("2. Pilih bank lainnya");

    //         Console.Write("Masukkan pilihan Anda (1/2): ");
    //         string pilihan = Console.ReadLine();

    //         switch (pilihan)
    //         {
    //             case "1":
    //                 Console.WriteLine("Anda memilih untuk meminjam uang sebesar 100 juta.");
    //                 break;
    //             case "2":
    //                 Console.WriteLine("Anda memilih untuk mencoba KPR di bank lainnya.");
    //                 break;
    //             default:
    //                 Console.WriteLine("Pilihan tidak valid.");
    //                 break;
    //         }
    //     }

    //     Console.WriteLine("Terima kasih telah menggunakan layanan kami.");

//--------------------------------------------------------------------------------------------------------------

// Console.WriteLine("Masukkan nilai yang ingin diinputkan ");
// string nilai;
// Console.Write("Masukkan nilai yang ingin diinputkan :");
// int angka = int.Parse(Console.ReadLine());

// if(angka > 85 ){
//     nilai = "A";
//     Console.Write("Nilai yang diinputkan mendapatkan nilai A");
//     }else{
//          if(angka < 75 && angka >= 85){
//             nilai = "AB";
//             Console.Write("Nilai yang diinputkan mendapatkan nilai AB");
//     }else{
//         if(angka < 65 && angka >=75 ){
//             nilai = "B";
//             Console.Write("Nilai yang diinputkan mendapatkan nilai B");
//         }
//     }

// }

// Console.Write("Masukkan nilai yang ingin diinputkan :");
// int angka = int.Parse(Console.ReadLine());
// switch(angka){
// case > 85:
//     Console.WriteLine("A");
// break;
// case < 75  :
// case >= 85 :
//     Console.WriteLine("AB");
// break;

// for (int x= 1; x <= 100; x++){
//  Console.WriteLine("ASTAGFIRULLAH");
// }

// int i = 0;
// while (int < 5)
// {
//     Console.WriteLine(i);
//     i++;
// }
// int i = 0;
// do{
//     Console.WriteLine(i);
//     i++;
// }
// while (i);



    
    }
}

