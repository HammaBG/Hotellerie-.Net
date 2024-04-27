using System.ComponentModel.DataAnnotations;

namespace Hotellerie_X.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Nom Required !")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="name length error")]
        public string Name { get; set; }
        [Range(1,5 ,ErrorMessage ="error range 1,5")]
        public int Etoiles { get; set; }
        [Required(ErrorMessage = "Ville Required !")]
        public string Ville { get; set; }
        [Required(ErrorMessage = "SiteWeb Required !")]
        [Display(Name = "Site Web")]
        [RegularExpression(@"^(http|https)://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$",
            ErrorMessage = "The url must be in this form")]
        public string SiteWeb { get; set; }
        public string Tel { get; set; }


        public virtual ICollection<Appreciation>? Appreciation { get; set; } =new  List<Appreciation>();
    }
}
