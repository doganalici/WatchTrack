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

✔️ Başlangıç Film Listesi

Uygulama açıldığında, örnek birkaç film otomatik olarak listeye ekleniyor.<br>
Bu sayede uygulama ilk çalıştırmadan itibaren listeleme ve görüntüleme işlemleri yapılabiliyor.
<hr>

✔️ Menü Yapısı (Uygulama Akışı)

Kullanıcı için ana menü tasarlandı:

1️⃣ Yeni film ekleme<br>
2️⃣ Film silme<br>
3️⃣ Film güncelleme<br>
4️⃣ Tüm filmleri listeleme<br>
5️⃣ Film arama<br>
6️⃣ Filmi “İzlendi” olarak işaretleme<br>
7️⃣ Filmi “İzlenmedi” olarak işaretleme<br>
8️⃣ Çıkış<br>

Menü, kullanıcı hatalı giriş yaptığında yönlendirme yapacak şekilde hazırlandı.
<hr>

✔️ FilmManager Sınıfı

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

🧠 Teknik Olarak Neler Öğrenildi

Bu aşamada kazanılan ek konular:

* First, FirstOrDefault, Any
* Koleksiyonda arama ve filtreleme
* Kullanıcı girdisi doğrulama
* Duruma göre mesaj yönetimi
* Basit koruyucu kontroller (guard clauses)
<hr>

🗺️ Sonraki Adımlar (Planlananlar)

<br>✏️ Film Güncelleme
Var olan filmler üzerinde bilgi düzenleme:
* Ad
* Tür
* Yıl
* Yönetmen

<br>👁 Filmleri Duruma Göre Listeleme
* Sadece izlenenler
* Sadece izlenmeyenler

<br>💾 Kalıcı Veri Saklama<br>
Uygulama kapandıktan sonra filmler kaybolmasın:
* JSON / TXT dosyasına kaydetme
* Açılışta otomatik yükleme
<hr>

📌 Not

Proje, öğrenme odaklıdır ve adım adım geliştirilmeye devam etmektedir.<br>
Yeni özellikler eklendikçe README de genişletilecektir.
<hr>
