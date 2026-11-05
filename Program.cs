
using System;

class Pessoa
{
    private string nome = "";
    private int idade;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (value != "")
                nome = value;
            else
                Console.WriteLine("Nome inválido! Valor ignorado.");
        }
    }

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value >= 0 && value <= 120)
                idade = value;
            else
                Console.WriteLine("Idade inválida! Valor ignorado.");
        }
    }

    public virtual void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }

    /*
    // FASES ANTERIORES

    public bool EhMaiorDeIdade()
    {
        return idade >= 18;
    }

    public int AnoDeNascimento(int anoAtual)
    {
        return anoAtual - idade;
    }

    public string FaixaEtaria()
    {
        if (idade < 12)
            return "Criança";
        else if (idade < 18)
            return "Adolescente";
        else
            return "Adulto";
    }
    */
}

class Aluno : Pessoa
{
    public string Curso { get; set; } = "";
    public double Nota { get; set; }

    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"Estudo {Curso} e minha nota é {Nota}.");
    }

    public string Situacao()
    {
        if (Nota >= 7)
            return "Aprovado";
        else
            return "Reprovado";
    }
}

class Professor : Pessoa
{
    public string Disciplina { get; set; } = "";

    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"Sou professor(a) de {Disciplina}.");
    }
}

class Monitor : Pessoa
{
    private int horasSemanais;

    public int HorasSemanais
    {
        get { return horasSemanais; }
        set
        {
            if (value >= 1 && value <= 20)
                horasSemanais = value;
            else
                Console.WriteLine("Horas inválidas! Valor ignorado.");
        }
    }

    public string Disciplina { get; set; } = "";

    public string ResumoDaSemana()
    {
        return $"Monitor de {Disciplina}, com {HorasSemanais} horas semanais.";
    }

    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"Sou monitor de {Disciplina}.");
        Console.WriteLine($"Horas semanais: {HorasSemanais}");
    }
}

class Program
{
    static void Main()
    {
        /*

        class Pessoa
        {
            public string Nome;
            public int Idade;

            public void Apresentar()
            {
                Console.WriteLine(
                    $"Olá, meu nome é {Nome} e tenho {Idade} anos.");
            }
        }

        Pessoa p1 = new Pessoa();
        p1.Nome = "Carlos";
        p1.Idade = 30;
        p1.Apresentar();

        Pessoa p2 = new Pessoa();
        p2.Nome = "Beatriz";
        p2.Idade = 15;
        p2.Apresentar();


        //
        string nome;
        string curso;
        double nota1;
        double nota2;
        double media;
        bool aprovado;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite seu curso: ");
        curso = Console.ReadLine();

        Console.Write("Digite a nota 1: ");
        nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        nota2 = double.Parse(Console.ReadLine());

        media = (nota1 + nota2) / 2;
        aprovado = media >= 7;

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Curso: {curso}");
        Console.WriteLine($"Nota 1: {nota1}");
        Console.WriteLine($"Nota 2: {nota2}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Aprovado: {aprovado}");


        //

        int anoAtual = 2026;

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua nota final: ");
        double nota = double.Parse(Console.ReadLine());

        int anoNascimento = anoAtual - idade;

        Console.WriteLine(
            $"Olá, {nome}! Você nasceu por volta de {anoNascimento}.");
        Console.WriteLine($"Sua nota final foi {nota}.");


        //

        p1.Idade = -50;
        p1.Apresentar();

        Console.WriteLine(p1.EhMaiorDeIdade());
        Console.WriteLine(p1.AnoDeNascimento(2026));
        Console.WriteLine(p1.FaixaEtaria());

        */

        Pessoa p = new Pessoa();
        p.Nome = "Carlos";
        p.Idade = 30;
        p.Apresentar();
        Console.WriteLine();

        Pessoa p2 = new Pessoa();
        p2.Nome = "Beatriz";
        p2.Idade = 15;
        p2.Apresentar();
        Console.WriteLine();

        Aluno a1 = new Aluno();
        a1.Nome = "Marina";
        a1.Idade = 17;
        a1.Curso = "Desenvolvimento de Sistemas";
        a1.Nota = 8.5;

        a1.Apresentar();
        Console.WriteLine($"Situação: {a1.Situacao()}");
        Console.WriteLine();

        Professor prof = new Professor();
        prof.Nome = "Roberto";
        prof.Idade = 42;
        prof.Disciplina = "Banco de Dados";

        prof.Apresentar();
        Console.WriteLine();

        Monitor monitor = new Monitor();
        monitor.Nome = "Lucas";
        monitor.Idade = 20;
        monitor.Disciplina = "C#";
        monitor.HorasSemanais = 10;

        monitor.HorasSemanais = 25;

        monitor.Apresentar();
        Console.WriteLine(monitor.ResumoDaSemana());
        Console.WriteLine();


        Console.WriteLine("=== CADASTRO DE NOVO ALUNO ===");

        Aluno novo = new Aluno();

        Console.Write("Nome: ");
        novo.Nome = Console.ReadLine() ?? "";

        Console.Write("Idade: ");
        novo.Idade = int.Parse(Console.ReadLine()!);

        Console.Write("Curso: ");
        novo.Curso = Console.ReadLine() ?? "";

        Console.Write("Nota: ");
        novo.Nota = double.Parse(Console.ReadLine()!);

        Console.WriteLine();

        novo.Apresentar();
        Console.WriteLine($"Situação final: {novo.Situacao()}");

        Console.WriteLine();
        Console.WriteLine("=== CARTÃO DE MATRÍCULA ===");

        Console.Write("Digite seu nome: ");
        string nomeMatricula = Console.ReadLine() ?? "";

        Console.Write("Digite seu curso: ");
        string cursoMatricula = Console.ReadLine() ?? "";

        Console.Write("Digite a nota 1: ");
        double nota1 = double.Parse(Console.ReadLine()!);

        Console.Write("Digite a nota 2: ");
        double nota2 = double.Parse(Console.ReadLine()!);

        double media = (nota1 + nota2) / 2;
        bool aprovado = media >= 7;

        Console.WriteLine();
        Console.WriteLine("===== CARTÃO DE MATRÍCULA =====");
        Console.WriteLine($"Nome: {nomeMatricula}");
        Console.WriteLine($"Curso: {cursoMatricula}");
        Console.WriteLine($"Nota 1: {nota1}");
        Console.WriteLine($"Nota 2: {nota2}");
        Console.WriteLine($"Média: {media}");
        Console.WriteLine($"Aprovado: {aprovado}");
        Console.WriteLine("===============================");
    }
}
