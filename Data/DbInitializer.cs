using System.Linq;
using RestaurantOtomasyon.Models;

namespace RestaurantOtomasyon.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Veritabanını oluştur (yoksa), ama her seferinde silme
            context.Database.EnsureCreated();

            // Zaten veri varsa tekrar ekleme
            if (context.Users.Any())
                return;

            var users = new User[]
            {
                new User{Username="admin",FirstName="Ahmet",LastName="Birhat Okumuş",Password="1234",Role="Müdür"},
                new User{Username="garson",FirstName="Belkıs",LastName="Kaya",Password="1234",Role="Bulaşıkçı"},
                new User{Username="sef",FirstName="Mery",LastName="Yurt",Password="1234",Role="Şef"}
            };
            foreach (User s in users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();

            // Görseldeki gibi tam kategori listesi ve renk kodları
            var categories = new Category[]
            {
                new Category{Name="ANAYEMEK", ColorHex="#f44336"}, // Kırmızı
                new Category{Name="İÇECEKLER", ColorHex="#ff9800"}, // Turuncu
                new Category{Name="TATLILAR", ColorHex="#03a9f4"}, // Mavi
                new Category{Name="SALATA", ColorHex="#4caf50"}, // Yeşil
                new Category{Name="FASTFOOD", ColorHex="#00bcd4"}, // Turkuaz/Cyan
                new Category{Name="ÇORBA", ColorHex="#ffeb3b"}, // Sarı
                new Category{Name="MAKARNA", ColorHex="#9c27b0"}, // Mor
                new Category{Name="ARASICAK", ColorHex="#ff9800"} // Turuncu
            };
            foreach (Category c in categories)
            {
                context.Categories.Add(c);
            }
            context.SaveChanges();

            var corbaId = context.Categories.First(c => c.Name == "ÇORBA").Id;
            var anaYemekId = context.Categories.First(c => c.Name == "ANAYEMEK").Id;
            var icecekId = context.Categories.First(c => c.Name == "İÇECEKLER").Id;
            var fastFoodId = context.Categories.First(c => c.Name == "FASTFOOD").Id;
            var salataId = context.Categories.First(c => c.Name == "SALATA").Id;

            var products = new Product[]
            {
                new Product{Name="Ezogelin Çorbası",Price=50,CategoryId=corbaId},
                new Product{Name="Mercimek Çorbası",Price=45,CategoryId=corbaId},
                new Product{Name="Adana Kebap",Price=200,CategoryId=anaYemekId},
                new Product{Name="Tavuk Şiş",Price=150,CategoryId=anaYemekId},
                new Product{Name="Hamburger Menü",Price=140,CategoryId=fastFoodId},
                new Product{Name="Çoban Salata",Price=60,CategoryId=salataId},
                new Product{Name="Ayran",Price=20,CategoryId=icecekId},
                new Product{Name="Kola",Price=35,CategoryId=icecekId}
            };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();

            for (int i = 1; i <= 10; i++)
            {
                context.RestaurantTables.Add(new RestaurantTable { Name = $"Masa {i}", Status = TableStatus.Empty });
            }
            context.SaveChanges();
        }
    }
}
