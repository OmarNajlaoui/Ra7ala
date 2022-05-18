using System.ComponentModel.DataAnnotations;

namespace Ra7ala.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        [Display(Name = "Nom")]
        public string Name { get; set; }
        [Display(Name = "Adress")]
        public string Adresse { get; set; }
        [Display(Name = "Descriprtion")]
        public string Desc { get; set; }
        public List<Kharja> Kharjas { get; set; }   
    }
}
