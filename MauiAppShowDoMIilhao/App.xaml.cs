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
                Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "RIO DE JANEIRO" },
                    new Alternativa { Correta = false, Descricao = "SANTA CATARINA" },
                    new Alternativa { Correta = false, Descricao = "GOIÁS" },
                    new Alternativa { Correta = true, Descricao = "RIO GRANDE DO SUL" },
                }
            },

            new Pergunta
            {
                Id = 2,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "GASOSO" },
                    new Alternativa { Correta = true, Descricao = "SÓLIDO" },
                    new Alternativa { Correta = false, Descricao = "LÍQUIDO" },
                    new Alternativa { Correta = false, Descricao = "VAPOROSO" },
                }
            },

            new Pergunta
            {
                Id = 3,
                Enunciado = "Qual era o apelido da cantora Elis Regina?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "GAUCHINHA" },
                    new Alternativa { Correta = false, Descricao = "PAULISTINHA" },
                    new Alternativa { Correta = true, Descricao = "PIMENTINHA" },
                    new Alternativa { Correta = false, Descricao = "ANDORINHA" },
                }
            },

            new Pergunta
            {
                Id = 4,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARGARIDA" },
                    new Alternativa { Correta = true, Descricao = "MINNIE" },
                    new Alternativa { Correta = false, Descricao = "A PEQUENA SEREIA" },
                    new Alternativa { Correta = false, Descricao = "OLIVIA PALITO" },
                }
            },

            new Pergunta
            {
                Id = 5,
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "CUCA" },
                    new Alternativa { Correta = false, Descricao = "NEGUINHO DO PASTOREIO" },
                    new Alternativa { Correta = false, Descricao = "BOITATÁ" },
                    new Alternativa { Correta = true, Descricao = "SACI-PERERÊ" },
                }
            },

            new Pergunta
            {
                Id = 6,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "JAMAICA" },
                    new Alternativa { Correta = true, Descricao = "CUBA" },
                    new Alternativa { Correta = false, Descricao = "EL SALVADOR" },
                    new Alternativa { Correta = false, Descricao = "MÉXICO" },
                }
            },

            new Pergunta
            {
                Id = 7,
                Enunciado = "Quem proclamou a república no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa { Correta = true, Descricao = "MARECHAL DEODORO" },
                    new Alternativa { Correta = false, Descricao = "DUQUE DE CAXIAS" },
                    new Alternativa { Correta = false, Descricao = "MARECHAL RONDON" },
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO II" },
                }
            },

            new Pergunta
            {
                Id = 8,
                Enunciado = "Quem é o patrono do exército brasileiro?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "MARECHAL DEODORO" },
                    new Alternativa { Correta = true, Descricao = "DUQUE DE CAXIAS" },
                    new Alternativa { Correta = false, Descricao = "MARECHAL RONDON" },
                    new Alternativa { Correta = false, Descricao = "DOM PEDRO II" },
                }
            },

            new Pergunta
            {
                Id = 9,
                Enunciado = "Quem era o apresentador que reprovava os calouros tocando uma buzina?",
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
                Id = 10,
                Enunciado = "O que era Frankenstein, de Mary Shelley?",
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
                Id = 11,
                Enunciado = "Qual é o signo do zodíaco de quem nasce no dia do ano-novo?",
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
                Id = 12,
                Enunciado = "Quem fundou a fábrica de automóveis Ford?",
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
                Id = 13,
                Enunciado = "Qual é a cor que se associa com os grupos ecológicos?",
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
                Id = 14,
                Enunciado = "A água ferve a quantos graus centígrados?",
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
                Id = 15,
                Enunciado = "Quando é comemorado o dia da independência do Brasil?",
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
                Id = 16,
                Enunciado = "Qual lugar é também chamado de Santa Sé?",
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
                Id = 17,
                Enunciado = "Quem tem por lema a frase: “Sempre alerta”?",
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
                Id = 18,
                Enunciado = "Quem foi o grande amor de Julieta?",
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
                Id = 19,
                Enunciado = "Quantos signos formam o zodíaco?",
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
                Id = 20,
                Enunciado = "Vatapá é uma comida típica de qual estado?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1" },
                    new Alternativa { Correta = false, Descricao = "2" },
                    new Alternativa { Correta = false, Descricao = "3" },
                    new Alternativa { Correta = false, Descricao = "4" },
                }
            }
        };

        List<Pergunta> perguntas_medias = new()
        {
            new Pergunta
            {
                Id = 21,
                Enunciado = "Quantos jogadores um jogo de vôlei reúne na quadra?",
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
                Id = 22,
                Enunciado = "Qual é o país do tango?",
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
                Id = 23,
                Enunciado = "Que imperador pôs fogo em Roma?",
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
                Id = 24,
                Enunciado = "A cidade de Pompéia, que foi soterrada por um vulcão fica em qual desses países?",
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
                Id = 25,
                Enunciado = "Como é chamado quem nasce em Milão, na Itália?",
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
                Id = 26,
                Enunciado = "Que profissional usa uma ferramenta chamada formão?",
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
                Id = 27,
                Enunciado = "Em qual estádio Pelé marcou seu milésimo gol?",
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
                Id = 28,
                Enunciado = "O que é um oboé?",
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
                Id = 29,
                Enunciado = "Como eram chamados os pilotos suicidas da Segunda Guerra?",
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
                Id = 30,
                Enunciado = "O que é gôndola?",
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
                Id = 31,
                Enunciado = "Sashimi é um prato originário de qual país?",
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
                Id = 32,
                Enunciado = "Como é chamada a cantora que representa o papel principal em uma ópera?",
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
                Id = 33,
                Enunciado = "O alpinismo é praticado em que lugar?",
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
                Id = 34,
                Enunciado = "O Coliseu é um monumento histórico de que cidade européia?",
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
                Id = 35,
                Enunciado = "Qual é o ponto mais alto da Terra?",
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
                Id = 36,
                Enunciado = "Que rio corta a cidade de Londres, na Inglaterra?",
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
                Id = 37,
                Enunciado = "Quem foi eleito presidente da África do Sul em 1994?",
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
                Id = 38,
                Enunciado = "Qual cantor ficou conhecido como “O rei da voz”?",
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
                Id = 39,
                Enunciado = "Qual é a sigla da Organização das Nações Unidas?",
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
                Id = 40,
                Enunciado = "De quantos em quantos anos aparece o cometa Halley?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao = "1" },
                    new Alternativa { Correta = false, Descricao = "2" },
                    new Alternativa { Correta = false, Descricao = "3" },
                    new Alternativa { Correta = false, Descricao = "4" },
                }
            }
        };

        List<Pergunta> perguntas_dificeis = new()
        {
            new Pergunta
            {
                Id = 41,
                Enunciado = "Em qual espécie o macho choca os ovos e a fêmea procura alimento?",
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
                Id = 42,
                Enunciado = "Em qual país está localizado o “Muro das lamentações”?",
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
                Id = 43,
                Enunciado = "Qual desses países não fica na Ásia?",
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
                Enunciado = "Qual desses astros de filmes de ação é belga?",
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
                Id = 45,
                Enunciado = "O que significa literalmente Perestroika?",
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
                Id = 46,
                Enunciado = "Onde foi conduzida a vitória das forças aliadas na Segunda Guerra Mundial?",
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
                Id = 47,
                Enunciado = "Onde nasceu Van Gogh, o grande pintor impressionista?",
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
                Id = 48,
                Enunciado = "Qual é a primeira letra do alfabeto gregoo?",
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
                Id = 49,
                Enunciado = "Qual presidente brasileiro instituiu o AI-5?",
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
                Id = 50,
                Enunciado = "Qual desses quatro pesos é o mais leve?",
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
                Id = 51,
                Enunciado = "Brahma é o deus de que religião?",
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
                Id = 52,
                Enunciado = "Os nazistas foram julgados em?",
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
                Id = 53,
                Enunciado = "ue ramo da pecuária ocupa-se de bodes e cabras?",
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
                Id = 54,
                Enunciado = "Qual oceano tem o maior volume de água?",
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
                Id = 55,
                Enunciado = "Qual foi o último presidente militar do Brasil?",
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
                Id = 56,
                Enunciado = "Que conflito ideológico envolveu os EUA e a União Soviética?",
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
                Id = 57,
                Enunciado = "O trapézio é um músculo que está situado:",
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
                Id = 58,
                Enunciado = "Quem escreveu o livro “A sangue frio” em 1966?",
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
                Id = 59,
                Enunciado = "Quem escreveu “Ulisses” em 1922?",
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
                Id = 60,
                Enunciado = "Qual o símbolo químico do radônio?",
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
