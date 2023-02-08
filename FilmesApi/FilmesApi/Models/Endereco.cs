
using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O endereço não pode ser vazio")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O número não pode ser vazio")]
        public int Numero { get; set; }
        public virtual Cinema cinema { get; set; }


    }
}