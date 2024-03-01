using Microsoft.AspNetCore.Mvc;

namespace ExercicioBingoAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
           static List<int> numeros = new List<int>();
  
        [HttpGet("CriarLista")]
        public List<int> CriarLista()
        {
         

            for (int i = 1; i < 76; i++)
            {
                numeros.Add(i);
            }

            return numeros;
           
        }

        [HttpGet("Lista")]
        public List<int> Lista()
        {
            return numeros;
        }

            [HttpGet("Sortear")]
        public string Sortear()
        {
            Random aleatorio = new Random();
            int numero = aleatorio.Next(0, numeros.Count);

        if(numeros.Count > 0)
            {
                if (numeros[numero] <= 15)
                {
                    numeros.Remove(numero);
                    return "B-" + Convert.ToString(numeros[numero]);
                }
                else if (numeros[numero] > 15 && numeros[numero] <= 30)
                {
                    numeros.Remove(numero);
                    return "I-" + Convert.ToString(numeros[numero]);
                }
                else if (numeros[numero] > 30 && numeros[numero] <= 45)
                {
                    numeros.Remove(numero);
                    return "N-" + Convert.ToString(numeros[numero]);
                    
                }
                else if (numeros[numero] > 45 && numeros[numero] <= 60)
                {
                    numeros.Remove(numero);
                    return "G-" + Convert.ToString(numeros[numero]);
                }
                else
                {
                    numeros.Remove(numero);
                    return "O-" + Convert.ToString(numeros[numero]); 
                }
            }
            else
            {
                return "Finalizado";
            }           
        }
    }
}
