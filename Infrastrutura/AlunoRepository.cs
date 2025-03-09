using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDoAluno.Infrastrutura
{
   public class AlunoRepository
    {
        private readonly DbConnection _context = new DbConnection();
        public void Add(Aluno aluno)
        {
         _context.alunos.Add(aluno);
         _context.SaveChanges();
        }

        public List<Aluno> GetAll() { 
            return _context.alunos.ToList();
           
        }

    }
}
