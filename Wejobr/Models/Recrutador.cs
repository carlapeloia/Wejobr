using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wejobr.Models
{
    [Table("Recrutador")]
    public class Recrutador
    {
        [Key]
        public int Id_recrutador { get; set; }

        //chave estrangeira abaixo

        [StringLength(50)]
        public String Nome_empresa { get; set; }

        //chave estrangeira abaixo
        public int Id_empresa { get; set; }

        [StringLength(50)]
        public String Nome_recrutador { get; set; }

        [StringLength(50)]
        public String Cargo_recrutador { get; set; }

        [StringLength(50)]
        public String Departamento_recrutador { get; set; }

        [StringLength(50)]
        
        public String Email_recrutador { get; set; }

        [StringLength(20)]
        public String Tel_recrutador {get;set; }

        [StringLength(50)]
        public String Contato2_recrutador { get; set; }

        [StringLength(20)]
        public String Senha_recrutador { get; set; }

    }
}
