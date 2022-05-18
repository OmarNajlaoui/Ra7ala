using System.ComponentModel.DataAnnotations;

namespace Ra7ala.Models
{
    public class Organisateur
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nom")]
        public String Name { get; set; }
        [Display(Name = "Image")]
        public String Photo { get; set; }
        [Display(Name = "Aprops")]
        public String Desc { get; set; }
        public List<Kharja> Kharjas { get; set; }    
    }
}
