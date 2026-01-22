# 🚀 ASP.NET Core 9.0 | Dinamik Full-Stack Portfolyo Otomasyonu
## Proje Hakkında
Bu çalışma, modern bir yazılım geliştiricinin ihtiyaç duyacağı tüm dijital varlıkları tek bir noktadan yönetmesini sağlayan, Entity Framework Core ve ASP.NET Core 9.0 altyapısıyla geliştirilmiş kapsamlı bir portfolyo sistemidir. 
Proje, sadece bir arayüz sunmakla kalmayıp, arkada çalışan güçlü bir yönetim paneliyle içeriklerin dinamik olarak güncellenmesine olanak tanır.

## 🛠️Teknik Mimari ve Teknoloji Yığını
-Proje, kurumsal standartlara uygun olarak N-Tier (Çok Katmanlı) Mimari ile geliştirilmiştir.
-Core Katmanı: Nesne modelleri (Entities) ve veri tabanı şemaları.
-Data Access Katmanı: Entity Framework Core ile Repository Pattern kullanımı.
-Business Katmanı: İş kuralları ve validasyon süreçleri.
-Web UI Katmanı: Tailwind CSS ve View Component tabanlı modüler arayüz.

### 🖥️Kullanılan Teknolojiler
-Backend: .NET 9.0, C#, EF Core.
-Database: MSSQL Server.
-Frontend: Tailwind CSS, jQuery, AJAX.
-UI Helpers: SweetAlert2, Slick Slider, Vegas Slider.


Bu projenin temel felsefesi, kullanıcı arayüzünde (UI) sergilenen tüm verilerin tamamen veritabanı odaklı ve yönetilebilir olmasıdır. 
"Hakkımda" yazısından "Yetenek" bar yüzdelerine, "Hizmetler" ikonlarından "Proje" galerisine kadar her bileşen, arka planda çalışan güçlü bir Admin Paneli aracılığıyla kontrol edilir. 
Yazılımın iskeleti, kod müdahalesine gerek duymadan içeriğin anlık olarak güncellenmesine, silinmesine veya yeni veriler eklenmesine olanak tanıyan bir CRUD (Create, Read, Update, Delete) ekosistemi üzerine inşa edilmiştir.
<img width="1917" height="903" alt="1" src="https://github.com/user-attachments/assets/8b274397-adf7-4f2d-8401-8a7650b590ad" />
<img width="1916" height="765" alt="2" src="https://github.com/user-attachments/assets/81a6c3af-53d2-4998-b8c2-e9d7110229ef" />
<img width="1913" height="705" alt="3" src="https://github.com/user-attachments/assets/c81c28e6-74ba-44bf-a46a-3286125418c1" />
<img width="1918" height="904" alt="4" src="https://github.com/user-attachments/assets/b2cb13d8-b6ab-4535-820a-b83edf383665" />
<img width="1919" height="908" alt="5" src="https://github.com/user-attachments/assets/cc6ed8e4-d8c7-4ea5-88a1-05b14b040a02" />
<img width="1917" height="902" alt="6" src="https://github.com/user-attachments/assets/9fd291e9-a0c8-407f-84c4-bba0010148ea" />
<img width="1919" height="907" alt="7" src="https://github.com/user-attachments/assets/f95ac80a-029f-4312-b4fa-e4c3fd6c38d0" />


## 🛠️ Teknik Detaylar ve Sayfa Analizleri
### 💻 Developer Admin Dashboard & Mesaj Yönetimi
-Projenin kalbi olan Dashboard, kullanıcıya sistemin genel sağlığı hakkında anlık istatistikler sunar.
-İstatistiksel Takip: Toplam proje sayısı, yetenekler ve okunmamış mesajlar gibi kritik veriler dinamik kartlar aracılığıyla izlenebilir.
-Gelişmiş Mesajlaşma Sistemi: Gelen tüm talepler; gönderen, konu, tarih ve durum (okundu/yeni) bilgileriyle birlikte listelenir, silinebilir veya detaylandırılabilir.

<img width="1916" height="902" alt="8" src="https://github.com/user-attachments/assets/1dd7abd0-34ec-48fc-b857-cae18c016fe1" />


### 📝 Hakkımda & Kişisel Bilgi Editörü
-Veritabanındaki 13 farklı alanı tek bir form üzerinden güncelleyebilen bu modül, projenin en karmaşık veri yapılarından birini yönetir.
-Bütünleşik Form Yapısı: Profil resmi URL'sinden eğitim geçmişine, deneyim özetlerinden genel açıklamalara kadar her detay bu panelden saniyeler içinde değiştirilir.

<img width="1915" height="898" alt="9" src="https://github.com/user-attachments/assets/f26b515f-e057-47b9-8ca4-3f35c93f0b03" />
<img width="1899" height="498" alt="10" src="https://github.com/user-attachments/assets/d3e3a610-9aeb-4236-a524-2e61e8ae1f6a" />

### 📊 Yetenek & Deneyim Envanteri
-Teknik yetkinliklerin ve profesyonel geçmişin yönetildiği bu bölümlerde Aktif/Pasif kontrolü mevcuttur.
-Anlık Kontrol: Bir yeteneği veya deneyimi silmek yerine "Pasife Al" seçeneği ile arayüzden gizleyebilir, veritabanında saklamaya devam edebilirsiniz.

<img width="1919" height="895" alt="11" src="https://github.com/user-attachments/assets/8ed52213-888a-40a8-95c4-1f64bfe7bdc0" />

### 🎨 Portfolyo & Hizmet Yönetimi
-Proje galerisi ve sunulan hizmetler, kategorize edilmiş bir liste yapısıyla sunulur.
-Kategori Bazlı Yayın: Projelerin hangi kategoride (Web, Mobil, AI) görüneceği ve yayın durumları merkezi olarak yönetilir.
-İkonik Sunum: Hizmetler bölümünde kullanılan modern ikonlar ve açıklamalar dinamik olarak arayüze basılır.

### 🤝 Referanslar & Müşteri Geri Bildirimleri
-Müşteri yorumları, slider yapısına uygun şekilde imaj ve unvan bilgileriyle birlikte saklanır ve yönetilir.

<img width="1914" height="899" alt="12" src="https://github.com/user-attachments/assets/cee3482b-48eb-4d3c-b7f4-ccc4d10337a3" />
<img width="1905" height="887" alt="13" src="https://github.com/user-attachments/assets/d4fd67e0-d0f2-4074-a311-ce017f63d519" />
<img width="1912" height="883" alt="14" src="https://github.com/user-attachments/assets/2b4a4acd-63a9-4106-a487-7c3bf1a1a374" />
<img width="1913" height="881" alt="15" src="https://github.com/user-attachments/assets/dd2f6b4a-7c43-4d9f-9083-90b1ae2f544f" />
<img width="1906" height="899" alt="16" src="https://github.com/user-attachments/assets/087eca6f-b82e-4848-a587-038b7fa8fa25" />
