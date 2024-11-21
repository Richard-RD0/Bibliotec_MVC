using Microsoft.EntityFrameworkCore;

   namespace Bibliotec.Contexts
{
    // Classe que terá as informações do banco de dados
    public class Context : DbContext
    {
        // Criar um método construtor
        public Context(){
        }

        public Context(DbContextOptions<Context> options) : base(options){
        }

        // OnConfiguring -> Possui a configuracao da conexao com
        //o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
                // colocar as informacoes do banco

            if (!optionsBuilder.IsConfigured){

            }   

            optionsBuilder.UsesqlSever(@"
            data source= DESKTOP-LAOSMI3\\SQLEXPRESSTEC 
            inicial catalog = Bibliotec_mvc;
            user id = sa;
            password = 123456;
            Integrated Security = true;
            TrustSeverCertificate = true");


        }

        public Dbset <Categoria> Categorias { get; set; }

        
        public Dbset <curso> curso { get; set; }

        
         public Dbset <Livro> Livro  { get; set; }

         
         public Dbset <Usuario> Usuario { get; set; }
 
    
         public Dbset <livroCategoria> livroCategoria  { get; set; }

         
         public Dbset <LivroReserva> LivroReserva  { get; set; }


    }
}     