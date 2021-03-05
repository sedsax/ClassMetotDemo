using System;
/*
Bir bankada müşteri takibi yapmak istiyorsunuz.
Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
*/

class MainClass {
  public static void Main (string[] args) {
    Musteri m1 = new Musteri();
    m1.id=1001;
    m1.ad = "Selin";
    m1.soyad = "Kerimoğlu";
            
    Musteri m2 = new Musteri();
    m2.id = 1007;
    m2.ad = "Menderes";
    m2.soyad = "Mermertay";

    Musteri m3 = new Musteri();
    m3.id = 1023;
    m3.ad = "Hakan";
    m3.soyad = "Kartal";
           
    MusteriManager Mngr = new MusteriManager();
    Mngr.Ekleme(m1,m2,m3);
    Mngr.Silme(m2);
    Mngr.Listeleme(m1, m3);
  }
}

class Musteri{
  public int id { get; set; }
  public string ad { get; set; }
  public string soyad { get; set; }

}

class MusteriManager{
  public void Ekleme( params Musteri[] ms){
    foreach (var i in ms){
      Console.WriteLine("Müşteri Eklendi: " + i.id +" " + i.ad + " " + i.soyad);
    }
    Console.WriteLine("---------------------------------");
  }
  public void Silme( params Musteri[] ms){
    foreach (var i in ms){
      Console.WriteLine("Müşteri Silindi: " + i.id + " "+i.ad + " " + i.soyad);
    }
    Console.WriteLine("---------------------------------");
  }



  public void Listeleme(params Musteri[] ms){
    foreach (var i in ms){
      Console.WriteLine("Müşteri Listesi : " + i.id +" "+ i.ad + " " + i.soyad);
    }  
    Console.WriteLine("---------------------------------");       
  }

}
