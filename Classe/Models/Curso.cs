using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classe.Models
{
    public class Curso
    {
        public List<Aluno>? Aluno { get; set; }
        private string? nomeCurso;

        public string NomeCurso
        {
            get
            {
                return nomeCurso!;
            }
            set
            {

                if (value == "")
                {
                    Console.WriteLine("O nome não pode estar vazio ");
                }
                else
                {
                    nomeCurso = value;

                }
            }
        }

        public void ListarCurso()
        {
            Console.WriteLine($"Curso :{nomeCurso}");
        }

        public void AdicionarAluno(Aluno aluno)
        {
            Aluno?.Add(aluno);
            Console.WriteLine($"Aluno {aluno.Nome} {aluno.Sobrenome} adicionado com sucesso");
        }
        public int ObterQuantidadeDeAluno()
        {
            int quantidade = Aluno!.Count();
            return quantidade;
        }

        public void RemoverAluno(Aluno aluno)
        {
            Aluno?.Remove(aluno);
        }

        public void ListarAlunos()
        {
            if (Aluno == null || Aluno.Count == 0)
            {
                Console.WriteLine("Nenhum aluno encontrado.");
                return;
            }
            Console.WriteLine("Lista de Alunos");   
            foreach (Aluno aluno in Aluno)
            {
                
                Console.WriteLine(aluno.Nome +" "+aluno.Sobrenome);
            }
        }
    }



}