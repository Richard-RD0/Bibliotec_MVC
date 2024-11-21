using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Usuario
    {
        [Key]
      public int UsuarioID { get; set; }
      public string nome { get; set; }
      public DateOnly dtNascimento { get; set; }
      public string email { get; set; }
      public string senha { get; set; }
      public string constato { get; set; }
      public bool admin{ get; set; }
      public bool status{ get; set;} 

        [ForeignKey ("Curso")]
      public int cursoid { get; set; }
      public Curso curso { get; set; }
    }
}