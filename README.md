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
3️⃣ Tüm filmleri listeleme<br>
4️⃣ Film arama<br>
5️⃣ Filmi “İzlendi” olarak işaretleme<br>
6️⃣ Filmi “İzlenmedi” olarak işaretleme<br>
7️⃣ Çıkış<br>

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

🎯 Öğrenme Hedefleri

Bu proje boyunca amaçlanan şeyler:

* List ve koleksiyon yönetimi
* LINQ’e pratik bir giriş
* Menü tabanlı console uygulamaları
* Basit CRUD işlemleri
* Kodun katmanlara ayrılması (Manager mantığı)
<hr>

🗺️ Sonraki Adımlar (Planlananlar)

➕ Yeni film ekleme ekranını tamamen tamamlamak<br>
❌ Film silme işlemini yazmak<br>
🔍 Film arama (LINQ ile)<br>
👁 İzlendi / izlenmedi durumunu değiştirme<br>
💾 Verileri dosyada saklama (ileride)<br>
🧹 Kod yapısını daha da temizlemek
<hr>

📌 Not

Bu proje öğrenme amaçlıdır ve süreç ilerledikçe düzenli olarak güncellenecektir.<br>
Yeni özellikler eklendikçe README de genişletilecektir.
<hr>
