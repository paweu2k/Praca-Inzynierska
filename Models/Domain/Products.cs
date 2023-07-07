using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Praca_Inżynierska.Models.Domain
{
    public class Products
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(24)]
        public string nazwa { get; set; }
        [Required]
        [MaxLength(24)]
        public string producent { get; set; }
        [Required]
        [MaxLength(256)]
        public string opis { get; set; }
        [Required]
        [MaxLength(24)]
        public string kategoria { get; set; }
        public ICollection<Users> Users { get; set; }


    }
}
