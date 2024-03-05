using Eq2Grau.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eq2Grau.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        /// <summary>
        /// Portal de entrada dos pedidos feitos pelo browser
        /// Método para calculas as raízes de uma equação de 2º grau
        /// </summary>
        /// <param name="A">Parametro para x^2</param>
        /// <param name="B">Parametro para x</param>
        /// <param name="C">Parametro para num independente</param>
        /// <returns></returns>       
        public IActionResult Index(string A,  string B, string C)
        {
            /*Algoritmo
             * 1- Ler os parametros A,B e C
             * 2- Validar se pode fazer as Operações
             *  2.1- Têm de ser números
             *  2.2- A tem de ser diferente de 0
             * 3-Se posso calcular,:
             *  3.1- determinar as raízes
             *      3.1.1 x=((-b +/- sqr(b^2-4ac))/(2a))
             *      3.1.2 cacular o delta : b^2-4ac
             *          3.1.2.1 se o delta > 0 , há 2 raizes distintas , x1 e x2
             *          3.1.2.2 se delta = 0 , há duas raizes iguais , x1=x2
             *          3.1.2.3 se delta < 0 , há 2 raizes complexas conjugadas , x1 = -b/(2a) + sqrt(-delta)/(2a) i
             *                                                                    x2 = -b/(2a) - sqrt(-delta)/(2a) i
             *  3.2 - Enviar a resposta para o cliente
             * se não posso calcular (else)
             *   enviar mensagem de erro para o cliente (browser)
             */


            double a = double.Parse(A);
            double b = double.Parse(B);
            double c = double.Parse(C);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
