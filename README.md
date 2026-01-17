🎬 WatchTrack — Film Takip Uygulaması

WatchTrack, izlediğiniz (ve izlemek istediğiniz) filmleri kolayca takip edebilmeniz için geliştirilmiş basit bir C# Console uygulamasıdır.
Amaç; koleksiyon yönetimi, LINQ kullanımı ve temel CRUD mantığını küçük bir proje üzerinde pekiştirmektir.
<hr>

🚀 Şu ana kadar neler yapıldı?

✔️ MediaItem Modeli

Uygulamada saklanan her film için bir model oluşturuldu:

* Id
* Adı
* Türü
* Yılı
* Yönetmeni
* İzlendi / İzlenmedi durumu

Ayrıca her film için bilgileri temiz bir formatla gösteren bir DisplayInfo metodu eklendi.
<hr>

✔️ Menü Yapısı (Uygulama Akışı)

Kullanıcı için ana menü tasarlandı:

1️⃣ Film ekleme<br>
2️⃣ Film silme<br>
3️⃣ Film güncelleme<br>
4️⃣ Tüm filmleri listeleme<br>
5️⃣ İzlenen filmleri listeleme<br>
6️⃣ İzlenmeyen filmleri listeleme<br>
7️⃣ Film arama<br>
8️⃣ Filmi “İzlendi” olarak işaretleme<br>
9️⃣ Filmi “İzlenmedi” olarak işaretleme<br>
🔟 Çıkış<br>

Menü, kullanıcı hatalı giriş yaptığında yönlendirme yapacak şekilde hazırlandı.
<hr>

✔️ MediaManager Sınıfı

Film işlemlerinin yönetimi için ayrı bir sınıf oluşturuldu.<br>
Bu yapı sayesinde:

* Kod daha düzenli
* İş mantığı tek yerde toplandı
* Geliştirmeye açık bir yapı elde edildi
<hr>

✔️ Film Ekleme (Doğrulama ile)

Yeni film eklerken:

* Aynı Id tekrar girilirse
   * Kullanıcı uyarılıyor
   * İşlem iptal ediliyor
* Başarılı eklemede bilgi mesajı gösteriliyor

Bu sayede tekrarlayan kayıtların önüne geçildi.
<hr>

✔️ Film Silme (ID ile)

* Artık kullanıcı, filmleri ID numarasına göre silebiliyor.
    * ID listede yoksa uyarı veriliyor
    * Bulunan film listeden kaldırılıyor
    * İşlem sonunda bilgilendirme mesajı gösteriliyor
<hr>

✔️ Film Güncelleme (Update) Özelliği<br>

🔄 Bu güncelleme ile birlikte, film bilgileri ID üzerinden seçilerek güvenli bir şekilde güncellenebilmektedir.

📌 Güncelleme Akışı

1.  Kullanıcı güncellemek istediği filmin ID numarasını girer. <br>
2.  Film sistemde varsa, mevcut bilgiler ekranda gösterilir. <br>
3.  Kullanıcı hangi alanı güncellemek istediğini seçer. <br>
4.  Girilen yeni değerler kontrollerden geçirilerek güncellenir. <br>
5.  Güncelleme sonrası film bilgileri ekranda tekrar gösterilir. <br>

🛠️ Güncellenebilen Alanlar

*  Film Adı
*  Film Türü
*  Film Yılı
*  Film Yönetmeni

Her güncelleme işleminde;

*  Film var mı kontrol edilir
*  Boş giriş engellenir
*  Eski değer ile aynı giriş yapılması engellenir

🧠 Kullanılan Yapılar & Kavramlar

*  List<T> ile koleksiyon yönetimi
*  LINQ (FirstOrDefault) ile veri bulma
*  if yapıları ile validation (doğrulama)
*  switch-case ile menü kontrolü
*  Metot bazlı Single Responsibility yaklaşımı
*  bool dönüşlü metot ile akış kontrolü (ShowFilm)

📺 Örnek Kullanıcı Deneyimi

*  Güncelleme öncesi film bilgileri gösterilir
*  Güncelleme işlemi yapılır
*  Güncellenmiş film bilgileri anında ekrana yazdırılır
  
<hr>

✔️ Tüm Filmleri Listeleme

* Listeye eklenen tüm filmler ekranda şu formatta görüntüleniyor:
```  
ID
Adı
Türü
Yılı
Yönetmeni
İzlendi mi?
```
<hr>

✔️ İzlenen / İzlenmeyen Film Listeleri

📋 Menü üzerinden ayrı ayrı:
  * Sadece izlenen filmler
  * Sadece izlenmeyen filmler
listeleme yapılabilmektedir.

<hr>
✔️ Film Arama — LINQ ile

🔍 Gelişmiş Film Arama & Filtreleme<br>
Uygulamaya, kullanıcı deneyimini artırmak için gelişmiş arama seçenekleri eklendi.

🔎 Arama Türleri<br>
Kullanıcı artık film arama işlemini tek bir menü üzerinden, farklı kriterlere göre yapabiliyor:

🎬 Film adına göre arama<br>
📅 Film yılına göre arama<br>
🏷️ Film türüne göre arama<br>
🎥 Film yönetmenine göre arama<br>

Her arama işlemi:
* Büyük/küçük harf duyarsızdır
* Kısmi eşleşmeleri destekler (örn: “nolan” → “Christopher Nolan”)
* Sonuç bulunamazsa kullanıcı bilgilendirilir
* LINQ kullanıldı: Where, ToList
<hr>

✔️ İzleme Durumunu İşaretleme 

👁️ Filmler için izlendi / izlenmedi durumu yönetimi eklendi. 

* Bir film:
    * İzlendi olarak işaretlenebilir
    * İzlenmedi olarak geri alınabilir
* Eğer film zaten aynı (İzlendi/İzlenmedi) durumdaysa:
    * Kullanıcıya uyarı mesajı gösterilir
    * Gereksiz işlem yapılmaz
Bu sayede:
* Veri tutarlılığı korunur
* Kullanıcı hatalarının önüne geçilir

<hr>

✔️ Veri Kaydetme (JSON)

💾 Bu projede filmler JSON dosyası kullanılarak kalıcı olarak saklanmaktadır.<br>
*  Film ekleme, silme, güncelleme ve izlenme durumu değişiklikleri otomatik olarak kaydedilir.
*  Uygulama kapatılıp tekrar açıldığında filmler silinmez.
*  Veriler films.json dosyasında tutulur.

📂 JSON dosyasının konumu:
```
bin/Debug/netX.X/films.json
```
⚠️ Not:
*  films.json dosyası çalışma anında oluşturulduğu için Visual Studio Solution Explorer içinde görünmez.
*  Dosya, uygulama çalıştırıldıktan sonra ilgili klasörde otomatik olarak oluşur.

<hr>

🛠 Kullanılan Teknolojiler

*  C# Console Application
*  .NET
*  System.Text.Json
*  Nesne Yönelimli Programlama (OOP)
*  LINQ
*  Dosya işlemleri (File IO)

<hr>

🧠 Teknik Olarak Neler Öğrenildi

Bu aşamada kazanılan ek konular:

* First, FirstOrDefault, Any
* Koleksiyonda arama ve filtreleme
* Kullanıcı girdisi doğrulama
* Duruma göre mesaj yönetimi
* Basit koruyucu kontroller (guard clauses)
<hr>

🗺️ Sonraki Adımlar (Planlananlar)

Şuan için planlanan farklı bir geliştirme bulunmamaktadır
<hr>
📌 Not

Proje, öğrenme odaklıdır ve adım adım geliştirilmeye devam etmektedir.<br>
Yeni özellikler eklendikçe README de genişletilecektir.
<hr>
