using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class ReadFilmeDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = " O genero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A duracao não pode ser maior que 600 ou menor que 1")]
        public int Duracao { get; set; }

        public DateTime HoraDaConsulta { get; set; }

    }
}
