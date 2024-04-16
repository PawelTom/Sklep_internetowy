using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


        [StringLength(500)]
        public string Desc { get; set; }


        public double? Price { get; set; }

        public DateTime? AddDate { get; set; }

        public string? Poster { get; set; }

        //klucz obcy
        //inne opcje: CategoryCategoryId
        //[ForeignKey ("Category")]
        public int CategoryId { get; set; }




        public Category Category { get; set; }





    }
}
