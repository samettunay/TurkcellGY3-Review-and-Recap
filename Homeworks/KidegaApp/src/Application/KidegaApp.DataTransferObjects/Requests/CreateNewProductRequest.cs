﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidegaApp.DataTransferObjects.Requests
{
    public class CreateNewProductRequest
    {
        [Required(ErrorMessage = "Kurs Adını Boş Bırakmayınız!")]
        [MinLength(3, ErrorMessage = "En az 3 harf")]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Price { get; set; }
        public string? BrandName { get; set; }
        public int? TotalHours { get; set; }
        public string ImageUrl { get; set; } = "https://mybiros.com/wp-content/themes/qik/assets/images/no-image/No-Image-Found-400x264.png";
        public int? CategoryId { get; set; }
        public byte? Rating { get; set; }
    }
}
