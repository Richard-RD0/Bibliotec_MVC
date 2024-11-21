using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class LivroReserva
    {
        [Key]
        public int LivroReservaID { get; set; }

    public DateOnly dtreserva{get; set;}
    public DateOnly dtdevolucao{get; set;}
    public int status{get; set;}
    
    [ForeignKey ("usuario")]
    public int usuarioID { get; set; }

    [ForeignKey ("livro")]
    public Livro livro{ get; set; }
    }
}