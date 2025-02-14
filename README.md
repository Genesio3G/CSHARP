## 📝Conceitos de c#
$\color{red}{\textsf{Definição:}}$ C# (C Sharp) é uma linguagem de programação multiparadigma, de alto nível, orientada a objetos e de tipagem forte, desenvolvida pela Microsoft:

- **É uma das principais linguagens de programação no GitHub**.
- **É usada por empresas em vários setores, como mídia, finanças, saúde e jogos** .
- **É a linguagem .NET mais popular**.
- **Tem recursos como segurança de tipo, genéricos, correspondência de padrões, async e registros**.
- **É interoperável com outras linguagens de programação, especialmente aquelas que fazem parte da plataforma .NET** . [Fonte de pesquisa sobre a linguaguem](https://pt.wikipedia.org/wiki/C_Sharp#:~:text=C#%20%C3%A9%20uma%20linguagem%20de,Pascal%20e,%20principalmente,%20Java.)

## Conceito de Variavel
$\color{red}{\textsf{Variavel:}}$ é um espaço de armazenamento na memória do computador que é utilizado para guardar e manipular valores.

## Convenções para nomes e variaveis
$\color{red}{\textsf{Regras:}}$ 

- **Não deve começar com um número** ;
- **Não deve colocar caracter especial, excepto underLine(_)** ;
- **Nunca abrevie o nome da classe ou nome de propriedades** ;

## Convenções Cases
$\color{red}{\textsf{Cases:}}$ Padrão de escrita para nomes; 

- **camelCase**:Primeira letra da expressão minúsculo, a segunda expressão,  a primeira letra começa com maiúsculo, usado para nome de variaveis ;
$\color{red}{\textsf{Exemplo:}}$ nomeCompleto.

- **PascalCase**:Primeira letra da expressão maiúsculo , a segunda expressão,  a primeira letra começa com maiúsculo, usado para nome de Classes, metodos, atributos ;
$\color{red}{\textsf{Exemplo:}}$ NomeCompleto.

## Convenções para escrita de Classes
$\color{red}{\textsf{Regras:}}$ 

- **Nunca abrevie o nome da classe ou nome de propriedades** ;



## Operador de atribuição
É usado para atribuir valores a variáveis. O símbolo mais comum para o operador de atribuição é o sinal de igual (`=`)

**Exemplo**: nome = "Genesio";
						idade = 20;
						DataNascimento = "12/01/2022"
## Operadores aritméticos
São símbolos que indicam operações a serem realizadas nas expressões
Os principais operadores são:
|Operador|Expressão |
|--|--|
| +| Adição |
| - | Subtração |
| *| Multiplicação |
| / | Divisão |

## Operadores de comparação 
Um operador de comparação compara seus operandos e retorna um valor lógico(Verdadeiro ou falso).
|Operador| expressão  |int num1=10; int num2=5; int num3=10|
|--|--|--|
| == | igual | num1 == num3|
| > | maior que | num1 > num2|
| < | menor que | num1 < num2|
| >= | maior ou igual que | num1 >= num2|
| <= | menor ou igual que | num1 <= num2|
| != | diferente | num1 != num2|


## Operadores condicionais 
Os operadores condicionais são usados em programação para tomar decisões com base em condições específicas. Eles permitem que o código execute diferentes blocos de instruções dependendo do resultado de uma expressão booleana (verdadeira ou falsa).
|Operador| expressão |
|--|--|
| if | if(instrução) |
| if , else | if(instrução), else intrução |
| switch , case, default | switch(valor), case valor1, default outher case  |



## Diferença entre Convert e Int.Parse
Há diferença está no tratamento nulo, o convert retorna nulo se a informação vir vazio,entretanto no Int.PARSE não aceita nulo, apresenta erro. 

## Estrutura de Repetição
São utilizadas para executar repetidamente uma instrução ou bloco de instrução enquanto determinada condição estiver sendo satisfeita.

As principais estruturas de repetição :
 - **For**
 - **while**
 - **do/while**

### 📝 Estrutura For
O for é uma estrutura de repetição que trabalha com uma variável de controle e que repete o seu bloco de código até que um determinada condição que envolve essa variável de controle seja falsa, geralmente utilizamos a estrutura for quando sabemos a quantidade de vezes que o laço precisará ser executado.

**Estrutura**
`for (<variável de controle>, <condição de parada>, <incremento/decremento da váriavel de controle>)
{
    // Trecho de código a ser repetido
}`

## 💻 $\color{red}{\textsf{For}}$ Na Pratica 
`for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("A variável i agora vale " + i);
}`


 
### 📝 Estrutura while
O while é uma estrutura de repetição que irá repetir o bloco de código enquanto uma determinada condição for verdadeira, geralmente o while é utilizando quando não sabemos quantas vezes o trecho de código em questão deve ser repetido.

**Estrutura**
`while (<condição>)
{
    // Trecho de código a ser repetido
}`

## 💻 $\color{red}{\textsf{While}}$ Na Pratica 
```
int numero = -1;
while (numero != 10)
{
    Console.Write("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    if (numero < 10)
    {
        Console.WriteLine("Você errou, tente um número maior.");
    }
    else if (numero > 10)
    {
        Console.WriteLine("Você errou, tente um número menor.");
    }
    else
    {
        Console.WriteLine("Parabéns, você acertou!");
    }
}
```

### 📝 Estrutura do while
A estrutura do/while é bem semelhante a estrutura while, a diferença é que na estrutura do/while a condição é testada apenas ao final do loop, ou seja, o código será executado ao menos uma vez, mesmo que a condição seja falsa desde o início.

**Estrutura**
`do{
    // Trecho de código a ser repetido
}while (<condição>)
`

## 💻 $\color{red}{\textsf{Do While}}$ Na Pratica 
```
int contador = 15;
do
{
    Console.WriteLine("O contador vale: " + contador);
    contador++;
} while (contador <= 10);
```

## 📝 Conceito de Array 
É uma estrutura de dados que armazena valores do mesmo tipo, com tamanho fixo

**Estrutura**
- `int[]array = new int[5]`
- `int[]array = new int[]{42,12,7}`
- `string[]nomes = {"jan","fev"}`

$\color{red}{\textsf{Índice: }}$ É a posição de um determinado valor de um array, sempre começando com zero(0).

## 💻 $\color{red}{\textsf{Array}}$ Na Pratica 
```
string[] nomeAluno = {"Genesio","Belita","Jessica"};

for(int contador = 0; contador < nomeAluno.Length; contador++){
    Console.WriteLine(" Posição do Aluno "+contador+" Nome do Aluno "+ nomeAluno[contador]);
}

foreach(string valor  in nomeAluno){
  Console.WriteLine(valor);
}
```
## 📝 Conceito de foreach
É uma estrutura de dados que armazena valores do mesmo tipo, com tamanho fixo

**Estrutura**
- `int[]array = new int[5]`
- `int[]array = new int[]{42,12,7}`
- `string[]nomes = {"jan","fev"}`

$\color{red}{\textsf{Índice: }}$ É a posição de um determinado valor de um array, sempre começando com zero(0).

## 💻 $\color{red}{\textsf{Foreach}}$ Na Pratica 
```
string[] nomeAluno = {"Genesio","Belita","Jessica"};

for(int contador = 0; contador < nomeAluno.Length; contador++){
    Console.WriteLine(" Posição do Aluno "+contador+" Nome do Aluno "+ nomeAluno[contador]);
}

foreach(string valor  in nomeAluno){
  Console.WriteLine(valor);
}
```
## 📝 Conceitos sobre Tuplas
Tuplas são estruturas de dados que podem armazenar um número fixo de elementos, de diferentes tipos.
## 💻 $\color{red}{\textsf{Tuplas}}$ Na Pratica 
```
var tupla = (nome: "Alice", idade: 30);
Console.WriteLine($"Nome: {tupla.nome}, Idade: {tupla.idade}");
```
## 📝 Conceitos sobre Operador Ternário
O operador ternário é uma maneira concisa de escrever uma instrução if-else. Ele tem a forma condição ? valor1 : valor2.
## 💻 $\color{red}{\textsf{Operador Ternário}}$ Na Pratica 
```
int numero = 10;
string resultado = (numero % 2 == 0) ? "Par" : "Ímpar";
Console.WriteLine($"O número {numero} é {resultado}.");

```
## 📝 Conceitos sobre Desconstrução de um Objeto
A desconstrução permite extrair valores de um objeto e atribuí-los a variáveis de forma simplificada.
## 💻 $\color{red}{\textsf{Desconstrução de um Objeto}}$ Na Pratica 
```
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Deconstruct(out string nome, out int idade)
    {
        nome = Nome;
        idade = Idade;
    }
}

// Uso da desconstrução
Pessoa pessoa = new Pessoa { Nome = "Alice", Idade = 30 };
var (nome, idade) = pessoa;
Console.WriteLine($"Nome: {nome}, Idade: {idade}");

```
## 💻 $\color{red}{\textsf{,Tuplas,Operador Ternário e Desconstrução de um Objeto}}$ Na Pratica 
```
using System;

class Programa
{
    static void Main()
    {
        // Exemplo de Tupla
        var tupla = (nome: "Alice", idade: 30);
        Console.WriteLine($"Nome: {tupla.nome}, Idade: {tupla.idade}");

        // Exemplo de Operador Ternário
        int numero = 10;
        string resultado = (numero % 2 == 0) ? "Par" : "Ímpar";
        Console.WriteLine($"O número {numero} é {resultado}.");

        // Exemplo de Desconstrução
        Pessoa pessoa = new Pessoa { Nome = "Alice", Idade = 30 };
        var (nome, idade) = pessoa;
        Console.WriteLine($"Nome: {nome}, Idade: {idade}");
    }
}

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Deconstruct(out string nome, out int idade)
    {
        nome = Nome;
        idade = Idade;
    }
}

```

## 📝 Conceitos sobre Classes
```
string[] nomeAluno = {"Genesio","Belita","Jessica"};

for(int contador = 0; contador < nomeAluno.Length; contador++){
    Console.WriteLine(" Posição do Aluno "+contador+" Nome do Aluno "+ nomeAluno[contador]);
}
```
$\color{red}{\textsf{Classe: }}$ É uma abstração de um objeto do mundo real, e este objeto possui seus atributos , bem como também o tipo de ação que esse tipo de objeto tem a realizar (**métodos**).

$\color{red}{\textsf{Exemplo: }}$ Classe do tipo **Pessoa**
	

 - **Atributos**: Nome completo, Data de Nascimento, Gênero, etc...;
 - **Ações**: Saudação, dormir, acordar, andar, etc... ;

 $\color{red}{\textsf{Namespace: }}$ Caminho de um arquivo, ou é usado para organizar e agrupar tipos relacionados, como classes, interfaces, structs, enums e delegates. Eles ajudam a evitar conflitos de nomes e tornam o código mais gerenciável, especialmente em projetos grandes..

## 💻 $\color{red}{\textsf{Classe}}$ Na Pratica 

```
### namespace C_SHARP.Models
public class Pessoa

{

public string NomeCompleto { get; set; }

public int idade { get; set; }

public void Apresentacao(){

Console.Write($"O meu nome é {NomeCompleto}, tenho {idade} Anos");

}
}




$\color{green}{\textsf{using CSHARP.Models;}}$ 

Pessoa pessoa = new Pessoa();

pessoa.NomeCompleto = "Genesio Gonçalves Gabriel";
pessoa.idade = 12;
pessoa.Apresentacao();
```

## 📝 Conceitos sobre Propriedades
Propriedades permitem que uma classe exponha dados de forma controlada. Elas são usadas como métodos de acesso (getters) e modificação (setters).
## 💻 $\color{red}{\textsf{Propriedades}}$ Na Pratica 
```
class Carro
{
    private string cor;

    public string Cor
    {
        get { return cor; }
        set { cor = value; }
    }
}
```
## 📝 Conceitos sobre Métodos
Métodos são funções definidas dentro de uma classe. Eles executam ações específicas.
## 💻 $\color{red}{\textsf{Métodos}}$ Na Pratica 
```
class Carro
{
    private string cor;

    public string Cor
    {
        get { return cor; }
        set { cor = value; }
    }

    public void Dirigir()
    {
        Console.WriteLine("O carro está sendo dirigido.");
    }
}
```

## 📝 Conceitos sobre Construtores
Construtores são métodos especiais chamados quando um objeto da classe é criado. Eles são usados para inicializar objetos.
## 💻 $\color{red}{\textsf{Construtores}}$ Na Pratica 
```
class Carro
{
    private string cor;
    private string modelo;

    // Construtor padrão
    public Carro()
    {
        cor = "Desconhecida";
        modelo = "Desconhecido";
    }

    // Construtor com parâmetros
    public Carro(string cor, string modelo)
    {
        this.cor = cor;
        this.modelo = modelo;
    }

    public string Cor
    {
        get { return cor; }
        set { cor = value; }
    }

    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public void Dirigir()
    {
        Console.WriteLine($"O carro {modelo} de cor {cor} está sendo dirigido.");
    }
}
```

## 💻 $\color{red}{\textsf{propriedades, métodos e construtores}}$ Na Pratica 

``` 
using System;

class Programa
{
    static void Main()
    {
        // Usando o construtor padrão
        Carro carro1 = new Carro();
        carro1.Cor = "Vermelho";
        carro1.Modelo = "Sedan";
        carro1.Dirigir();

        // Usando o construtor com parâmetros
        Carro carro2 = new Carro("Azul", "Hatchback");
        carro2.Dirigir();
    }
}

```
