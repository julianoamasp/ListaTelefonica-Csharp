using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ListaTelefonica.Models
{
    public class ContatoContext : DbContext

    {
        public ContatoContext(DbContextOptions<ContatoContext> options)
    : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
