using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Data.Dtos
{
    public class ReadCinemaDto
    {
        
        public int Id { get; set; }
        public string nome { get; set; }        
        public ReadEnderecoDto Endereco {get; set; }
    }
}