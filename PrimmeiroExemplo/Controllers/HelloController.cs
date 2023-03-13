using Microsoft.AspNetCore.Mvc;
using PrimmeiroExemplo.Models;

namespace PrimmeiroExemplo.Controllers
{
    public class HelloController : Controller
    {
        public ActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Gustavo",
                Idade = 25,
                Cidade = "sÃO pAULO",
                HorarioEntrada = DateTime.UtcNow.Hour,
                HorarioEntradaSaudacoes = "",
                Bebida = true,
                Drink = true
          

            };

           if(aluno.HorarioEntrada >= 18)
            {
                aluno.HorarioEntradaSaudacoes = "Boa noite";
            }


            return View(aluno);
        }
        public ActionResult Inserir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Inserir(Aluno aluno)
        {// Action pra receber o post

            if (aluno.Bebida == true)
            {
                return View("Resultado", aluno);
            }

            return View(aluno);
        }
        }

    }


        
    

