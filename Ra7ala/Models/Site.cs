using System.ComponentModel.DataAnnotations;

namespace Ra7ala.Models
{
    public class Site 
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        [Display(Name = "Nom")]
        public string Name { get; set; }
        [Display(Name = "Adress")]
        [Required(ErrorMessage ="Passer l'add svp")]
        public string Adresse { get; set; }
        [Display(Name = "Descriprtion")]
        public string Desc { get; set; }
        //relationsd
        public List<Kharja_sites> kharja_Sites { get; set; }


    }
}
