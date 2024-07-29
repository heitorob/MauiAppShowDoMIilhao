using MauiAppShowDoMIilhao.Models;

namespace MauiAppShowDoMIilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Enunciado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1" },
                    new Alternativa { Correta = false, Descricao = "2" },
                    new Alternativa { Correta = false, Descricao = "3" },
                    new Alternativa { Correta = false, Descricao = "4" },
                }
            },

            new Pergunta
            {
                Id = 2,
                Enunciado = "Enunciado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1" },
                    new Alternativa { Correta = false, Descricao = "2" },
                    new Alternativa { Correta = false, Descricao = "3" },
                    new Alternativa { Correta = false, Descricao = "4" },
                }
            },

            new Pergunta
            {
                Id = 3,
                Enunciado = "Enunciado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1" },
                    new Alternativa { Correta = false, Descricao = "2" },
                    new Alternativa { Correta = false, Descricao = "3" },
                    new Alternativa { Correta = false, Descricao = "4" },
                }
            },

            new Pergunta
            {
                Id = 4,
                Enunciado = "Enunciado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1" },
                    new Alternativa { Correta = false, Descricao = "2" },
                    new Alternativa { Correta = false, Descricao = "3" },
                    new Alternativa { Correta = false, Descricao = "4" },
                }
            },

            new Pergunta
            {
                Id = 5,
                Enunciado = "Enunciado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1" },
                    new Alternativa { Correta = false, Descricao = "2" },
                    new Alternativa { Correta = false, Descricao = "3" },
                    new Alternativa { Correta = false, Descricao = "4" },
                }
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
