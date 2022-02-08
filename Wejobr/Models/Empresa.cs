using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wejobr.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        [Key]
        public int Id_empresa { get; set; }

        //chave estrangeira abaixo
        public int Cod_vaga { get; set; }

        [Required(ErrorMessage = "Informe o nome da Empresa")]
        [StringLength(50)]
        public String Nome_empresa { get; set; }

        [Required(ErrorMessage = "Informe o número de registro da Empresa")]
        [StringLength(20)]
        public String Cnpj_empresa { get; set; }

        [StringLength(15)]
        public String Cep_empresa { get; set; }

        [StringLength(30)]
        public String Ramo_empresa { get; set; }

        [StringLength(20)]
        public String Telefone_empresa { get; set; }

        [StringLength(50)]
        public String Linkedin_empresa { get; set; }

    }
}
