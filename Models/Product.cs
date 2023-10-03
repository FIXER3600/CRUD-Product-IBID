using System.ComponentModel.DataAnnotations;

namespace ProductProject.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do produto")]
        public string Nome { get; set; }
    }
}
