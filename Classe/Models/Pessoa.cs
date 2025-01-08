namespace CSHARP.Models
{
    public class Pessoa

    {

        public string? NomeCompleto { get; set; }

        public int idade { get; set; }

        public void Apresentacao()
        {

            Console.Write($"O meu nome é {NomeCompleto}, tenho {idade} Anos");

        }

    }
}