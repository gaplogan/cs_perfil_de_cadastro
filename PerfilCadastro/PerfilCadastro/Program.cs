using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfilCadastro
{
    class Program
    {
        enum Escolaridade
        {
            Fundamental, Medio, Tecnico, Superior
        }

        struct Filiacao
        {
            public string Mae, Pai;
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public char sexo;
            public Filiacao filiacao;
            public Escolaridade escolaridade;
        }
        
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa
            {
                nome = "João Silva",
                idade = 25,
                sexo = 'M',
                filiacao = new Filiacao() { Mae = "Antonietta Silva", Pai = "Pedro Silva" },
                escolaridade = Escolaridade.Superior
            };

            Pessoa p2 = new Pessoa
            {
                nome = "Lucas Ronaldo",
                idade = 32,
                sexo = 'M',
                filiacao = new Filiacao() { Mae = "Risolda Farias", Pai = "João Romulo" },
                escolaridade = Escolaridade.Medio
            };

            Pessoa p3 = new Pessoa
            {
                nome = "Ana Pereira",
                idade = 28,
                sexo = 'F',
                filiacao = new Filiacao() { Mae = "Rosa Maria", Pai = "José Pereira" },
                escolaridade = Escolaridade.Tecnico
            };

            Console.WriteLine("### CADASTRO ###");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.sexo);
            Console.WriteLine(p1.filiacao.Mae);
            Console.WriteLine(p1.filiacao.Pai);
            Console.WriteLine(p1.escolaridade);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Pressione uma tecla para exibir proximo...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("### CADASTRO ###");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.sexo);
            Console.WriteLine(p2.filiacao.Mae);
            Console.WriteLine(p2.filiacao.Pai);
            Console.WriteLine(p2.escolaridade);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Pressione uma tecla para exibir proximo...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("### CADASTRO ###");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine(p3.nome);
            Console.WriteLine(p3.idade);
            Console.WriteLine(p3.sexo);
            Console.WriteLine(p3.filiacao.Mae);
            Console.WriteLine(p3.filiacao.Pai);
            Console.WriteLine(p3.escolaridade);
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Pressione uma tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
