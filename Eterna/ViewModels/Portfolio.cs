using Eterna.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eterna.ViewModels
{
    public class Portfolio
    {
        public int Id { get; set; }

        public List<Category> Categories { get; set; }

        public string Client { get; set; }

        public DateTime Date { get; set; }

        public string Url { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]

        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]

        public string Desc { get; set; }

        public List<PortfolioImage> PortfolioImages { get; set; }

    }
}
