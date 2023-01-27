using System.Collections.Generic;
using SportsStore.Models;
namespace SportsStore.Models.ViewModels
{
    public class HabersListViewModel
    {
        public IEnumerable<Haber> Habers { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
