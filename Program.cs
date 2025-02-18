
using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Cleuris", sobrenome: "Adão");

Pessoa p2 = new Pessoa("Eduardo", "Queiroz");

Curso cursoIngles = new Curso();
cursoIngles.Nome = "Ingles";
cursoIngles.Alunos = new List<Pessoa>();

cursoIngles.AdicionarAluno(p1);
cursoIngles.AdicionarAluno(p2);
cursoIngles.ListarAlunos();


