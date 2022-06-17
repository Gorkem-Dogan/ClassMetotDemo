










musteriler musteri1 = new musteriler();
musteri1.Id = "25678";
musteri1.Ad = "Mehmet";
musteri1.Soyad = "Easdf";
musteri1.Bakiye = 1240;


musteriler musteri2 = new musteriler();
musteri2.Id = "56723";
musteri2.Ad = "Arda";
musteri2.Soyad = "asdfas";
musteri2.Bakiye = 8506;



MusteriManager musterimanager = new MusteriManager();
musterimanager.Ekle(musteri1);
musterimanager.Ekle(musteri2);
musterimanager.Sil(musteri1);


class MusteriManager {

    public void Ekle(musteriler musteri) {

        Console.WriteLine("Yeni müşterimiz :" + musteri.Id + " " + musteri.Ad + " " + musteri.Soyad + " " + musteri.Bakiye);
    }
    public void Sil(musteriler musteri) {

        Console.WriteLine("Müşterimiz kaydını sildirmiştir : " +musteri.Id);
    
    }




}
class musteriler {
    public string Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public float Bakiye { get; set; }
}

