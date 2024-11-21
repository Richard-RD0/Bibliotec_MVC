using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroCategoria
    {
        [Key]

        public int LivroCategoriaID { get; set; }
        [ForeignKeyAttribute("livro")]
        public int LivroID { get; set; }
        public Livro Livro { get; set; }

        [ForeignKey ("categoria")]
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}