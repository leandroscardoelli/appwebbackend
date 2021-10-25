using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace appwebbackend.Models
{
    [Table("Doacao")]
    public class doacao
    {   
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o titulo")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

    }
}
