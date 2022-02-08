using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wejobr.Models
{
    [Table("Candidato")]
    public class Candidato
    {
        [Key]
        public int Id_candidato { get; set; }

        [Required(ErrorMessage = "Informe o nome do candidato")]
        [StringLength(50)]
        public String Nome_candidato { get; set; }

        [Required(ErrorMessage = "Insira a data de nascimento")]
        public DateTime Nascimento_candidato { get; set; }
        
        [StringLength(20)]
        public String Estado_civil_candidato { get; set; }

        [StringLength(50)]
        public String Nacionalidade_candidato { get; set; }

        [Required(ErrorMessage = "Informe o RNE ou número da solicitação")]
        [StringLength(50)]
        public String Rne_candidato { get; set; }

        //chave estrangeira abaixo

        [StringLength(30)]
        public String Idioma_candidato { get; set; }

        [StringLength(50)]
        public String Email_candidato { get; set; }

        [StringLength(20)]
        public String Senha_candidato { get; set; }

        [StringLength(50)]
        public String Cargo1_candidato { get; set; }

        [StringLength(50)]
        public String Cargo2_candidato { get; set; }

        [StringLength(50)]
        public String Cargo3_candidato { get; set; }
        
        //falta o currículo (doc Word)
    }
}
