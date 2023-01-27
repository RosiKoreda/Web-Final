using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace SportsStore.Models
{
    public static class HaberSeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            HaberDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<HaberDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Habers.Any())
            {
                context.Habers.AddRange(
                    new Haber
                    {
                        Name = "Haber1",
                        Description = "Haber1 Açıklama",
                        ImageUrl = "https://i4.hurimg.com/i/hurriyet/75/647x485/63cab5744e3fe11624d2893f.jpg",
                        Category = "Siyaset"
                    },
                    new Haber
                    {
                        Name = "Haber2",
                        Description = "Haber2 Açıklama",
                        ImageUrl = "https://iasbh.tmgrup.com.tr/7ae563/425/362/0/0/752/640?u=https://isbh.tmgrup.com.tr/sbh/2023/01/20/son-dakika-fenerbahce-haberi-flas-jorge-jesus-sozleri-o-dakikayi-bekledigini-biliyorduk-1674186460771.jpg",
                        Category = "Spor"
                    },
                    new Haber
                    {
                        Name = "Haber3",
                        Description = "Haber3 Açıklama",
                        ImageUrl = "https://iasbh.tmgrup.com.tr/e7936e/425/362/0/0/752/640?u=https://isbh.tmgrup.com.tr/sbh/2023/01/20/anne-olmak-beni-baska-biri-yapti-1674167133392.jpg",
                        Category = "Magazin"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}
