
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
        // Aluno antigo
        Aluno a1 = new Aluno();
        a1.Nome = "Marina";
        a1.Idade = 17;
        a1.Curso = "Desenvolvimento de Sistemas";
        a1.Nota = 8.5;

        // Professor
        Professor prof = new Professor();
        prof.Nome = "Roberto";
        prof.Idade = 42;
        prof.Disciplina = "Banco de Dados";

        // Monitor
        Monitor monitor = new Monitor();
        monitor.Nome = "Lucas";
        monitor.Idade = 20;
        monitor.Disciplina = "C#";
        monitor.HorasSemanais = 10;

        // Testando valor inválido
        monitor.HorasSemanais = 25;

        // Apresentações anteriores
        a1.Apresentar();
        Console.WriteLine($"Situação: {a1.Situacao()}");
        Console.WriteLine();

        prof.Apresentar();
        Console.WriteLine();

        monitor.Apresentar();
        Console.WriteLine(monitor.ResumoDaSemana());
        Console.WriteLine();

        // Pessoa
        Pessoa p = new Pessoa();
        p.Nome = "Carlos";
        p.Idade = 30;

        p.Apresentar();
        Console.WriteLine();

        // FASE 11 - Cadastro de aluno pelo teclado
        Console.WriteLine("=== CADASTRO DE NOVO ALUNO ===");

        Aluno novo = new Aluno();

        Console.Write("Nome: ");
        novo.Nome = Console.ReadLine();

        Console.Write("Idade: ");
        novo.Idade = int.Parse(Console.ReadLine());

        Console.Write("Curso: ");
        novo.Curso = Console.ReadLine();

        Console.Write("Nota: ");
        novo.Nota = double.Parse(Console.ReadLine());

        Console.WriteLine();

        novo.Apresentar();

        Console.WriteLine($"Situação final: {novo.Situacao()}");
    }
}
