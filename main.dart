import 'dart:io';

void main() {
  // 1. Input output
  String? name = stdin.readLineSync();
  print(name);

  // 2. Komentar
  // Komentar satu baris

  /*
  Ini adalah contoh komentar
  dengan banyak baris di dart
  Gunakan ini untuk penjelasan yang lebih panjang
  */

  // 3. Variabel dan tipe data 
  // int = bilangan bulat
  // double = pecahan/desimal
  // bool = true/false
  // list/array = menyimpan banyak nilai
  // map = menyimpan sebuah nilai
  // num = bisa untuk semua bilangan
  // String = menyimpan teks
  // dynamic = memungkinkan nilai variabel berubah sesuai konteks

  // 4. Struktur bikin variable di dart
  // String name ="Bunga Geria";

  // 5. mendukung nullable
  String? merkLaptop;
  print(merkLaptop);

  // 6. Operator aritmatika
  int bil1 = 5;
  int bil2 = 10;
  print(bil1 + bil2);
  print(bil1 / bil2);
  print(bil1++);
  print(++bil1);

  // 7. Operator Pembanding and
  bool menikah = true;
  bool punyaAnak = false;
  if (menikah && punyaAnak) {
    print("Bahagia");
  } else {
    print("Masih berusaha");
  }

  // Operator Pembanding or
  if (menikah || punyaAnak) {
    print("Bahagia");
  } else {
    print("Masih berusaha");
  }

  // Operator Pembanding Not
  if (!menikah) {
    print("Belum Menikah");
  } else {
    print("Sudah Menikah");
  }

  // 8. Percabangan if else
  int jumlahAnak = 2; 
  if (jumlahAnak >= 2) { 
    print("Cukup atau melebihi program KB");
  } else {
    print("Tidak buruk");
  }

  int nilai = 80;
  if(nilai > 90){
    print("A");
  }else if(nilai >80){
    print("B");
  }else{
    print("c");
  }

 // percabangan switch 
  switch (nilai) {
    case 90:
      print("A");
      break; 
    case 80:
      print("B");
      break;
    default:
      print("C");
  }

  // 9. perulangan for
  for(var i = 0; i < 10; i++){
    print(i);
  }

  //for in
  List<int> numbers = [1, 2, 3, 4, 5];
  for (int number in numbers) {
    print(number);
  }

  //while
  int i = 1;
  while (i < 10) {
    print(i);
    i++;
  }

  //do while
  int a = 10;
  do {
    print(a);
    a++;
  } while (a < 10);

  // 10. Fungsi dengan parameter
  int tambah(int bil1, int bil2) {
  int hasil = bil1 + bil2;
  return hasil;
}

}
