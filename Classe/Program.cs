using Classe.Models;
using CSHARP.Models;


// Curso cursoIngles = new Curso();
// cursoIngles.NomeCurso = "Inglês";
// cursoIngles.ListarCurso();


// Aluno aluno1 = new Aluno(nome:"Genésio", sobrenome:"Gabriel");
// cursoIngles.AdicionarAluno(aluno1);

// cursoIngles.ListarAlunos();

Aluno aluno1 = new Aluno(nome: "Genésio", sobrenome: "Gabriel");
Curso cursoIngles = new Curso();
cursoIngles.AdicionarAluno(aluno1);
cursoIngles.ListarAlunos();