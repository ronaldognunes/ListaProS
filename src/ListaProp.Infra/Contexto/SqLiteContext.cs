
using ListaProp.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ListaProp.Infra.Contexto
{
    public class SqLiteContext: DbContext
    {
        public SqLiteContext(DbContextOptions<SqLiteContext> option) : base(option)
        {
            
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Lista> Listas { get; set; }
        public DbSet<Item> Itens { get; set; }
        public DbSet<ListaUsuario> ListasUsuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            
          modelBuilder.Entity<ListaUsuario>().HasKey(lu => new {lu.IdLista,lu.IdUsuario});

          modelBuilder.Entity<ListaUsuario>()
                      .HasOne<Lista>(lu=>lu.lista)
                      .WithMany(l=>l.Usuarios)
                      .HasForeignKey(lu=>lu.IdLista);

          modelBuilder.Entity<ListaUsuario>()
                      .HasOne<Usuario>(lu=> lu.usuario)
                      .WithMany(u => u.Listas)
                      .HasForeignKey(lu=> lu.IdUsuario);

          modelBuilder.Entity<Item>()
                      .HasOne<Lista>(l=> l.lista)
                      .WithMany(i=>i.Itens)
                      .HasForeignKey(l=>l.IdLista);

          modelBuilder.Entity<Item>().HasKey(i=>i.Id);                                              
          modelBuilder.Entity<Lista>().HasKey(l=>l.Id);
          modelBuilder.Entity<Usuario>().HasKey(u=>u.Id);
                                         

        

                
                
        }
    }
}