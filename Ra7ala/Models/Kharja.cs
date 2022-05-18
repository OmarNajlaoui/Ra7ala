using Ra7ala.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ra7ala.Models
{
    public class Kharja
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Prix { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public KharjaCategorie KharjaCategorie { get; set; }
         

        public List<Kharja_sites> kharja_Sites { get; set; }   
        //organisateur relation 
        public int OrganisateurId { get; set; }
        [ForeignKey("OrganisateurId")]
        public Organisateur Organisateur { get; set; }
        public int HotelId { get; set; }
        [ForeignKey("HotelId")]
        public Hotel Hotel { get; set; }
    }
}

