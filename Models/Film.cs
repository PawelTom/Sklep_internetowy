using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Sklep_internetowy.Models
{
    public class Film
    {

        //klucz glowny

        //inne opcje id lub anotacja key
        public int FilmId { get; set; }



        [Required(ErrorMessage ="Wpisz tytuł")]
        public string Title { get; set; }

        public string Director { get; set; }


        [StringLength(200)]
        public string Desc { get; set; }

        //klucz obcy
        //inne opcje: CategoryCategoryId
        //[ForeignKey ("Category")]
        public int CategoryId { get; set; }




        public Category Category { get; set; }





    }
}
