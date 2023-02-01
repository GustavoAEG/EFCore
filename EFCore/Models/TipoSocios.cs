using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore.Models
{
    [Table("TipoSocioL")]
    public class TipoSocios
    {
        //EF identifica como chave primaria o termo 'IdAluno'
        [Key]
        public int TipoSocioId { get; set; }
        [Required]
        public int DuracaoMeses { get; set; }
        //Mensal - Sem Desconto
        //3 meses - > 10%
        //6 meses - > 20%
        //12 meses -> 30%
        [Required]
        public int TaxaDesconto { get; set; }

    }
}
