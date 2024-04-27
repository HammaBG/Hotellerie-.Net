using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotellerie_X.Models.HotellerieModel
{
    public class Appreciation
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Nom Required !")]
        [Display(Name = "Nom Personne")]
        public string NomPers { get; set; }
        [Required(ErrorMessage = "Comm Required !")]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; }
        [ForeignKey("Hotel")]
        public int HotelId { get; set; }
        public Hotel? Hotel { get; set; } = null;
    }
}
