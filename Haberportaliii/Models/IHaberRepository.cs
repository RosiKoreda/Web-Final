using System.Linq;
namespace SportsStore.Models
{
    public interface IHaberRepository
    {
        IQueryable<Haber> Habers { get; }
        void SaveHaber(Haber h);
        void CreateHaber(Haber h);
        void DeleteHaber(Haber h);
    }
}
