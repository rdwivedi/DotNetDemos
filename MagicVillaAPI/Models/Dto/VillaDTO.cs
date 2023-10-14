using System.ComponentModel.DataAnnotations;

namespace MagicVillaAPI.Models.Dto
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public int area { get; set; }

        public int occupency { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
