using Eterna.ViewModels;

namespace Eterna.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PortfolioId { get; set; }

        public Portfolio Portfolio { get; set; }
    }
}
