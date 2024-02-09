<?php

// 1. Input output
$name = readline("Masukkan nama Anda: ");
echo $name . PHP_EOL;

// 2. Variabel dan tipe data 
// String = menyimpan teks
$name = "Bunga";
echo $name . PHP_EOL;

// int = bilangan bulat
$count = 10;
$usia = 17;
echo ($count + $usia) . PHP_EOL;

// float = pecahan/desimal
$harga = 10.99;
$kualitas = 1.5E3;
$total = $harga * $kualitas;
echo $total . PHP_EOL;

// boolean = true/false
$admin = true;
$aktif = false;
if($admin && !$aktif){
  echo 'user aktif tapi bukan admin' . PHP_EOL;
}

// array = menyimpan banyak nilai dalam satu variabel
$warna = array('merah', 'hijau', 'kuning');
$orang = array('name' => 'nasyandra', 'umur' => 14,
               'kota' => 'Bandung');
echo $warna[1] . PHP_EOL;
echo $orang['umur'] . PHP_EOL;

// object = urut turunan dari class yang berisi method dan properties

// 3. Struktur bikin variable di php
// $namavariabel = nilai;

// 4. Operator aritmatika
$bil1 = 5;
$bil2 = 10;
echo ($bil1 + $bil2) . PHP_EOL;
echo ($bil1 / $bil2) . PHP_EOL;
echo ($bil1++) . PHP_EOL;
echo (++$bil1) . PHP_EOL;

// 5. Operator Pembanding and
$menikah = true;
$punyaAnak = false;
if ($menikah && $punyaAnak) {
  echo "Bahagia" . PHP_EOL;
} else {
  echo "Masih berusaha" . PHP_EOL;
}

// Operator Pembanding or
if ($menikah || $punyaAnak) {
  echo "Bahagia" . PHP_EOL;
} else {
  echo "Masih berusaha" . PHP_EOL;
}

// Operator Pembanding Not
if (!$menikah) {
  echo "Belum Menikah" . PHP_EOL;
} else {
  echo "Sudah Menikah" . PHP_EOL;
}

// 6. Percabangan if else
$nilai = 75;

if ($nilai >= 60) {
    echo "Anda lulus!";
} else {
    echo "Anda tidak lulus.";
}

// percabangan switch 
$hewan = "kucing";

switch ($hewan) {
    case "kucing":
        echo "Hewan favorit Anda adalah kucing!";
        break;
    case "anjing":
        echo "Hewan favorit Anda adalah anjing!";
        break;
    case "kelinci":
        echo "Hewan favorit Anda adalah kelinci!";
        break;
    default:
        echo "Hewan favorit Anda bukan kucing, anjing, atau kelinci.";
}

// 7. perulangan for
for($i = 0; $i < 10; $i++){
  echo $i . PHP_EOL;
}

//for in
$numbers = [1, 2, 3, 4, 5];
foreach ($numbers as $number) {
  echo $number . PHP_EOL;
}

//while
$i = 1;
while ($i < 10) {
  echo $i . PHP_EOL;
  $i++;
}

//do while
$a = 10;
do {
  echo $a . PHP_EOL;
  $a++;
} while ($a < 10);

// 8. Fungsi dengan parameter
function tambah($bil1, $bil2) {
  $hasil = $bil1 + $bil2;
  return $hasil;
}

?>
