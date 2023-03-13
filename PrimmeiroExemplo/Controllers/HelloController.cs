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
                HorarioEntradaSaudacoes=""

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

        public ActionResult Inserir(Aluno aluno)
        {// Action pra receber o post
            return View(Resu);
        }

    }


        }
    

