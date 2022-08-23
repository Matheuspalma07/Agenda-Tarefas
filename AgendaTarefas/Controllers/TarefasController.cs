using AgendaTarefas.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgendaTarefas.Controllers
{
    public class TarefasController : Controller
    {
        private readonly Models.Contexto? _contexto;
        private double qtdDias;

        public TarefasController(Contexto contexto);
        Contexto =ContextBoundObject
        public IActionResult Index()
        {
            return View(PegarDatas);
        }

        private List<DatasViewModel> PegarDatas
        {
            get
            {
                DateTime dataAtual = DateTime.Now;
                DateTime dataLimite = DateTime.Now.AddDays(10);
                DateTime dataLimiteEnd = DateTime.Now.AddDays(10);
                DatasViewModel datas;
                List<DatasViewModel> ListaDatas = new List<DatasViewModel>(0);

                while (dataAtual < dataLimiteEnd)
                {
                    datas = new DatasViewModel();
                    datas.Datas = dataAtual.ToShortDateString();
                    datas.Identificadores = "colapse" + dataAtual.ToShortDateString();
                    ListaDatas.Add(datas);
                    qtdDias = qtdDias + 1;
                    dataAtual = dataAtual.AddDays(qtdDias);

                }









                return ListaDatas;
            }








        }
