using Microsoft.AspNetCore.Mvc;
using ProjetoGilsonDaniel_RollSP.Models;

namespace ProjetoGilsonDaniel_RollSP.Controllers
{
    public class QuizFundacaoSantos : Controller
    {
        public IActionResult Index()
        {
            var usu = new Usuario
            {
                Id = 1,
                Quizzes = new List<Quiz>
                {
                     new Quiz
                    {
                        Id = 1,
                        Titulo = "A fundação de Santos",
                        TextoIntrodutorio = "Santos é uma das cidades mais antigas do Brasil, situada no litoral do estado de São Paulo. Sua fundação remonta ao século XVI, quando foi estabelecida por Brás Cubas, um explorador português. Em 1546, Brás Cubas fundou um hospital e uma capela, que foram os primeiros edifícios construídos na região. A cidade rapidamente se tornou um importante porto devido à sua localização estratégica, facilitando o comércio entre o Brasil e a Europa.\n\nDurante o período colonial, Santos prosperou com a exportação de açúcar, café e outros produtos agrícolas. No século XIX, a cidade também se destacou na luta contra a escravidão, sendo um dos principais centros do movimento abolicionista. A ferrovia São Paulo Railway, inaugurada em 1867, conectava Santos a Jundiaí e foi fundamental para o escoamento da produção cafeeira do interior paulista até o porto.\n\nHoje, Santos é conhecida por suas praias, seu porto movimentado e seu rico patrimônio histórico. A cidade continua a ser um ponto vital para o comércio e a cultura no estado de São Paulo.",
                        Questoes = new List<Acervo>
                        {
                            new Acervo
                            {
                                Id = 1,
                                Pergunta = "1- Quem fundou a cidade de Santos?",
                                RespostaCorreta = "B) Brás Cubas",
                                Alternativas = new List<string> { "A) Martim Afonso de Sousa", "B) Brás Cubas", "C) Duarte Coelho", "D) Pedro Álvares Cabral",  }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "2- Em que ano foi fundada a cidade de Santos?",
                                RespostaCorreta = "B) 1546",
                                Alternativas = new List<string> { "A) 1500", "B) 1546", "C) 1600", "D) 1630" }
                            },
                            new Acervo
                            {
                                Id = 3,
                                Pergunta = "3- Qual produto agrícola foi fundamental para a prosperidade de Santos durante o período colonial?",
                                RespostaCorreta = "C) Café",
                                Alternativas = new List<string> { "A) Algodão", "B) Milho", "C) Café", "D) Cana-de-açúcar" }
                            },
                        }
                    }
                }
            };

            ViewBag.Usuario = usu;
            ViewBag.Quiz = usu.Quizzes[0];

            return View();
        }


        // -------------------------------------------------------------------------------------------------------------

        [HttpPost]
        public IActionResult Resultado(List<string> respostas)
        {
          
            var usu = new Usuario
            {
                Id = 1,
                Quizzes = new List<Quiz>
                {
                    new Quiz
                    {
                        Id = 1,
                        Titulo = "A fundação de Santos",
                        TextoIntrodutorio = "Santos é uma das cidades mais antigas do Brasil, situada no litoral do estado de São Paulo. Sua fundação remonta ao século XVI, quando foi estabelecida por Brás Cubas, um explorador português. Em 1546, Brás Cubas fundou um hospital e uma capela, que foram os primeiros edifícios construídos na região. A cidade rapidamente se tornou um importante porto devido à sua localização estratégica, facilitando o comércio entre o Brasil e a Europa.\n\nDurante o período colonial, Santos prosperou com a exportação de açúcar, café e outros produtos agrícolas. No século XIX, a cidade também se destacou na luta contra a escravidão, sendo um dos principais centros do movimento abolicionista. A ferrovia São Paulo Railway, inaugurada em 1867, conectava Santos a Jundiaí e foi fundamental para o escoamento da produção cafeeira do interior paulista até o porto.\n\nHoje, Santos é conhecida por suas praias, seu porto movimentado e seu rico patrimônio histórico. A cidade continua a ser um ponto vital para o comércio e a cultura no estado de São Paulo.",
                        Questoes = new List<Acervo>
                        {
                            new Acervo
                            {
                                Id = 1,
                                Pergunta = "Quem é o mentor de Boruto?",
                                RespostaCorreta = "B) Brás Cubas",
                                Alternativas = new List<string> { "A) Martim Afonso de Sousa", "B) Brás Cubas", "C) Duarte Coelho", "D) Pedro Álvares Cabral",  }
                            },
                            new Acervo
                            {
                                Id = 2,
                                Pergunta = "2- Em que ano foi fundada a cidade de Santos?",
                                RespostaCorreta = "B) 1546",
                                Alternativas = new List<string> { "A) 1500", "B) 1546", "C) 1600", "D) 1630" }
                            },
                            new Acervo
                            {
                                Id = 3,
                                Pergunta = "3- Qual produto agrícola foi fundamental para a prosperidade de Santos durante o período colonial?",
                                RespostaCorreta = "C) Café",
                                Alternativas = new List<string> { "A) Algodão", "B) Milho", "C) Café", "D) Cana-de-açúcar" }
                            },
                        }
                    }
                }
            };

            var quiz = usu.Quizzes[0];
            var questoes = quiz.Questoes;

          
            int corretas = 0;

            for (int i = 0; i < questoes.Count; i++)
            {
                if (respostas[i] == questoes[i].RespostaCorreta)
                {
                    corretas++;
                }
            }

            ViewBag.Corretas = corretas;
            ViewBag.Total = questoes.Count;
            ViewBag.Respostas = respostas;
            ViewBag.Quiz = quiz;

            return View();
        }


    }
}
