using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wejobr.Models
{
    [Table("Idioma")]
    public class Idioma
    {
        [Key]
        public int Id_idioma { get; set; }

        [StringLength(30)]
        public String Nome_idioma { get; set; }

        [StringLength(30)]
        public String Nivel_leitura_idioma { get; set; }

        [StringLength(30)]
        public String Nivel_escrita_idioma { get; set; }

        [StringLength(30)]
        public String Nivel_conversacao_idioma { get; set; }
    }
}
