using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe.Models
{
    public class Aluno
    {

        public Aluno(string nome, string sobrenome){
                Nome = nome;
                Sobrenome = sobrenome;
        }

        public int Id { get; set;}
        public string Nome { get; set;}

        public string Sobrenome { get; set;}
    }
}