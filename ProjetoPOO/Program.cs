using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}

class Estudante : Pessoa
{
    public string Matricula { get; set; }

    public Estudante(string nome, int idade, string matricula)
        : base(nome, idade)
    {
        Matricula = matricula;
    }

    public override void Apresentar()
    {
        Console.WriteLine($"Olá, sou um estudante chamado {Nome}, tenho {Idade} anos e minha matrícula é {Matricula}.");
    }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa("Lucas Vitiello", 27);
        Estudante estudante = new Estudante("Lucas Vitiello", 27, "1180200596");

        //Resultados do Teste 2
        pessoa.Apresentar();
        estudante.Apresentar();

        // Resultados do Teste 1
        /*
        Console.WriteLine("Teste 1: Criação de Objetos");
        Console.WriteLine($"Pessoa: {pessoa.Nome}, {pessoa.Idade} anos");
        Console.WriteLine($"Estudante: {estudante.Nome}, {estudante.Idade} anos, Matrícula: {estudante.Matricula}");
        */

        // Resultados do Teste 3
        /*
        Console.WriteLine("Teste 3: Herança e Polimorfismo");
        Console.WriteLine("Chamada de método Apresentar() em objetos de diferentes tipos:");
        Console.WriteLine("Pessoa:");
        pessoa.Apresentar();
        Console.WriteLine("Estudante:");
        estudante.Apresentar();
        */

        // Resultados do Teste 4
        // Pessoa com idade negativa (teste de encapsulamento e validação)
        /*
        try
        {
            Pessoa pessoa = new Pessoa("Alice", int.Parse("abc")); // Tentativa de criar uma pessoa com idade negativa
            Console.WriteLine("Teste 4: Encapsulamento e Validação (Exceção esperada)");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Exceção capturada: " + ex.Message);
        }
        */
    }
}


