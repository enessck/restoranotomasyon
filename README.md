# Restoran ve Kafe Otomasyon Sistemi 🍽️

Modern, kullanıcı dostu ve kapsamlı bir restoran/kafe otomasyon projesidir. İşletmelerin masa takibi, sipariş yönetimi, personel yetkilendirmesi, müşteri ilişkileri ve finansal raporlama işlemlerini tek bir merkezden kolayca yönetmesini sağlar.

## 🚀 Özellikler

* **Kullanıcı Girişi ve Yetkilendirme:** 
  * Müdür, Şef, Garson gibi farklı roller için rol tabanlı erişim kontrolü (Role-Based Access Control).
  * Personel hesaplarının ve şifrelerinin yönetilebildiği ayarlar modülü.
* **Masa Yönetimi (Adisyon):** 
  * Renk kodlu masa durumları (Boş, Dolu, Rezerve).
  * Masalara paket sipariş atama, adisyon ekleme, ürün çıkartma ve masa taşıma işlemleri.
* **Sipariş ve Menü Ekranı:**
  * Dokunmatik ekranlara (Numpad) uyumlu hızlı sipariş ekranı.
  * Kategori bazlı (Ana Yemek, İçecek, Tatlı vb.) ürün listeleme.
* **Ödeme ve Kasa (Z-Raporu) Sistemi:** 
  * Nakit, Kredi Kartı gibi farklı ödeme yöntemleri.
  * İndirim (yüzdelik veya tutar bazlı) uygulayabilme ve kısmi ödeme (parçalı tahsilat) imkânı.
  * Gün sonu Z-Raporu alma ve tarih bazlı satış dökümleri.
* **Grafiksel Satış Raporları:** 
  * Chart kontrolleri kullanılarak en çok satan ürünlerin ve gelirlerin grafiksel (bar chart) analizi.
* **Müşteri ve Rezervasyon Yönetimi:**
  * CRM mantığıyla müşteri kaydetme, düzenleme ve arama.
  * İleri tarihli masa rezervasyonları oluşturma.

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Platform:** .NET 10.0 (Windows Forms)
* **Veritabanı:** Microsoft SQL Server
* **ORM:** Entity Framework Core 10.0.5
* **Arayüz (UI):** Özel Metro tasarım (System.Drawing.Drawing2D) ve animasyonlu arka plan çizimleri
* **Grafik / Raporlama:** System.Windows.Forms.DataVisualization

## ⚙️ Kurulum ve Başlangıç

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

1. **Depoyu Klonlayın:**
   ```bash
   git clone https://github.com/KULLANICI_ADINIZ/RestoranOtomasyonu.git
   ```
2. **Bağımlılıkları Yükleyin:**
   Visual Studio üzerinden `RestaurantOtomasyon.sln` çözüm dosyasını açın. NuGet paketlerinin otomatik olarak geri yüklenmesi (restore) gerekmektedir. Eğer yüklenmezse `Package Manager Console` üzerinden şu komutu çalıştırın:
   ```bash
   dotnet restore
   ```
3. **Veritabanı Bağlantısını Yapılandırın:**
   `Data/ApplicationDbContext.cs` içerisinde bulunan SQL Server bağlantı dizesini (`ConnectionString`) kendi lokal SQL Server'ınıza veya LocalDB'nize göre güncelleyin.
4. **Veritabanını Oluşturun (Migration):**
   Gerekli tabloların ve örnek başlangıç verilerinin (Seed Data) veritabanına eklenmesi için `Package Manager Console` üzerinde şu komutu çalıştırın:
   ```bash
   Update-Database
   ```
5. **Projeyi Başlatın:**
   Projeyi derleyip (F5) başlatabilirsiniz. Veritabanı başlatıcı (DbInitializer) ilk açılışta varsayılan yönetici hesabını oluşturacaktır.

## 📸 Ekran Görüntüleri

_(Buraya projenizin ekran görüntülerini ekleyebilirsiniz.)_

* **Giriş Ekranı:** `[Ekran görüntüsü yolu/linki]`
* **Masa Görünümü:** `[Ekran görüntüsü yolu/linki]`
* **Sipariş & Adisyon İşlemleri:** `[Ekran görüntüsü yolu/linki]`
* **Satış Raporları ve Grafikler:** `[Ekran görüntüsü yolu/linki]`

---
_Bu proje bir son sınıf/akademik dönem projesi örnek alınarak geliştirilmiştir._
