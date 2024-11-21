using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec.Models
{
    public class Livro
    {
        /*atributos
        int LivroID
        string nome 
        string escritor
        string editora
        string descricao
        string idioma
        string imagem
        bool reservado
        bool ativo */

        public int LivroID { get; set; }
        public string Name { get; set; }
        public string Escritor { get; set; }
        public string Editora { get; set; }
        public string Descricao { get; set; }
        public string Idioma { get; set; }
        public string Imagem { get; set; }
        public bool Reservado { get; set; }
        public bool Ativo { get; set; }
    }
}