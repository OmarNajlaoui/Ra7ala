using Ra7ala.Data;
using Ra7ala.Models;

namespace Ra7ala.data
{
    public class AppDbInitilisation
    {

        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope =applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

              


                if (!context.Organisateurs.Any())
                {
                    context.Organisateurs.AddRange(new List<Organisateur>()
                    {
                        new Organisateur()
                        {
                            Name = "Organisateur 1",
                            Photo = "https://previews.123rf.com/images/apoev/apoev1902/apoev190200057/116730476-.jpg",
                            Desc = "foulen ben foulen el fouleni"
                        },
                        new Organisateur()
                        {
                            Name = "Organisateur 2",
                            Photo = "https://previews.123rf.com/images/apoev/apoev1902/apoev190200057/116730476-.jpg",
                            Desc = "foulen ben foulen el fouleni"
                        },
                        new Organisateur()
                        {
                            Name = "Organisateur 3",
                            Photo = "https://previews.123rf.com/images/apoev/apoev1902/apoev190200057/116730476-.jpg",
                            Desc = "foulen ben foulen el fouleni"
                        },
                         new Organisateur()
                        {
                            Name = "Organisateur 4",
                            Photo = "https://previews.123rf.com/images/apoev/apoev1902/apoev190200057/116730476-.jpg",
                            Desc = "foulen ben foulen el fouleni"
                        },
                         new Organisateur()
                        {
                            Name = "Organisateur 5",
                            Photo = "https://previews.123rf.com/images/apoev/apoev1902/apoev190200057/116730476-.jpg",
                            Desc = "foulen ben foulen el fouleni"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Sites.Any())
                {
                    context.Sites.AddRange(new List<Site>()
                    {
                        new Site()
                        {
                            Name = "Site 1",
                            Adresse = "Blasa",
                            Desc = "Blasa tel et tel",
                            ImageUrl = "https://www.paris-hotel-quintinie.com/wp-content/uploads/sites/283/2018/01/eiffel.jpg"

                        },
                        new Site()
                        {
                            Name = "Site 2",
                            Adresse = "Blasa",
                            Desc = "Blasa tel et tel",
                            ImageUrl = "https://www.paris-hotel-quintinie.com/wp-content/uploads/sites/283/2018/01/eiffel.jpg"

                        },
                        new Site()
                        {
                            Name = "Site 3",
                            Adresse = "Blasa",
                            Desc = "Blasa tel et tel",
                            ImageUrl = "https://www.paris-hotel-quintinie.com/wp-content/uploads/sites/283/2018/01/eiffel.jpg"

                        },
                        new Site()
                        {
                            Name = "Site 4",
                            Adresse = "Blasa",
                            Desc = "Blasa tel et tel",
                            ImageUrl = "https://www.paris-hotel-quintinie.com/wp-content/uploads/sites/283/2018/01/eiffel.jpg"

                        },
                       new Site()
                        {
                            Name = "Site 5",
                            Adresse = "Blasa",
                            Desc = "Blasa tel et tel",
                            ImageUrl = "https://www.paris-hotel-quintinie.com/wp-content/uploads/sites/283/2018/01/eiffel.jpg"

                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Hotels.Any())
                {
                    context.Hotels.AddRange(new List<Hotel>()
                    {
                        new Hotel()
                        {
                            Name = "Hotel 1",
                            Adresse= "blassa mou3yana",
                            Desc = "hedha hotel tayara",
                            ImageUrl = "https://www.dekra-product-safety.com/sites/default/files/field_section_background_image/building_placeholder_500x332.png"

                        },
                       new Hotel()
                        {
                            Name = "Hotel 2",
                            Adresse= "blassa mou3yana",
                            Desc = "hedha hotel tayara",
                            ImageUrl = "https://www.dekra-product-safety.com/sites/default/files/field_section_background_image/building_placeholder_500x332.png"

                        },
                        new Hotel()
                        {
                            Name = "Hotel 3",
                            Adresse= "blassa mou3yana",
                            Desc = "hedha hotel tayara",
                            ImageUrl = "https://www.dekra-product-safety.com/sites/default/files/field_section_background_image/building_placeholder_500x332.png"

                        },
                        new Hotel()
                        {
                            Name = "Hotel 4",
                            Adresse= "blassa mou3yana",
                            Desc = "hedha hotel tayara",
                            ImageUrl = "https://www.dekra-product-safety.com/sites/default/files/field_section_background_image/building_placeholder_500x332.png"

                        },
                       new Hotel()
                        {
                            Name = "Hotel 5",
                            Adresse= "blassa mou3yana",
                            Desc = "hedha hotel tayara",
                            ImageUrl = "https://www.dekra-product-safety.com/sites/default/files/field_section_background_image/building_placeholder_500x332.png"

                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Kharjet.Any())
                {
                    context.Kharjet.AddRange(new List<Kharja>()
                    {
                        new Kharja()
                        {
                            Name = "Kharja 1",
                            Desc = "5arja l blasa  el foulaniyan",
                            Prix = 10000,
                            ImageUrl = "https://visa-platinum.com/images/default/vte/travel-experience-1x.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            OrganisateurId = 3,
                            HotelId = 3,
                            KharjaCategorie = KharjaCategorie.Chill_Relax
                        },
                        new Kharja()
                        {
                            Name = "Kharja 1",
                            Desc = "5arja l blasa  el foulaniyan",
                            Prix = 10000,
                            ImageUrl = "https://visa-platinum.com/images/default/vte/travel-experience-1x.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            OrganisateurId = 1,
                            HotelId = 1,
                            KharjaCategorie = KharjaCategorie.Chill_Relax
                        },
                       new Kharja()
                        {
                            Name = "Kharja 1",
                            Desc = "5arja l blasa  el foulaniyan",
                            Prix = 10000,
                            ImageUrl = "https://visa-platinum.com/images/default/vte/travel-experience-1x.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            OrganisateurId = 4,
                            HotelId = 4,
                            KharjaCategorie = KharjaCategorie.Chill_Relax
                        },
                       new Kharja()
                        {
                            Name = "Kharja 1",
                            Desc = "5arja l blasa  el foulaniyan",
                            Prix = 10000,
                            ImageUrl = "https://visa-platinum.com/images/default/vte/travel-experience-1x.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            OrganisateurId = 1,
                            HotelId = 2,
                            KharjaCategorie = KharjaCategorie.Chill_Relax
                        },
                       new Kharja()
                        {
                            Name = "Kharja 1",
                            Desc = "5arja l blasa  el foulaniyan",
                            Prix = 10000,
                            ImageUrl = "https://visa-platinum.com/images/default/vte/travel-experience-1x.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            OrganisateurId = 1,
                            HotelId = 3,
                            KharjaCategorie = KharjaCategorie.Chill_Relax
                        },
                        new Kharja()
                        {
                            Name = "Kharja 1",
                            Desc = "5arja l blasa  el foulaniyan",
                            Prix = 10000,
                            ImageUrl = "https://visa-platinum.com/images/default/vte/travel-experience-1x.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            OrganisateurId = 1,
                            HotelId = 5,
                            KharjaCategorie = KharjaCategorie.Chill_Relax
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Kharja_Sites.Any())
                {
                    context.Kharja_Sites.AddRange(new List<Kharja_sites>()
                    {
                        new Kharja_sites()
                        {
                            SiteId = 1,
                            KharjaId = 1
                        },
                        new Kharja_sites()
                        {
                            SiteId = 3,
                            KharjaId = 1
                        },

                         new Kharja_sites()
                        {
                            SiteId = 1,
                            KharjaId = 2
                        },
                         new Kharja_sites()
                        {
                            SiteId = 4,
                            KharjaId = 2
                        },

                        new Kharja_sites()
                        {
                            SiteId = 1,
                            KharjaId = 3
                        },
                        new Kharja_sites()
                        {
                            SiteId = 2,
                            KharjaId = 3
                        },
                       new Kharja_sites()
                        {
                            SiteId = 5,
                            KharjaId = 3
                        },


                        new Kharja_sites()
                        {
                            SiteId = 2,
                            KharjaId = 4
                        },
                       new Kharja_sites()
                        {
                            SiteId = 3,
                            KharjaId = 4
                        },
                        new Kharja_sites()
                        {
                            SiteId = 4,
                            KharjaId = 4
                        },

                       new Kharja_sites()
                        {
                            SiteId = 2,
                            KharjaId = 5
                        },
                        new Kharja_sites()
                        {
                            SiteId = 3,
                            KharjaId = 5
                        },
                        new Kharja_sites()
                        {
                            SiteId = 4,
                            KharjaId = 5
                        },
                        new Kharja_sites()
                        {
                            SiteId = 5,
                            KharjaId = 5
                        },


                       new Kharja_sites()
                        {
                            SiteId = 3,
                            KharjaId = 6
                        },
                        new Kharja_sites()
                        {
                            SiteId = 4,
                            KharjaId = 6
                        },
                       new Kharja_sites()
                        {
                            SiteId = 5,
                            KharjaId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}
