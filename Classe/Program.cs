using Classe.Models;
using CSHARP.Models;


// Curso cursoIngles = new Curso();
// cursoIngles.NomeCurso = "Inglês";
// cursoIngles.ListarCurso();


// Aluno aluno1 = new Aluno(nome:"Genésio", sobrenome:"Gabriel");
// cursoIngles.AdicionarAluno(aluno1);

// cursoIngles.ListarAlunos();

Aluno aluno1 = new Aluno(nome: "Genésio", sobrenome: "Gabriel");
Aluno aluno2 = new Aluno(nome: "Jessica", sobrenome: "Gabriel");
Curso cursoIngles = new Curso();
cursoIngles.NomeCurso = "Inglês";
cursoIngles.Aluno = new List<Aluno>();
cursoIngles.AdicionarAluno(aluno1);
cursoIngles.AdicionarAluno(aluno2);
cursoIngles.ListarAlunos();
cursoIngles.RemoverAluno(aluno1);
cursoIngles.ListarAlunos();