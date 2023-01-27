using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SportsStore.Models
{
    public class Haber
    {
        public long HaberID { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Haber Adı Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Açıklama Giriniz")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Lütfen Bir ResimUrl Giriniz")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Kategori Belirtiniz")]
        public string Category { get; set; }
    }
}
