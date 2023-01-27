using System.Linq;
namespace SportsStore.Models
{
    public class EFHaberRepository : IHaberRepository
    {
        private HaberDbContext _context;
        public EFHaberRepository(HaberDbContext context)
        {
            _context = context;
        }
        public IQueryable<Haber> Habers => _context.Habers;
        public void CreateHaber(Haber h)
        {
            _context.Add(h);
            _context.SaveChanges();
        }
        public void DeleteHaber(Haber h)
        {
            _context.Remove(h);
            _context.SaveChanges();
        }
        public void SaveHaber(Haber h)
        {
            _context.SaveChanges();            
        }

    }
}
