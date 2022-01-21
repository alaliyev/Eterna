using Eterna.ViewModels;

namespace Eterna.Models
{
    public class PortfolioImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int PortfolioId { get; set; }
        public Portfolio Portfolio { get; set; }
    }
}
