using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDoAluno.Infrastrutura
{
    public class DbConnection : DbContext
    {
        public DbSet<Aluno> alunos { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=Portal_do_Aluno;User Id=postgres;Password=536539;");


    }
} 

