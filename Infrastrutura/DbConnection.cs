using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDoAluno.Infrastrutura
{
    public class DbConnection: IDisposable
    {
        public NpgsqlConnection Connection { get; set; }

        public DbConnection() {
             Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=Portal_do_Aluno;User Id=postgres;Password=536539;");
             Connection.Open();

        }
        

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
} 
