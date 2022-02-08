using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wejobr.Models
{
    [Table("Vaga")]
    public class Vaga
    {
        [Key]
        public int Cod_vaga { get; set; }

        //chave estrangeira abaixo
        public int Id_empresa { get; set; }

        [Required(ErrorMessage = "Informe o cargo da vaga")]
        [StringLength(50)]
        public String Cargo_vaga { get; set; }

        [Required(ErrorMessage = "Informe a descrição da vaga")]
        [StringLength(500)]
        public String Descricao_vaga { get; set; }
        public double Salario_vaga { get; set; }

        public Boolean Vaga_pcd { get; set; }

        [StringLength(30)]
        public String Nivel_instrucao_vaga { get; set; }

        [StringLength(30)]
        public String Localidade_vaga { get; set; }

        [StringLength(30)]
        public String Regime_contratacao_vaga { get; set; }
    }
}
