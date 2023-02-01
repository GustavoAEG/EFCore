using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace EFCore.Models
{
    public class Aluno
    {
        [Key]
        public int IdAluno { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [StringLength(50)]
        public string Sexo { get; set; }
        [Required]
        [StringLength(150)]
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }

        [Required]
        [StringLength(150)]
        public string Foto { get; set; }
        [Required]
        [StringLength(150)]
        public string Texto { get; set; }
        
        public TipoSocios TipoSocios { get; set; }
   
    }
}
