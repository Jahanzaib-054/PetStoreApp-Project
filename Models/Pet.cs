using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace PetStoreApp_Project.Models
{
    public class Pet
    {
        [Key]
        public int ImgId { get; set; }
        [Required]
        public string? Name { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile? ImgFile { get; set; }
        [Required]
        public int price { get; set; }
        public string? Image { get; set; }
    }
}
