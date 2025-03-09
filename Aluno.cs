using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalDoAluno
{
    public class Aluno
    {
        public Aluno() { }
        public Aluno(string nome, string idade, string curso)
        {
            if (string.IsNullOrEmpty(nome)) {
                throw new Exception("O Nome é obrigatério");
            }
            if (string.IsNullOrEmpty(idade))
            {
                throw new Exception("A Idade é obrigatério");
            }
            if (string.IsNullOrEmpty(curso))
            {
                throw new Exception("O Curso é obrigatério");
            }


            Nome = nome;
            Idade = int.Parse(idade);
            Curso = curso;
        }

        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Curso { get; private set; }
    }
}
