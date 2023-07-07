using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Praca_Inżynierska.Models.Domain
{
    public class Users
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(24)]
        public string login { get; set; }
        [Required]
        [MaxLength(24)]
        public string haslo { get; set; }
        [Required]
        [MaxLength(3)]
        public string czy_admin { get; set; }

        [Required]
        [MaxLength(24)]
        public string imie { get; set; }
        [Required]
        [MaxLength(24)]
        public string nazwisko { get; set; }
        [Required]
        [MaxLength(24)]
        public string ulica { get; set; }
        [Required]
        [MaxLength(24)]
        public string numer_domu { get; set; }
        [Required]
        [MaxLength(24)]
        public string email { get; set; }
        
        public ICollection<Products> Products { get; set; }
    }
}
